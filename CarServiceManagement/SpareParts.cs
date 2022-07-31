using CarServiceManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class SpareParts : Form
    {
        public SpareParts()
        {
            InitializeComponent();
            Load_SpareParts();
        }
        private void Load_SpareParts()
        {
            DataTable dtDept = DataProvider.Instance.ExecuteQuery("select p.*,pt.name as type_name from PartType pt,Part p where pt.parttypeID = p.part_type;");
            gunaDtgvParts.DataSource = dtDept;
        }

        private void ImageButtonAdd_Click(object sender, EventArgs e)
        {
            SparePartModule sparePartModule = new SparePartModule(this);
            sparePartModule.ShowDialog();
        }
    }
}
