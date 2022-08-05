use GarageServiceDB
go


/***************************************** CREATE TABLE **********************************************************/
if(OBJECT_ID('Part') is not null)
	drop table Part
go
CREATE TABLE Part
(
    partID int IDENTITY(1,1) NOT NULL,
	name nvarchar(255),
	stock int default 0,
	price money,
	currency varchar(12),
	cal_unit nvarchar(50),
	descriptions nvarchar(255),
	part_type int, -- FK
	brand nvarchar(150),
	primary key (partID)
)


if(OBJECT_ID('PartType') is not null)
	drop table PartType
go
CREATE TABLE PartType
(
    parttypeID int IDENTITY(1,1) NOT NULL,
	name nvarchar(255) unique,
	primary key (parttypeID)
)

-- PART -> Part type
alter table Part 
add constraint FK_Part_PartType
foreign key (part_type) references PartType(parttypeID);


if(OBJECT_ID('Vehicle') is not null)
	drop table Vehicle
go
CREATE TABLE Vehicle
(
    vehicleID int IDENTITY(1,1) NOT NULL,
	name nvarchar(125),
	color nvarchar(55),
	typeID int, --FK
	brandID int, --FK
	plate_number nvarchar(15) unique,
	descriptions nvarchar(255),
	customerID int, --FK
	primary key (vehicleID)
)

if(OBJECT_ID('VehicleType') is not null)
	drop table VehicleType
go
CREATE TABLE VehicleType
(
    typeID int IDENTITY(1,1) NOT NULL,
	type_name nvarchar(125) unique,
	primary key (typeID)
)


if(OBJECT_ID('VehicleBrand') is not null)
	drop table VehicleBrand
go
CREATE TABLE VehicleBrand
(
    brandID int IDENTITY(1,1) NOT NULL,
	brand_name nvarchar(125) unique,
	primary key (brandID)
)

if(OBJECT_ID('Customer') is not null)
	drop table Customer
go
CREATE TABLE Customer
(
    customerID int IDENTITY(1,1) NOT NULL,
	name nvarchar(255),
	email varchar(45) unique,
	phone varchar(20) unique,
	province nvarchar(150),
	district nvarchar(150),
	address_detail nvarchar(250),
	created_date date default getdate(),
	updated_date date default getdate(),
	primary key (customerID)
)

-- Vehicle -> Type
alter table Vehicle
add constraint FK_Vehicle_VehicleType
foreign key (typeID) references VehicleType(typeID);

-- Vehicle -> Brand
alter table Vehicle
add constraint FK_Vehicle_VehicleBrand
foreign key (brandID) references VehicleBrand(brandID);


-- Vehicle -> Customer
alter table Vehicle
add constraint FK_Vehicle_Customer
foreign key (customerID) references Customer(customerID);



DBCC CHECKIDENT ('Part', RESEED, 1);
GO
DBCC CHECKIDENT ('PartType', RESEED, 1);
GO
DBCC CHECKIDENT ('Customer', RESEED, 1);
GO
DBCC CHECKIDENT ('VehicleType', RESEED, 1);
GO
DBCC CHECKIDENT ('VehicleBrand', RESEED, 1);
GO
DBCC CHECKIDENT ('Vehicle', RESEED, 1);
GO




-- @@@@@@@@@@@@@@@@@@@ INSERT DATA @@@@@@@@@@@@@@@@@@@ --
--@@ PART TYPE
INSERT INTO PartType(name) VALUES(N'ກົງລົດ')
INSERT INTO PartType(name) VALUES(N'ລໍ້ແມັກ')
INSERT INTO PartType(name) VALUES(N'ຢາງໃນ')

--@@ CUSTOMER
INSERT INTO Customer(name,email,phone,province,district,address_detail) 
VALUES(N'ໂຕ້','to2022@gmail.com','02054433029',N'ອຸດົມໄຊ',N'ສີສັດຕະນາກ',N'14,ສຸພານຸວົງ')

INSERT INTO Customer(name,email,phone,province,district,address_detail) 
VALUES(N'ແຈັກ','jack2022@gmail.com','02074433029',N'ນະຄອນຫຼວງ',N'ສີໂຄດຕະບອງ',N'13,ສຸພານຸວົງ')

INSERT INTO Customer(name,email,phone,province,district,address_detail) 
VALUES(N'ແມັກ','mack2022@gmail.com','02054433021',N'ນະຄອນຫຼວງ',N'ໄຊເສດຖາ',N'12,ສຸພານຸວົງ')


--@@ VEHICLE TYPE
INSERT INTO VehicleType(type_name) 
VALUES(N'ລົດກະບະ')
INSERT INTO VehicleType(type_name) 
VALUES(N'ລົດເກັງ')

--@@ VEHICLE BRAND
INSERT INTO VehicleBrand(brand_name) 
VALUES(N'TOYOTA')
INSERT INTO VehicleBrand(brand_name) 
VALUES(N'Audi')



--@@ VEHICLE
INSERT INTO Vehicle(name,color,typeID,brandID,plate_number,descriptions,customerID) 
VALUES(N'Toyota vios 2011',N'ຂາວ,ດຳ',1,2,N'ກຂ 4923',N'ອະທິບາຍ',1)

INSERT INTO Vehicle(name,color,typeID,brandID,plate_number,descriptions,customerID) 
VALUES(N'Nissan 2011',N'ຂາວ,ດຳ',2,2,N'ກຂ 9923',N'ອະທິບາຍ',2)


--@@ PARTS
DECLARE @Counter INT 
SET @Counter=1
WHILE ( @Counter <= 20)
BEGIN
   INSERT INTO Part(name,stock,price,currency,cal_unit,descriptions,part_type,brand)	
			VALUES(N'ກົງລົດ d-max 4x4', 34,1500000,'KIP',N'ຄູ່',N'ອະທິບາຍ',1,'Zenko')
			SET @Counter  = @Counter  + 1
END



---------------------- @@@ QUERY @@@ -------------------------------

--select p.*,pt.name as type_name from PartType pt,Part p where pt.parttypeID = p.part_type
--and concat(p.name, pt.name, p.brand) LIKE N'%%'

--SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder 
--FROM tbProduct AS p INNER JOIN tbBrand AS b ON b.id = p.bid INNER JOIN tbCategory AS c on c.id = p.cid 
--WHERE CONCAT(p.pdesc, b.brand, c.category) LIKE '%" +txtSearch.Text+ "%'

select * from Customer
select * from Vehicle
