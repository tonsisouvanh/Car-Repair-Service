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


alter table Part 
add constraint FK_Part_PartType
foreign key (part_type) references PartType(parttypeID);


DBCC CHECKIDENT ('Part', RESEED, 1);
GO
DBCC CHECKIDENT ('PartType', RESEED, 1);
GO


-- @@@@@@@@@@@@@@@@@@@ INSERT DATA @@@@@@@@@@@@@@@@@@@ --
--@@ PART TYPE
INSERT INTO PartType(name) VALUES(N'ກົງລົດ')
INSERT INTO PartType(name) VALUES(N'ລໍ້ແມັກ')
INSERT INTO PartType(name) VALUES(N'ຢາງໃນ')

--@@ PARTS
DECLARE @Counter INT 
SET @Counter=1
WHILE ( @Counter <= 20)
BEGIN
   INSERT INTO Part(name,stock,price,currency,cal_unit,descriptions,part_type,brand)	
			VALUES(N'ກົງລົດ d-max 4x4', 34,1500000,'KIP',N'ຄູ່',N'ອະທິບາຍ',1,'Zenko')
			SET @Counter  = @Counter  + 1
END





select p.*,pt.name as type_name from PartType pt,Part p where pt.parttypeID = p.part_type;
select * from PartType;
Select * from Part;


delete PartType where parttypeID = 1

select p.*,pt.name as type_name from PartType pt,Part p where pt.parttypeID = p.part_type
and concat(p.name, pt.name, p.brand) LIKE N'%%'

SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder 
FROM tbProduct AS p INNER JOIN tbBrand AS b ON b.id = p.bid INNER JOIN tbCategory AS c on c.id = p.cid 
WHERE CONCAT(p.pdesc, b.brand, c.category) LIKE '%" +txtSearch.Text+ "%'