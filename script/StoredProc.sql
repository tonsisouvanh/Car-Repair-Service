use GarageServiceDB
go

-- @@@@@@@@@@@@@@@@@@@@@@ Spare Parts @@@@@@@@@@@@@@@@@@@@@@@
-- @@ Create Part
if(OBJECT_ID('sp_AddPart') is not null)
	drop proc sp_AddPart
go
create procedure sp_AddPart 
	@name nvarchar(255), @stock int, 
	@price money, @currency nvarchar(45), 
	@cal_unit nvarchar(55), @description nvarchar(255),
	@part_type int, @brand nvarchar(150)
as
begin

	INSERT INTO Part(name,stock,price,currency,cal_unit,descriptions,part_type,brand)	
	VALUES(@name, @stock,@price,@currency,@cal_unit,@description,@part_type,@brand)

end
GO


-- @@ Update Part
if(OBJECT_ID('sp_UpdatePart') is not null)
	drop proc sp_UpdatePart
go
create procedure sp_UpdatePart 
	@name nvarchar(255), @stock int, 
	@price money, @currency nvarchar(45), 
	@cal_unit nvarchar(55), @description nvarchar(255),
	@part_type int, @brand nvarchar(150), @partId int
as
begin

	UPDATE Part SET name = @name,
					stock = @stock,
					price = @price,
					currency = @currency,
					cal_unit = @cal_unit,
					descriptions = @description,
					part_type = @part_type,
					brand = @brand
	WHERE partID = @partId

end
GO


-- @@@@@@@@@@@@@@@@@@@@@@ Customers @@@@@@@@@@@@@@@@@@@@@@@
-- @@ Create Customer
--if(OBJECT_ID('sp_AddCustomer') is not null)
--	drop proc sp_AddCustomer
--go
--create procedure sp_AddCustomer
--	@name nvarchar(255), @email varchar(45),
--	@phone varchar(20), @province nvarchar(150),
--	@district nvarchar(150), @address_detail nvarchar(250),
--	@vehicleName nvarchar(125), @color nvarchar(55),
--	@typeID int, @brandID int, @plate_number nvarchar(15),
--	@descriptions nvarchar(255)
--as
--begin

--	SET NOCOUNT ON;
--	SET XACT_ABORT ON;

--	INSERT INTO Customer(name,email,phone,province,district,address_detail) 
--	VALUES(@name,@email,@phone,@province,@district,@address_detail)
	
--	if(@@ROWCOUNT != 0)
--	begin
--		INSERT INTO Vehicle(name,color,typeID,brandID,plate_number,descriptions,customerID) 
--		VALUES(@vehicleName,@color,@typeID,@brandID,@plate_number,@descriptions,SCOPE_IDENTITY())
--	end

--	SET NOCOUNT OFF;
--	SET XACT_ABORT OFF;
--end
--GO

---- test
--begin tran
	
--	exec sp_AddCustomer N'ສົມສະຫວັນ','somsavanh@gmail.com', '02056655906', N'Vientiane',
--	N'Saysetha', N'53,ສຸພານຸວົງ', N'Masda cx-3 5000', N'ປອນປົນແດງ', 1,2,N'ຈຈ 9944', N'';
	 
--	INSERT INTO Customer(name,email,phone,province,district,address_detail) 
--	VALUES(N'ແມັກ','max202a2@gmail.com','02054433028',N'ນະຄອນຫຼວງ',N'ໄຊເສດຖາ',N'12,ສຸພານຸວົງ')


--	select cus.*, v.name from Customer cus, Vehicle v
--	where cus.customerID = v.customerID

--	select * from Customer
--	select * from Vehicle

--commit tran

--rollback tran

if(OBJECT_ID('sp_AddCustomer') is not null)
	drop proc sp_AddCustomer
go
create procedure sp_AddCustomer
	@name nvarchar(255), @email varchar(45),
	@phone varchar(20), @province nvarchar(150),
	@district nvarchar(150), @address_detail nvarchar(250)
as
begin

	INSERT INTO Customer(name,email,phone,province,district,address_detail) 
	VALUES(@name,@email,@phone,@province,@district,@address_detail)
	
end
GO

-- test
--begin tran
	
--	exec sp_AddCustomer N'ສົມສະຫວັນ','somsavanh@gmail.com', '02056655906', N'Vientiane',
--	N'Saysetha', N'53,ສຸພານຸວົງ';
	 
--	INSERT INTO Customer(name,email,phone,province,district,address_detail) 
--	VALUES(N'ແມັກ','max202a2@gmail.com','02054433028',N'ນະຄອນຫຼວງ',N'ໄຊເສດຖາ',N'12,ສຸພານຸວົງ')


--	select cus.*, v.name from Customer cus, Vehicle v
--	where cus.customerID = v.customerID

--	select * from Customer
--	select * from Vehicle

--commit tran

--rollback tran



-- @@ Update Customer
if(OBJECT_ID('sp_UpdateCustomer') is not null)
	drop proc sp_UpdateCustomer
go
create procedure sp_UpdateCustomer
	@name nvarchar(255), @email varchar(45),
	@phone varchar(20), @province nvarchar(150),
	@district nvarchar(150), @address_detail nvarchar(250),
	@customerID int
as
begin

	UPDATE Customer
	set name = @name,email = @email,phone = @phone,province = @province,
	district = @district,address_detail = @address_detail, updated_date = getdate()
	where customerID = @customerID

end
GO

-- test
--begin tran
	
--	exec sp_UpdateCustomer N'ສົມສະຫວັນ','somsavanh@gmail.com', '02054433029', N'Vientiane',
--	N'Saythani', N'523,ສຸພານຸວົງ',4;


--	select cus.*, v.name from Customer cus, Vehicle v
--	where cus.customerID = v.customerID

--	select * from Customer
--	select * from Vehicle

--commit tran

--rollback tran




-- @@ delete Customer
--if(OBJECT_ID('sp_UpdateCustomer') is not null)
--	drop proc sp_UpdateCustomer
--go
--create procedure sp_UpdateCustomer
--	@name nvarchar(255), @email varchar(45),
--	@phone varchar(20), @province nvarchar(150),
--	@district nvarchar(150), @address_detail nvarchar(250),
--	@customerID int
--as
--begin

--	UPDATE Customer
--	set name = @name,email = @email,phone = @phone,province = @province,
--	district = @district,address_detail = @address_detail, updated_date = getdate()
--	where customerID = @customerID

--end
--GO

---- test
--begin tran
	
--	exec sp_UpdateCustomer N'ສົມສະຫວັນ','somsavanh@gmail.com', '02054433029', N'Vientiane',
--	N'Saythani', N'523,ສຸພານຸວົງ',4;


--	select cus.*, v.name from Customer cus, Vehicle v
--	where cus.customerID = v.customerID

--	select * from Customer
--	select * from Vehicle

--commit tran

--rollback tran


-- @@@@@@@@@@@@@@@@@@@@@@ Vehicles @@@@@@@@@@@@@@@@@@@@@@@
-- @@ Add Vehicles --===================================================================
if(OBJECT_ID('sp_AddVehicle') is not null)
	drop proc sp_AddVehicle
go
create procedure sp_AddVehicle
	@name nvarchar(255), @color nvarchar(55),
	@typeID int, @brandID int,
	@plate_number nvarchar(20), @descriptions nvarchar(250),
	@customerID int
as
begin

	INSERT INTO Vehicle(name,color,typeID,brandID,plate_number,descriptions,customerID) 
	VALUES(@name, @color, @typeID, @brandID, @plate_number, @descriptions, @customerID)
	
end
GO

-- test
--begin tran
	
--	--exec sp_AddVehicle N'';
	 

--commit tran

--rollback tran

--=========================================================================================



-- @@ Update Vehicles --===================================================================
if(OBJECT_ID('sp_UpdateVehicle') is not null)
	drop proc sp_UpdateVehicle
go
create procedure sp_UpdateVehicle
	@name nvarchar(255), @color nvarchar(55),
	@typeID int, @brandID int,
	@plate_number nvarchar(20), @descriptions nvarchar(250),
	@vehicleID int, @customerID int
as
begin

	UPDATE Vehicle
	SET name = @name,color = @color,typeID = @typeID,brandID = @brandID,
			plate_number = @plate_number,descriptions = @descriptions
			where vehicleID = @vehicleID and customerID = @customerID
	
end
GO

-- test
--begin tran
	
--	--exec sp_AddVehicle N'';
	 

--commit tran

--rollback tran

--=========================================================================================



-- @@@@@@@@@@@@@@@@@@@@@@ Part Import Bill @@@@@@@@@@@@@@@@@@@@@@@
-- @@ Add Bill --===================================================================

if(OBJECT_ID('sp_AddPartImportBill') is not null)
	drop proc sp_AddPartImportBill
go
create procedure sp_AddPartImportBill
	@supplier nvarchar(255), @supplier_contact varchar(125),
	@status nvarchar(125), @payment nvarchar(25),
	@descriptions nvarchar(255)
as
begin

	INSERT INTO PartImportBill(supplier,supplier_contact,status,payment,descriptions)
	VALUES (@supplier, @supplier_contact,@status,@payment,@descriptions)

end
GO

-- test
--begin tran
	
--	exec sp_AddPartImportBill N'ດັຫຳດ', '981279844',N'ຍັງບໍ່ຈ່າຍ',N'ສົດ',N'ກສາດ່ັຳນ ຍນຮັ່ຫກດນ'

--commit tran

--rollback tran

--====================================================================================



-- @@ update Bill --===================================================================

if(OBJECT_ID('sp_UpdatePartImportBill') is not null)
	drop proc sp_UpdatePartImportBill
go
create procedure sp_UpdatePartImportBill
	@supplier nvarchar(255), @supplier_contact varchar(125),
	@status nvarchar(125), @payment nvarchar(25), @created_date date,
	@descriptions nvarchar(255), @billID int
as
begin

	UPDATE PartImportBill
	SET supplier = @supplier,supplier_contact = @supplier_contact,status = @status,payment = @payment,
	descriptions = @descriptions, created_date = @created_date
	WHERE importbillID = @billID

end
GO

-- test
--begin tran
	
--	--exec sp_UpdatePartImportBill N'ດັຫຳດ', '981279844',N'ຍັງບໍ່ຈ່າຍ',N'ສົດ',N'ກສາດ່ັຳນ ຍນຮັ່ຫກດນ'

--commit tran

--rollback tran

--====================================================================================



-- @@ Add Bill Detail --===================================================================
if(OBJECT_ID('fn_CalPrice') is not null)
	drop function fn_CalPrice
go
CREATE FUNCTION fn_CalPrice
(@quantity int, @partID int)
RETURNS money
AS
BEGIN
	declare @price money;
	declare @result money;
	set @price = 0;
	set @result = 0;


	select @price = price from Part
	where partID = @partID
	
	set @result = @result + (@price * @quantity)

	RETURN @result;

END;
go
--test
--select * from Part
--select dbo.fn_CalPrice(10,100)



--if(OBJECT_ID('trg_onPartImportBillDetail') is not null)
--	drop trigger trg_onPartImportBillDetail
--go
--create trigger trg_onPartImportBillDetail on PartImportBillDetail
--for insert,update,delete
--As
--Begin
--	DECLARE @Action as char(1);
--	DECLARE @importbillID as int;
--	DECLARE @quantity as int;
--	DECLARE @partID as int;
--	DECLARE @subtotal as money;
--	DECLARE @currqty as int;



--    SET @Action = (CASE WHEN EXISTS(SELECT * FROM INSERTED)
--                         AND EXISTS(SELECT * FROM DELETED)
--                        THEN 'U'  -- Set Action to Updated.
--                        WHEN EXISTS(SELECT * FROM INSERTED)
--                        THEN 'I'  -- Set Action to Insert.
--                        WHEN EXISTS(SELECT * FROM DELETED)
--                        THEN 'D'  -- Set Action to Deleted.
--                        ELSE NULL -- Skip. It may have been a "failed delete".   
--                    END)

	


--	IF @Action = 'I' or @Action = 'U'
--	BEGIN
--		IF exists (select importbillID from inserted)
--		BEGIN
--			print 'Insert tran running'
--			select @importbillID = importbillID,@quantity = quantity,@partID = partID,@subtotal = subtotal from inserted;
--			select @currqty = quantity from PartImportBillDetail where partID = @partID and importbillID = @importbillID;
			
--			--handle bill total
--			update PartImportBill
--			set total = total + dbo.fn_CalPrice(@quantity,@partID)
--			--set total = total + @subtotal
--			where importbillID = @importbillID;


--			--handle part stock
--			update Part
--			set stock = stock + @quantity
--			where partID = @partID;

--		END
--	END
--	--IF @Action = 'U'
--	--BEGIN
--	--	IF exists (select importbillID from inserted)
--	--	BEGIN
--	--		print 'udate tran running'
--	--		select @importbillID = importbillID,@quantity = quantity,@partID = partID,@subtotal = subtotal from inserted;
--	--		--select @currqty = quantity from PartImportBillDetail where partID = @partID and importbillID = @importbillID;
--	--		select @currqty = quantity from PartImportBillDetail where importbilldetailID = 107;
--	--		select quantity from PartImportBillDetail where importbilldetailID = 107;

--	--		print 'here' + cast(@partID as varchar) + ' - curren = ' + cast(@currqty as varchar) + ' - quantity = '+ cast(@quantity as varchar)
--	--		--Increase
--	--		IF @quantity > @currqty
--	--		BEGIN
--	--			print 'Increase';
--	--			--handle bill total
--	--			update PartImportBill
--	--			set total = total + dbo.fn_CalPrice(@quantity - @currqty,@partID)
--	--			where importbillID = @importbillID;


--	--			--handle part stock
--	--			update Part
--	--			set stock = stock + (@quantity - @currqty)
--	--			where partID = @partID;
--	--		END
--	--		--Decrease
--	--		IF @quantity < @currqty
--	--		BEGIN
--	--			print 'deacrease';
--	--			--handle bill total
--	--			update PartImportBill
--	--			set total = total - dbo.fn_CalPrice(@currqty - @quantity,@partID)
--	--			where importbillID = @importbillID;


--	--			--handle part stock
--	--			update Part
--	--			set stock = stock - (@currqty - @quantity)
--	--			where partID = @partID;
--	--		END
--	--	END
--	--END
--	IF @Action = 'D'
--	BEGIN
--		IF exists (select importbillID from deleted)
--		BEGIN
--			select @importbillID = importbillID,@quantity = quantity,@partID = partID,@subtotal = subtotal from deleted;
--			--select @currqty = quantity from PartImportBillDetail where partID = @partID and importbillID = @importbillID;

--				--handle bill total
--				update PartImportBill
--				set total = total - dbo.fn_CalPrice(@quantity,@partID)
--				where importbillID = @importbillID;


--				--handle part stock
--				update Part
--				set stock = stock - @quantity
--				where partID = @partID;
--		END
--	END

--End
--go


--begin tran
--update PartImportBillDetail
--set quantity = 1 where importbilldetailID = 107


--rollback tran
--commit tran

if(OBJECT_ID('sp_AddPartImportBillDetail') is not null)
	drop proc sp_AddPartImportBillDetail
go
create procedure sp_AddPartImportBillDetail
	@partID int, @importBillID int, @quantity int
as
begin
	
	declare @subtotal money;

	-- add new item
	IF NOT EXISTS(select * from PartImportBillDetail where partID = @partID and importbillID = @importbillID)
	BEGIN
		set @subtotal = dbo.fn_CalPrice(@quantity,@partID);

		INSERT INTO PartImportBillDetail (partID, importbillID, quantity, subtotal)
		VALUES(@partID, @importBillID, @quantity, @subtotal)
	END
	ELSE
	BEGIN
		UPDATE PartImportBillDetail
		SET quantity = quantity + @quantity, subtotal = subtotal + dbo.fn_CalPrice(@quantity, @partID)
		where importbillID = @importBillID and partID = @partID;
	END

	IF(@@ROWCOUNT > 0)
	BEGIN
		--handle bill total
		update PartImportBill
		set total = total + dbo.fn_CalPrice(@quantity,@partID)
		--set total = total + @subtotal
		where importbillID = @importbillID;


		--handle part stock
		update Part
		set stock = stock + @quantity
		where partID = @partID;
	END
end
GO

--select * from Part
--select * from PartImportBill
--select * from PartImportBillDetail

----select pibd.importbilldetailID, pibd.partID, pibd.importbillID, p.name, p.price, pibd.quantity,p.cal_unit, pibd.subtotal
----from PartImportBillDetail pibd inner join Part p 
----on pibd.partID = p.partID

---- test
--begin tran
--	exec sp_AddPartImportBillDetail 102,102,1
--commit tran
--rollback tran

--====================================================================================










if(OBJECT_ID('sp_DeletePartImportBillDetail') is not null)
	drop proc sp_DeletePartImportBillDetail
go
create procedure sp_DeletePartImportBillDetail
	@importbilldetailID int,@partID int, @importBillID int, @quantity int, @subtotal money
as
begin
	
	DELETE PartImportBillDetail
	WHERE importbilldetailID = @importbilldetailID

	IF(@@ROWCOUNT > 0)
	BEGIN
		--handle bill total
		update PartImportBill
		set total = total - @subtotal
		--set total = total + @subtotal
		where importbillID = @importbillID;


		--handle part stock
		update Part
		set stock = stock - @quantity
		where partID = @partID;
	END
end
GO



--select * from Part
--select * from PartImportBill
--select * from PartImportBillDetail

--begin tran
--exec sp_DeletePartImportBillDetail 100,102,102,2,40

--rollback tran


--====================================================================================













-- @@@@@@@@@@@@@@@@@@@@@@ Repair Bill @@@@@@@@@@@@@@@@@@@@@@@
-- @@ Add Repair Bill --===================================================================

if(OBJECT_ID('sp_AddRepairBill') is not null)
	drop proc sp_AddRepairBill
go
create procedure sp_AddRepairBill
	@customerID int,@status nvarchar(125), @payment nvarchar(25),
	@descriptions nvarchar(255)
as
begin

	INSERT INTO RepairBill(customerID,status,payment,descriptions)
	VALUES (@customerID,@status,@payment,@descriptions)

end
GO

 --test
--begin tran
	
--	exec sp_AddRepairBill 101,N'ຍັງບໍ່ຈ່າຍ',N'ສົດ',N'ກສາດ່ັຳນ ຍນຮັ່ຫກດນ'

--commit tran

--rollback tran

--====================================================================================



-- @@ update Bill --===================================================================

if(OBJECT_ID('sp_UpdateRepairBill') is not null)
	drop proc sp_UpdateRepairBill
go
create procedure sp_UpdateRepairBill
	@status nvarchar(125), @payment nvarchar(25), @created_date date,
	@descriptions nvarchar(255),@repairbillID int
as
begin

	UPDATE RepairBill
	SET status = @status,payment = @payment,descriptions = @descriptions, created_date = @created_date
	WHERE repairbillID = @repairbillID

end
GO

-- test
--begin tran
	
--	exec sp_AddRepairBill 101,N'ຍັງບໍ່ຈ່າຍ',N'ສົດ',N'ກສາດ່ັຳນ ຍນຮັ່ຫກດນ'

--commit tran

--rollback tran

--====================================================================================




if(OBJECT_ID('sp_AddRepairBillDetail') is not null)
	drop proc sp_AddRepairBillDetail
go
create procedure sp_AddRepairBillDetail
	@partID int, @repairbillID int,@quantity int
as
begin
	
	declare @subtotal money;

	-- add new item
	IF NOT EXISTS(select * from RepairBillDetail where partID = @partID and repairbillID = @repairbillID)
	BEGIN
		set @subtotal = dbo.fn_CalPrice(@quantity,@partID);

		INSERT INTO RepairBillDetail(partID, repairbillID, quantity, subtotal)
		VALUES(@partID, @repairbillID, @quantity, @subtotal)
	END
	ELSE
	BEGIN
		UPDATE RepairBillDetail
		SET quantity = quantity + @quantity, subtotal = subtotal + dbo.fn_CalPrice(@quantity, @partID)
		where repairbillID = @repairbillID and partID = @partID;
	END

	IF(@@ROWCOUNT > 0)
	BEGIN
		--handle bill total
		update RepairBill
		set total = total + dbo.fn_CalPrice(@quantity,@partID)
		--set total = total + @subtotal
		where repairbillID = @repairbillID;


		--handle part stock
		update Part
		set stock = stock - @quantity
		where partID = @partID;
	END
end
GO


----select pibd.importbilldetailID, pibd.partID, pibd.importbillID, p.name, p.price, pibd.quantity,p.cal_unit, pibd.subtotal
----from PartImportBillDetail pibd inner join Part p 
----on pibd.partID = p.partID

---- test
--begin tran
--	exec sp_AddPartImportBillDetail 102,102,1
--commit tran
--rollback tran

--====================================================================================










--if(OBJECT_ID('sp_DeletePartImportBillDetail') is not null)
--	drop proc sp_DeletePartImportBillDetail
--go
--create procedure sp_DeletePartImportBillDetail
--	@importbilldetailID int,@partID int, @importBillID int, @quantity int, @subtotal money
--as
--begin
	
--	DELETE PartImportBillDetail
--	WHERE importbilldetailID = @importbilldetailID

--	IF(@@ROWCOUNT > 0)
--	BEGIN
--		--handle bill total
--		update PartImportBill
--		set total = total - @subtotal
--		--set total = total + @subtotal
--		where importbillID = @importbillID;


--		--handle part stock
--		update Part
--		set stock = stock - @quantity
--		where partID = @partID;
--	END
--end
--GO



--select * from Part
--select * from PartImportBill
--select * from PartImportBillDetail

--begin tran
--exec sp_DeletePartImportBillDetail 100,102,102,2,40

--rollback tran


--====================================================================================