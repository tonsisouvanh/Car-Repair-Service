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