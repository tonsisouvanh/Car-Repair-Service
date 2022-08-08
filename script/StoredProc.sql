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
begin tran
	
	exec sp_AddCustomer N'ສົມສະຫວັນ','somsavanh@gmail.com', '02056655906', N'Vientiane',
	N'Saysetha', N'53,ສຸພານຸວົງ';
	 
	INSERT INTO Customer(name,email,phone,province,district,address_detail) 
	VALUES(N'ແມັກ','max202a2@gmail.com','02054433028',N'ນະຄອນຫຼວງ',N'ໄຊເສດຖາ',N'12,ສຸພານຸວົງ')


	select cus.*, v.name from Customer cus, Vehicle v
	where cus.customerID = v.customerID

	select * from Customer
	select * from Vehicle

commit tran

rollback tran



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
begin tran
	
	exec sp_UpdateCustomer N'ສົມສະຫວັນ','somsavanh@gmail.com', '02054433029', N'Vientiane',
	N'Saythani', N'523,ສຸພານຸວົງ',4;


	select cus.*, v.name from Customer cus, Vehicle v
	where cus.customerID = v.customerID

	select * from Customer
	select * from Vehicle

commit tran

rollback tran


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
-- @@ Add Vehicles
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
begin tran
	
	--exec sp_AddVehicle N'';
	 

commit tran

rollback tran




-- @@ Update Vehicles
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
begin tran
	
	--exec sp_AddVehicle N'';
	 

commit tran

rollback tran


