using CarServiceManagement.DAO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CarServiceManagement.Models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class Dashboard
    {
        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomers { get; private set; }
        public int NumImportBill { get; private set; }
        public int NumProducts { get; private set; }

        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }

        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        //Constructor
        public Dashboard()
        {

        }

        //Private methods
        private void GetNumberItems()
        {
            try
            {
                string query = "";

                //Get Total Number of Customers
                query = "select count(customerID) from Customer";
                NumCustomers = (int)DataProvider.Instance.ExecuteScalar(query);

                //Get Total Number of Suppliers
                query = "select COUNT(importbillID) from PartImportBill;";
                NumImportBill = (int)DataProvider.Instance.ExecuteScalar(query);

                //Get Total Number of Products
                query = "select count(partID) from Part";
                NumProducts = (int)DataProvider.Instance.ExecuteScalar(query);

                //Get Total Number of Orders
                query = "select count(repairbillID) from RepairBill where created_date between '" + startDate + "' and '" + endDate + "'";
                NumOrders = (int)DataProvider.Instance.ExecuteScalar(query);

            }
            catch (Exception)
            {
                throw;
            }

        }

        private void GetProductAnalisys()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();
            string query = "";

            // get top 5 product
            query = @"select top 5 P.name, sum(RepairBillDetail.quantity) as Q
                        from RepairBillDetail
                        inner join Part P on P.partID = RepairBillDetail.partID
                        inner join RepairBill O on O.repairbillID = RepairBillDetail.repairbillID
                        where created_date between '" + startDate + "' and '" + endDate + "' group by P.name order by Q desc ";
            TopProductsList = DataProvider.Instance.ExecuteReaderStringInt(query);

            //get under stock list
            query = @"select name as ອາໄຫຼ່, stock as ຈຳນວນ
                      from Part
                      where stock <= 3";
            UnderstockList = DataProvider.Instance.ExecuteReaderStringInt(query);

        }

        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;
            string query = "";

            // sum total of revenue with defined date
            query = "select created_date, sum(total) as total from RepairBill where created_date between '" + startDate + "' and '" + endDate + "' group by created_date";
            var resultTable = new List<KeyValuePair<DateTime, decimal>>();
            resultTable = DataProvider.Instance.ExecuteReaderDatetimeDecimal(query);
            TotalRevenue = resultTable.Sum(x => Convert.ToDecimal(x.Value));

            //Sum total of part import bill
            query = "select sum(total) as total from PartImportBill";
            decimal invest = (decimal)DataProvider.Instance.ExecuteScalar(query);

            query = "select sum(total) as total from RepairBill";
            decimal revenue = (decimal)DataProvider.Instance.ExecuteScalar(query);
            TotalProfit = revenue - invest;

            //Group by Hours
            if (numberDays <= 1)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("hh tt")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            //Group by Days
            else if (numberDays <= 30)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("dd MMM")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }

            //Group by Weeks
            else if (numberDays <= 92)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = "Week " + order.Key.ToString(),
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }

            //Group by Months
            else if (numberDays <= (365 * 2))
            {
                bool isYear = numberDays <= 365 ? true : false;
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("MMM yyyy")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }

            //Group by Years
            else
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("yyyy")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
        }

        //Public methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
