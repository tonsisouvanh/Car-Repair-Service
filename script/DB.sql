use GarageServiceDB
go


/***************************************** CREATE TABLE **********************************************************/
if(OBJECT_ID('Provinces') is not null)
	drop table Provinces
go
CREATE TABLE Provinces
(
    provinceID int IDENTITY(1,1) NOT NULL,
	name nvarchar(55) unique,
	primary key (provinceID)
)

if(OBJECT_ID('Districts') is not null)
	drop table Districts
go
CREATE TABLE Districts
(
    districtID int IDENTITY(1,1) NOT NULL,
	name nvarchar(55) unique,
	primary key (districtID)
)

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
	phone varchar(20) unique not null,
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
DBCC CHECKIDENT ('Provinces', RESEED, 1);
GO
DBCC CHECKIDENT ('Districts', RESEED, 1);
GO


-- @@@@@@@@@@@@@@@@@@@ INSERT DATA @@@@@@@@@@@@@@@@@@@ --
INSERT INTO Provinces(name) VALUES (N'ອັດຕະປື');
INSERT INTO Provinces(name) VALUES (N'ບໍ່ແກ້ວ');
INSERT INTO Provinces(name) VALUES (N'ບໍລິຄຳໄຊ');
INSERT INTO Provinces(name) VALUES (N'ຈຳປາສັກ');
INSERT INTO Provinces(name) VALUES (N'ຫົວພັນ');
INSERT INTO Provinces(name) VALUES (N'ຄຳມ່ວນ');
INSERT INTO Provinces(name) VALUES (N'ຫຼວງນ້ຳທາ');
INSERT INTO Provinces(name) VALUES (N'ຫຼວງພະບາງ');
INSERT INTO Provinces(name) VALUES (N'ອຸດົມໄຊ');
INSERT INTO Provinces(name) VALUES (N'ຜົ້ງສາລີ');
INSERT INTO Provinces(name) VALUES (N'ສາລະວັນ');
INSERT INTO Provinces(name) VALUES (N'ສະຫວັນນະເຂດ');
INSERT INTO Provinces(name) VALUES (N'ເຊກອງ');
INSERT INTO Provinces(name) VALUES (N'ວຽງຈັນ');
INSERT INTO Provinces(name) VALUES (N'ນະຄອນຫຼວງວຽງຈັນ');
INSERT INTO Provinces(name) VALUES (N'ໄຊຍະບູລີ');
INSERT INTO Provinces(name) VALUES (N'ໄຊສົມບູນ');
INSERT INTO Provinces(name) VALUES (N'ຊຽງຂວາງ');

INSERT INTO Districts(name) VALUES (N'ແອດ');
INSERT INTO Districts(name) VALUES (N'ອະນຸວົງ');
INSERT INTO Districts(name) VALUES (N'ອາດສະພັງທອງ');
INSERT INTO Districts(name) VALUES (N'ອາດສະພອນ');
INSERT INTO Districts(name) VALUES (N'ບາຈຽງຈະເລີນສຸກ');
INSERT INTO Districts(name) VALUES (N'ແບງ');
INSERT INTO Districts(name) VALUES (N'ບໍລິຄັນ');
INSERT INTO Districts(name) VALUES (N'ບຸນເໜືອ');
INSERT INTO Districts(name) VALUES (N'ບຸນໃຕ້');
INSERT INTO Districts(name) VALUES (N'ບໍ່ແຕນ');
INSERT INTO Districts(name) VALUES (N'ບົວລະພາ');
INSERT INTO Districts(name) VALUES (N'ຈຳປາສັກ');
INSERT INTO Districts(name) VALUES (N'ຈຳພອນ');
INSERT INTO Districts(name) VALUES (N'ຈັນທະບູລີ');
INSERT INTO Districts(name) VALUES (N'ຈອມເພັດ');
INSERT INTO Districts(name) VALUES (N'ດັກຈຶງ');
INSERT INTO Districts(name) VALUES (N'ເຟືອງ');
INSERT INTO Districts(name) VALUES (N'ຫາດຊາຍຟອງ');
INSERT INTO Districts(name) VALUES (N'ຮ້ຽມ');
INSERT INTO Districts(name) VALUES (N'ຫີນບູນ');
INSERT INTO Districts(name) VALUES (N'ຫີນເຫີບ');
INSERT INTO Districts(name) VALUES (N'ຮົ່ມ');
INSERT INTO Districts(name) VALUES (N'ຫົງສາ');
INSERT INTO Districts(name) VALUES (N'ຮຸນ');
INSERT INTO Districts(name) VALUES (N'ຫົວເມືອງ');
INSERT INTO Districts(name) VALUES (N'ຫ້ວຍຊາຍ');
INSERT INTO Districts(name) VALUES (N'ກະເລິມ');
INSERT INTO Districts(name) VALUES (N'ກາສີ');
INSERT INTO Districts(name) VALUES (N'ໄກສອນພົມວິຫານ');
INSERT INTO Districts(name) VALUES (N'ແກ່ນທ້າວ');
INSERT INTO Districts(name) VALUES (N'ແກ້ວອຸດົມ');
INSERT INTO Districts(name) VALUES (N'ຄຳ');
INSERT INTO Districts(name) VALUES (N'ຄຳເກີດ');
INSERT INTO Districts(name) VALUES (N'ໂຂງ');
INSERT INTO Districts(name) VALUES (N'ໂຄງເຊໂດນ');
INSERT INTO Districts(name) VALUES (N'ຄອບ');
INSERT INTO Districts(name) VALUES (N'ຄູນ');
INSERT INTO Districts(name) VALUES (N'ຄຼນຄຳ');
INSERT INTO Districts(name) VALUES (N'ຂວາ');
INSERT INTO Districts(name) VALUES (N'ກວັນ');
INSERT INTO Districts(name) VALUES (N'ຫຼາ');
INSERT INTO Districts(name) VALUES (N'ລະຄອນເພງ');
INSERT INTO Districts(name) VALUES (N'ລະມາມ');
INSERT INTO Districts(name) VALUES (N'ເລົ່າງາມ');
INSERT INTO Districts(name) VALUES (N'ລອງ');
INSERT INTO Districts(name) VALUES (N'ລ້ອງແຈ້ງ');
INSERT INTO Districts(name) VALUES (N'ລ້ອງຊານ');
INSERT INTO Districts(name) VALUES (N'ຫຼວງພະບາງ');
INSERT INTO Districts(name) VALUES (N'ແມດ');
INSERT INTO Districts(name) VALUES (N'ມະຫາໄຊ');
INSERT INTO Districts(name) VALUES (N'ໃໝ່');
INSERT INTO Districts(name) VALUES (N'ປາກງື່ມ');
INSERT INTO Districts(name) VALUES (N'ໜື່ນ');
INSERT INTO Districts(name) VALUES (N'ເມິງ');
INSERT INTO Districts(name) VALUES (N'ມູນລະປະໂມກ');
INSERT INTO Districts(name) VALUES (N'ໜອກໄມ');
INSERT INTO Districts(name) VALUES (N'ນາກາຍ');
INSERT INTO Districts(name) VALUES (N'ນາແລ');
INSERT INTO Districts(name) VALUES (N'ນ້ຳບາກ');
INSERT INTO Districts(name) VALUES (N'ນາໝໍ້');
INSERT INTO Districts(name) VALUES (N'ນ້ຳທາ');
INSERT INTO Districts(name) VALUES (N'ນານ');
INSERT INTO Districts(name) VALUES (N'ນາຊາຍທອງ');
INSERT INTO Districts(name) VALUES (N'ງາ');
INSERT INTO Districts(name) VALUES (N'ເງີນ');
INSERT INTO Districts(name) VALUES (N'ງອຍ');
INSERT INTO Districts(name) VALUES (N'ຍົມມະລາດ');
INSERT INTO Districts(name) VALUES (N'ຍອດອູ');
INSERT INTO Districts(name) VALUES (N'ໜອງ');
INSERT INTO Districts(name) VALUES (N'ໝອງບົກ');
INSERT INTO Districts(name) VALUES (N'ໜອງແຣດ');
INSERT INTO Districts(name) VALUES (N'ອຸທຸມພອນ');
INSERT INTO Districts(name) VALUES (N'ປາກແຊງ');
INSERT INTO Districts(name) VALUES (N'ປາກແບງ');
INSERT INTO Districts(name) VALUES (N'ປາກກະດິງ');
INSERT INTO Districts(name) VALUES (N'ປາກເຊ');
INSERT INTO Districts(name) VALUES (N'ປາກຊ່ອງ');
INSERT INTO Districts(name) VALUES (N'ປາກທາ');
INSERT INTO Districts(name) VALUES (N'ປາກຊັນ');
INSERT INTO Districts(name) VALUES (N'ປາກອູ');
INSERT INTO Districts(name) VALUES (N'ປາກລາຍ');
INSERT INTO Districts(name) VALUES (N'ປະທຸມພອນ');
INSERT INTO Districts(name) VALUES (N'ແປກ');
INSERT INTO Districts(name) VALUES (N'ຜາອຸດົມ');
INSERT INTO Districts(name) VALUES (N'ພະລານໄຊ');
INSERT INTO Districts(name) VALUES (N'ຜາໄຊ');
INSERT INTO Districts(name) VALUES (N'ພຽງ');
INSERT INTO Districts(name) VALUES (N'ພິນ');
INSERT INTO Districts(name) VALUES (N'ຜົ້ງສາລີ');
INSERT INTO Districts(name) VALUES (N'ໂພນໂຮງ');
INSERT INTO Districts(name) VALUES (N'ໂພນທອງ');
INSERT INTO Districts(name) VALUES (N'ໂພນໄຊ');
INSERT INTO Districts(name) VALUES (N'ພູກູດ');
INSERT INTO Districts(name) VALUES (N'ພູຄູນ');
INSERT INTO Districts(name) VALUES (N'ພູວົງ');
INSERT INTO Districts(name) VALUES (N'ສາມັກຄີໄຊ');
INSERT INTO Districts(name) VALUES (N'ສຳພັນ');
INSERT INTO Districts(name) VALUES (N'ສະໝ້ວຍ');
INSERT INTO Districts(name) VALUES (N'ສະໜາມໄຊ');
INSERT INTO Districts(name) VALUES (N'ຊະນະສົມບູນ');
INSERT INTO Districts(name) VALUES (N'ສັງທອງ');
INSERT INTO Districts(name) VALUES (N'ຊານໄຊ');
INSERT INTO Districts(name) VALUES (N'ສາລະວັນ');
INSERT INTO Districts(name) VALUES (N'ເຊໂປນ');
INSERT INTO Districts(name) VALUES (N'ສີໂຄດຕະບອງ');
INSERT INTO Districts(name) VALUES (N'ສິງ');
INSERT INTO Districts(name) VALUES (N'ສີສັດຕະນາກ');
INSERT INTO Districts(name) VALUES (N'ສອງຄອນ');
INSERT INTO Districts(name) VALUES (N'ສົບເບົາ');
INSERT INTO Districts(name) VALUES (N'ສຸຂຸມາ');
INSERT INTO Districts(name) VALUES (N'ຕະໂອ່ຍ');
INSERT INTO Districts(name) VALUES (N'ທ່າແຂກ');
INSERT INTO Districts(name) VALUES (N'ທາພັງທອງ');
INSERT INTO Districts(name) VALUES (N'ທ່າພະບາດ');
INSERT INTO Districts(name) VALUES (N'ທ່າແຕງ');
INSERT INTO Districts(name) VALUES (N'ທາໂທມ');
INSERT INTO Districts(name) VALUES (N'ທົ່ງມີໄຊ');
INSERT INTO Districts(name) VALUES (N'ທຸລະຄົມ');
INSERT INTO Districts(name) VALUES (N'ຕົ້ນເຜິ້ງ');
INSERT INTO Districts(name) VALUES (N'ຕຸ້ມລານ');
INSERT INTO Districts(name) VALUES (N'ວັງວຽງ');
INSERT INTO Districts(name) VALUES (N'ວາປີ');
INSERT INTO Districts(name) VALUES (N'ວຽງຄຳ');
INSERT INTO Districts(name) VALUES (N'ວຽງພູຄາ');
INSERT INTO Districts(name) VALUES (N'ວຽງທອງ');
INSERT INTO Districts(name) VALUES (N'ວຽງໄຊ');
INSERT INTO Districts(name) VALUES (N'ວິລະບູລີ');
INSERT INTO Districts(name) VALUES (N'ຊຳເໜືອ');
INSERT INTO Districts(name) VALUES (N'ຊຳໃຕ້');
INSERT INTO Districts(name) VALUES (N'ຊະນະຄາມ');
INSERT INTO Districts(name) VALUES (N'ໄຊ');
INSERT INTO Districts(name) VALUES (N'ໄຊຍະບູລີ');
INSERT INTO Districts(name) VALUES (N'ໄຊບົວທອງ');
INSERT INTO Districts(name) VALUES (N'ໄຊບູລີ');
INSERT INTO Districts(name) VALUES (N'ໄຊຈຳພອນ');
INSERT INTO Districts(name) VALUES (N'ໄຊພູທອງ');
INSERT INTO Districts(name) VALUES (N'ໄຊສະຖານ');
INSERT INTO Districts(name) VALUES (N'ໄຊເສດຖາ');
INSERT INTO Districts(name) VALUES (N'ໄຊທະນີ');
INSERT INTO Districts(name) VALUES (N'ເຊບັ້ງໄຟ');
INSERT INTO Districts(name) VALUES (N'ຊຽງເງີນ');
INSERT INTO Districts(name) VALUES (N'ຊຽງຮ່ອນ');
INSERT INTO Districts(name) VALUES (N'ຊຽງຄໍ້');
INSERT INTO Districts(name) VALUES (N'ຊ່ອນ');
INSERT INTO Districts(name) VALUES (N'ຊົນບູລີ');


--@@ PART TYPE
INSERT INTO PartType(name) VALUES(N'ກົງລົດ')
INSERT INTO PartType(name) VALUES(N'ລໍ້ແມັກ')
INSERT INTO PartType(name) VALUES(N'ຢາງໃນ')

--@@ CUSTOMER
INSERT INTO Customer(name,email,phone,province,district,address_detail) 
VALUES(N'ໂຕ້','to2022@gmail.com','02054433029',N'ອຸດົມໄຊ',N'ສີສັດຕະນາກ',N'14,ສຸພານຸວົງ')

INSERT INTO Customer(name,email,phone,province,district,address_detail) 
VALUES(N'ແຈັກ','jack2022@gmail.com','02074433029',N'ນະຄອນຫຼວງວຽງຈັນ',N'ສີໂຄດຕະບອງ',N'13,ສຸພານຸວົງ')

INSERT INTO Customer(name,email,phone,province,district,address_detail) 
VALUES(N'ແມັກ','mack2022@gmail.com','02054433021',N'ນະຄອນຫຼວງວຽງຈັນ',N'ໄຊເສດຖາ',N'12,ສຸພານຸວົງ')

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
