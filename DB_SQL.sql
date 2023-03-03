CREATE TABLE dbo.STATUSES (
	Status varchar(20) PRIMARY KEY NOT NULL
	)
INSERT INTO dbo.STATUSES VALUES ('New Order'),('Graphic'),('HP'),('Cut'),('Roll'),('Delivery'),('Completed')

DROP TABLE dbo.PAPERTYPES

CREATE TABLE dbo.PAPERTYPES (
	PaperType varchar(20) PRIMARY KEY NOT NULL
	)
INSERT INTO dbo.PAPERTYPES VALUES ('Chrome'),('Velum'),('Classic'),('Saron'),('Adiflowerr'),('Pyum'),('Armando'),('Kable'),('Tume'),('White PVC'),('Black PVC'),('Picanto')

DROP TABLE dbo.FILETYPES

CREATE TABLE dbo.FILETYPES (
	FileType varchar(20) PRIMARY KEY NOT NULL
	)
INSERT INTO dbo.FILETYPES VALUES ('PDF'),('JPG'),('WORD')

DROP TABLE dbo.COLORTYPES

CREATE TABLE dbo.COLORTYPES (
	ColorType varchar(20) PRIMARY KEY NOT NULL
	)
INSERT INTO dbo.COLORTYPES VALUES ('Black'),('Gray'),('White'),('Pink'),('Red'),('Purple'),('Brown'),('Yellow'),('Orange'),('Green'),('Blue')

DROP TABLE dbo.EVENTCATEGORIES

CREATE TABLE dbo.EVENTCATEGORIES (
	EventCategory varchar(20) PRIMARY KEY NOT NULL
	)
INSERT INTO dbo.EVENTCATEGORIES VALUES ('Business Meeting'),('Private Meeting'),('Social Events')

DROP TABLE dbo.ROLES

CREATE TABLE dbo.ROLES (
	Role varchar(20) PRIMARY KEY NOT NULL
	)
INSERT INTO dbo.ROLES VALUES ('CEO'),('Production Manager'),('HP'),('Roll'),('Cut'),('Driver'),('Graphic Designer')

DROP TABLE dbo.GENDERS1

CREATE TABLE dbo.GENDERS1 (
	Gender varchar(20) PRIMARY KEY NOT NULL
	)
INSERT INTO dbo.GENDERS1 VALUES ('Male'),('Female'),('Other')

DROP TABLE dbo.BOOLEANS

CREATE TABLE dbo.BOOLEANS(
	Boolean varchar(5) NOT NULL PRIMARY KEY
)
INSERT INTO dbo.BOOLEANS VALUES ('True'),('False')


--classes
--EMPLOYEES
DROP TABLE dbo.EMPLOYEES
CREATE TABLE dbo.EMPLOYEES (
	EmployeeNum int PRIMARY KEY NOT NULL,
	EmployeeName varchar(50) NOT NULL,
	Password varchar(15) NOT NULL,
	PhoneNum varchar(10) NOT NULL,
	Email varchar(50) NOT NULL,
	Gender varchar(20) REFERENCES GENDERS1(Gender) NOT NULL,
	EmpRole varchar (20) REFERENCES ROLES(Role) NOT NULL,
	Birthday dateTime NOT NULL,
	Address varchar(50) NOT NULL,
	Activation varchar(5) REFERENCES BOOLEANS(Boolean) NOT NULL
	)

DROP PROCEDURE  dbo.Get_all_Employees
CREATE PROCEDURE dbo.Get_all_Employees
AS
Select * from dbo.Employees


DROP PROCEDURE  dbo.Get_all_Active_Employees
CREATE PROCEDURE dbo.Get_all_Active_Employees
AS
Select * from dbo.Employees
Where dbo.Employees.Activation='True'

EXECUTE Get_all_Active_Employees

DROP PROCEDURE  dbo.SP_add_Employee
CREATE PROCEDURE dbo.SP_add_Employee
@empNum integer, @name varchar(50),@pass varchar(15),
@phone varchar(10), @email varchar(50), @gender varchar(20), @role varchar(20),
@birthday datetime ,@address varchar(50), @active varchar(5)
AS
INSERT INTO dbo.Employees
Values (@empNum, @name, @pass, @phone, @email, @gender,@role, @birthday, @address, @active)


DROP PROCEDURE  dbo.SP_Update_Employee
CREATE PROCEDURE dbo.SP_Update_Employee
@empNum integer, @name varchar(20),@pass varchar(20),
@phone varchar(10), @email varchar(50), @gender varchar(10), @role varchar(30),
@birthday datetime ,@address varchar(30), @active varchar(5)
AS
Update dbo.Employees
SET
EmployeeName=@name, Password=@pass, PhoneNum=@phone, Email =@email, Gender=@gender,
EmpRole=@role, Birthday=@birthday, Address=@address, Activation=@active
WHERE EmployeeNum=@empNum

DROP PROCEDURE  dbo.Get_Employee
Create Procedure dbo.Get_Employee @empNum integer
AS
Select*from dbo.Employees
WHERE EmployeeNum=@empNum

DROP PROCEDURE dbo.SP_insertEmployees
CREATE PROCEDURE dbo.SP_insertEmployees
@EmployeeNum INTEGER, @EmployeeName VARCHAR(50),
@Password VARCHAR(20), @PhoneNum VARCHAR(10), @Email VARCHAR(20), @Gender varchar(10), @EmployeeRole VARCHAR(20), @Birthday datetime,
@Address VARCHAR(50), @Activation varchar(10)
AS
INSERT into dbo.EMPLOYEES
values (@EmployeeNum, @EmployeeName, @Password, @PhoneNum, @Email, @Gender, @EmployeeRole, @Birthday, @Address, @Activation)
	

--COLORS
DROP TABLE dbo.COLORS
CREATE TABLE dbo.COLORS(
	Color varchar(20) PRIMARY KEY REFERENCES COLORTYPES(ColorType) NOT NULL
	)


DROP PROCEDURE  dbo.Get_all_Colors
CREATE PROCEDURE dbo.Get_all_Colors
AS
Select * from dbo.COLORS


DROP PROCEDURE  dbo.SP_add_COLOR
CREATE PROCEDURE dbo.SP_add_COLOR
@color varchar(20)
AS
INSERT INTO dbo.COLORS
Values (@color)


DROP PROCEDURE  dbo.Get_Color
Create Procedure dbo.Get_Color @color varchar(20)
AS
Select*from dbo.COLORS
WHERE Color=@color

--GRAPHICS
DROP TABLE  dbo.GRAPHICS
CREATE TABLE dbo.GRAPHICS(
	GraphicNum int PRIMARY KEY NOT NULL,
	MadeBY varchar(5) REFERENCES BOOLEANS(Boolean) NOT NULL,
	IsConfirmed varchar(5) REFERENCES BOOLEANS(Boolean) NOT NULL
	)


DROP PROCEDURE  dbo.Get_all_GRAPHICS
CREATE PROCEDURE dbo.Get_all_GRAPHICS
AS
Select * from dbo.GRAPHICS


DROP PROCEDURE  dbo.SP_add_GRAPHIC
CREATE PROCEDURE dbo.SP_add_GRAPHIC
@GraphicNum integer, @MadeBY varchar(20),@IsConfirmed varchar(5)
AS
INSERT INTO dbo.GRAPHICS
Values (@GraphicNum, @MadeBY, @IsConfirmed)


DROP PROCEDURE  dbo.SP_Update_GRAPHIC
CREATE PROCEDURE dbo.SP_Update_GRAPHIC
@GraphicNum integer, @MadeBY varchar(20),@IsConfirmed varchar(5)
AS
Update dbo.GRAPHICS
SET
MadeBy=@MadeBY, IsConfirmed=@IsConfirmed
WHERE GraphicNum=@GraphicNum

DROP PROCEDURE  dbo.Get_GRAPHIC
Create Procedure dbo.Get_GRAPHIC @GraphicNum integer
AS
Select*from dbo.GRAPHICS
WHERE GraphicNum=@GraphicNum

--STICKERPAPERS
DROP TABLE  dbo.STICKERPAPERS
CREATE TABLE dbo.STICKERPAPERS(
	ProductNumber int PRIMARY KEY NOT NULL,
	ProductName varchar(20) REFERENCES PAPERTYPES(PaperType) NOT NULL,
	ProductWidth real NOT NULL,
	Quantity real NOT NULL
	)


DROP PROCEDURE  dbo.Get_all_STICKERPAPERS
CREATE PROCEDURE dbo.Get_all_STICKERPAPERS
AS
Select * from dbo.STICKERPAPERS


DROP PROCEDURE  dbo.SP_add_STICKERPAPERS
CREATE PROCEDURE dbo.SP_add_STICKERPAPERS
@ProductNumber integer, @ProductName varchar(20),@ProductWidth real,
@Quantity real
AS
INSERT INTO dbo.STICKERPAPERS
Values (@ProductNumber, @ProductName, @ProductWidth, @Quantity)


DROP PROCEDURE  dbo.SP_Update_STICKERPAPERS
CREATE PROCEDURE dbo.SP_Update_STICKERPAPERS
@ProductNumber integer, @ProductName varchar(20),@ProductWidth real,
@Quantity real
AS
Update dbo.STICKERPAPERS
SET
ProductName=@ProductName, ProductWidth=@ProductWidth
WHERE ProductNumber=@ProductNumber


DROP PROCEDURE  dbo.Get_STICKERPAPER
Create Procedure dbo.Get_STICKERPAPER @ProductNumber integer
AS
Select*from dbo.STICKERPAPERS
WHERE ProductNumber=@ProductNumber


--îöéàú ëîåú îìàé ùðùàøä îîåöø ìôé ùí äîåöø
DROP PROCEDURE  dbo.SP_PaperQuantity_ByType
CREATE PROCEDURE  dbo.SP_PaperQuantity_ByType
@PaperType varchar(20)
AS
select dbo.STICKERPAPERS.Quantity
from dbo.STICKERPAPERS
where  dbo.STICKERPAPERS.ProductName= @PaperType

--òãëåï ëîåú îìàé îîåöø
DROP PROCEDURE dbo.SP_Update_STICKERPAPERS_quantity
CREATE PROCEDURE dbo.SP_Update_STICKERPAPERS_quantity
@ProductName varchar(20), @Quantity real
AS
Update dbo.STICKERPAPERS
SET
Quantity=@Quantity
WHERE ProductName=@ProductName

DROP PROCEDURE dbo.SP_Update_STICKERPAPERS_quantity_Number
CREATE PROCEDURE dbo.SP_Update_STICKERPAPERS_quantity_Number
@ProductNum int, @Quantity real
AS
Update dbo.STICKERPAPERS
SET
Quantity=@Quantity
WHERE ProductNumber=@ProductNum

--EVENTS
DROP TABLE  dbo.EVENTS
CREATE TABLE dbo.EVENTS(
	EventNum int PRIMARY KEY NOT NULL,
	EventDate datetime NOT NULL,
	Description varchar(200),
	Category varchar(20) REFERENCES EVENTCATEGORIES(EventCategory) NOT NULL
	)



DROP PROCEDURE  dbo.Get_all_EVENTS
CREATE PROCEDURE dbo.Get_all_EVENTS
AS
Select * from dbo.EVENTS


DROP PROCEDURE  dbo.SP_add_EVENT
CREATE PROCEDURE dbo.SP_add_EVENT
@EventNum integer,@EventDate datetime , @Description varchar(200),@Category varchar(20)
AS
INSERT INTO dbo.EVENTS
Values (@EventNum,@EventDate, @Description,@Category)


DROP PROCEDURE  dbo.SP_Update_EVENT
CREATE PROCEDURE dbo.SP_Update_EVENT
@EventNum integer,@EventDate datetime , @Description varchar(200),@Category varchar(20)
AS
Update dbo.EVENTS
SET
EventDate=@EventDate, Description=@Description, Category=@Category
WHERE EventNum=@EventNum


DROP PROCEDURE  dbo.Get_EVENT
Create Procedure dbo.Get_EVENT @EventNum integer
AS
Select*from dbo.EVENTS
WHERE EventNum=@EventNum


--INVOICES
DROP TABLE dbo.INVOICES
CREATE TABLE dbo.INVOICES(
	InvoiceNum int PRIMARY KEY NOT NULL,
	Price real NOT NULL,
	DeliveryDate dateTime,
	Path varchar(100),
	OrderNum int,
	Signed varchar(5) REFERENCES BOOLEANS(Boolean) NOT NULL
	)



DROP PROCEDURE  dbo.Get_all_INVOICES
CREATE PROCEDURE dbo.Get_all_INVOICES
AS
Select * from dbo.INVOICES


DROP PROCEDURE  dbo.SP_add_INVOICE
CREATE PROCEDURE dbo.SP_add_INVOICE
@InvoiceNum int,@Price real , @DeliveryDate dateTime ,@Signed varchar(5),@Path varchar(100),@OrderNum int
AS
INSERT INTO dbo.INVOICES
Values (@InvoiceNum,@Price,@DeliveryDate,@Signed,@Path,@OrderNum)


DROP PROCEDURE  dbo.SP_Update_INVOICE
CREATE PROCEDURE dbo.SP_Update_INVOICE
@InvoiceNum int,@Price real , @DeliveryDate dateTime ,@Signed varchar(5),@Path varchar(100),@OrderNum int
AS
Update dbo.INVOICES
SET
Price=@Price, DeliveryDate=@DeliveryDate,Signed=@Signed,Path=@Path ,OrderNum=@OrderNum 
WHERE InvoiceNum=@InvoiceNum


DROP PROCEDURE  dbo.Get_INVOICE
Create Procedure dbo.Get_INVOICE @InvoiceNum integer
AS
Select*from dbo.INVOICES
WHERE InvoiceNum=@InvoiceNum

ALTER TABLE dbo.INVOICES
ADD Path varchar(100)

ALTER TABLE dbo.INVOICES
ADD OrderNum int
------------------------------------------------------------------------------
UPDATE INVOICES
SET OrderNum=(SELECT OrderNumber
              FROM ORDERS
			  WHERE ORDERS.InvoiceNum=INVOICES.InvoiceNum)
				
--CUSTOMERS
DROP TABLE  dbo.CUSTOMERS
CREATE TABLE dbo.CUSTOMERS(
	CustomerNumber int PRIMARY KEY NOT NULL,
	CustomerName varchar(50) NOT NULL,
	Phone varchar(10) NOT NULL,
	Email varchar(50) NOT NULL,

	CONSTRAINT CK_CustEmail CHECK (Email LIKE '%@%.%')
	)


DROP PROCEDURE  dbo.Get_all_CUSTOMERS
CREATE PROCEDURE dbo.Get_all_CUSTOMERS
AS
Select * from dbo.CUSTOMERS


DROP PROCEDURE  dbo.SP_add_CUSTOMER
CREATE PROCEDURE dbo.SP_add_CUSTOMER
@CustomerNumber integer, @CustomerName varchar(50),@phone varchar(10),@Email varchar(50)
AS
INSERT INTO dbo.CUSTOMERS
Values (@CustomerNumber, @CustomerName, @Phone, @Email)


DROP PROCEDURE  dbo.SP_Update_CUSTOMER
CREATE PROCEDURE dbo.SP_Update_CUSTOMER
@CustomerNumber integer, @CustomerName varchar(50),@phone varchar(10),@Email varchar(50)
AS
Update dbo.CUSTOMERS
SET
CustomerName=@CustomerName, phone=@phone, Email=@email
WHERE CustomerNumber=@CustomerNumber


DROP PROCEDURE  dbo.Get_CUSTOMER
Create Procedure dbo.Get_CUSTOMER @CustomerNumber integer
AS
Select*from dbo.CUSTOMERS
WHERE CustomerNumber=@CustomerNumber

--ôøåöãåøä ùîøàä äæîðåú ùì îñôø ì÷åç îñåééí áéï úàøéëéí
DROP PROCEDURE  dbo.SP_ShowAllOrder_ByCustomer
CREATE PROCEDURE  dbo.SP_ShowAllOrder_ByCustomer
@CustomerNum int, @FromDate datetime, @UntilDate datetime
AS
select *
from dbo.ORDERS
where  dbo.ORDERS.CustomerNum= @CustomerNum and dbo.ORDERS.DueDate between @FromDate and @UntilDate


--SUPPLIERS
DROP TABLE dbo.SUPPLIERS
CREATE TABLE dbo.SUPPLIERS (
	SupNumber int PRIMARY KEY NOT NULL,
	Phone varchar(10) NOT NULL,
	Email varchar(50) NOT NULL,
	SupAddress varchar(50) NOT NULL,
	IsActive varchar(5) REFERENCES dbo.BOOLEANS(Boolean) Default 'True' NOT NULL,
	Contact varchar(30)  NOT NULL default 'office',
	CONSTRAINT CK_SupEmail CHECK (Email LIKE '%@%.%')
	)



DROP PROCEDURE  dbo.Get_all_SUPPLIERS
CREATE PROCEDURE dbo.Get_all_SUPPLIERS
AS
Select * from dbo.SUPPLIERS


DROP PROCEDURE  dbo.SP_add_SUPPLIER
CREATE PROCEDURE dbo.SP_add_SUPPLIER
@SupNumber integer,@phone varchar(10),@Email varchar(50), @SupAddress varchar(50),@IsActive varchar(5),@Contact varchar(30)
AS
INSERT INTO dbo.SUPPLIERS
Values (@SupNumber,@Phone, @Email, @SupAddress,@IsActive,@Contact)


DROP PROCEDURE  dbo.SP_Update_SUPPLIER
CREATE PROCEDURE dbo.SP_Update_SUPPLIER
@SupNumber integer,@phone varchar(10),@Email varchar(50), @SupAddress varchar(50), @IsActive varchar(5),@Contact varchar(30)
AS
Update dbo.SUPPLIERS
SET
phone=@phone, Email=@email,SupAddress=@SupAddress, IsActive=@IsActive, Contact=@Contact
WHERE SupNumber=@SupNumber


DROP PROCEDURE  dbo.Get_SUPPLIER
Create Procedure dbo.Get_SUPPLIER @SupNumber integer
AS
Select*from dbo.SUPPLIERS
WHERE SupNumber=@SupNumber



--INVENTORYORDERS
DROP TABLE dbo.INVENTORYORDERS
CREATE TABLE dbo.INVENTORYORDERS(
	OrderNumber int PRIMARY KEY NOT NULL,
	DateOfOrder datetime NOT NULL,
	Arrived varchar(5) REFERENCES dbo.BOOLEANS(Boolean) NOT NULL,
	TotalPrice real NOT NULL,
	DeliveryDate dateTime,
	MadeBy int REFERENCES dbo.EMPLOYEES(EmployeeNum) NOT NULL,
	Supplier int REFERENCES dbo.SUPPLIERS(SupNumber) NOT NULL
	)


DROP PROCEDURE  dbo.Get_all_INVENTORYORDERS
CREATE PROCEDURE dbo.Get_all_INVENTORYORDERS
AS
Select * from dbo.INVENTORYORDERS


DROP PROCEDURE  dbo.SP_add_INVENTORYORDER
CREATE PROCEDURE dbo.SP_add_INVENTORYORDER
@OrderNumber integer,@DateOfOrder datetime,@Arrived varchar(5), @TotalPrice real,
@DeliveryDate dateTime,@MadeBy int,@Supplier int
AS
INSERT INTO dbo.INVENTORYORDERS
Values (@OrderNumber,@DateOfOrder, @Arrived, @TotalPrice,@DeliveryDate,@MadeBy,@Supplier)



DROP PROCEDURE  dbo.SP_Update_INVENTORYORDER
CREATE PROCEDURE dbo.SP_Update_INVENTORYORDERS
@OrderNumber integer,@DateOfOrder datetime,@Arrived varchar(5), @TotalPrice real,
@DeliveryDate dateTime,@MadeBy int,@Supplier int
AS
Update dbo.INVENTORYORDERS
SET
DateOfOrder=@DateOfOrder, Arrived=@Arrived,TotalPrice=@TotalPrice, DeliveryDate=@DeliveryDate,
MadeBy=@MadeBy, Supplier=@Supplier
WHERE OrderNumber=@OrderNumber



DROP PROCEDURE  dbo.Get_INVENTORYORDER
CREATE PROCEDURE dbo.Get_INVENTORYORDER @OrderNumber integer
AS
Select*from dbo.INVENTORYORDERS
WHERE OrderNumber=@OrderNumber



--ORDERS
DROP TABLE dbo.ORDERS
CREATE TABLE dbo.ORDERS (
	OrderNumber int PRIMARY KEY NOT NULL,
	OrderStatus varchar(15) Default 'New Order',
	DueDate dateTime NOT NULL,
	OrderPriority int  Default 5,
	Amount int NOT NULL,
	OrderAddress varchar(50) NOT NULL,
	DeliveryDate dateTime,
	Price real NOT NULL,
	Discount Real Default 0,
	StickerLength real NOT NULL,
	StickerWidth real NOT NULL,
	KnifeType int NOT NULL,
	CreateBy int REFERENCES dbo.EMPLOYEES(EmployeeNum),
	GraphicDesign int REFERENCES dbo.GRAPHICS(GraphicNum),
	InvoiceNum int REFERENCES dbo.INVOICES(InvoiceNum),
	CustomerNum int REFERENCES dbo.CUSTOMERS(CustomerNumber)
	)



DROP PROCEDURE  dbo.Get_all_ORDERS
CREATE PROCEDURE dbo.Get_all_ORDERS
AS
Select * from dbo.ORDERS

DROP PROCEDURE  dbo.Get_live_ORDERS
CREATE PROCEDURE dbo.Get_live_ORDERS
AS
select o.OrderNumber, o.OrderStatus, o.DueDate, o.OrderPriority
from ORDERS as o
where o.OrderStatus not in ('Completed','Delivery')

DROP PROCEDURE  dbo.SP_add_ORDER
CREATE PROCEDURE dbo.SP_add_ORDER
@OrderNumber integer,@OrderStatus varchar(15),@DueDate dateTime, @OrderPriority int,
@Amount int,@OrderAddress varchar(50),@DeliveryDate dateTime,@Price real,@Discount Real,
@StickerLength real,@StickerWidth real,@KnifeType int,@CreateBy int,@GraphicDesign int,@InvoiceNum int,
@CustomerNum int
AS
INSERT INTO dbo.ORDERS
Values (@OrderNumber,@OrderStatus, @DueDate, @OrderPriority,@Amount,@OrderAddress,@DeliveryDate,@Price,@Discount,
@StickerLength,@StickerWidth,@KnifeType,@CreateBy,@GraphicDesign,@InvoiceNum,@CustomerNum )



DROP PROCEDURE  dbo.SP_Update_ORDER
CREATE PROCEDURE dbo.SP_Update_ORDER
@OrderNumber integer,@OrderStatus varchar(15),@DueDate dateTime, @OrderPriority int,
@Amount int,@OrderAddress varchar(50),@DeliveryDate dateTime,@Price real,@Discount Real
,@StickerLength real,@StickerWidth real,@KnifeType int,@CreateBy int,@GraphicDesign int,@InvoiceNum int,
@CustomerNum int
AS
Update dbo.ORDERS
SET
OrderStatus=@OrderStatus, DueDate=@DueDate,OrderPriority=@OrderPriority, Amount=@Amount,
OrderAddress=@OrderAddress, DeliveryDate=@DeliveryDate, Price=@Price, Discount=@Discount
,StickerLength=@StickerLength, StickerWidth=@StickerWidth,KnifeType=@KnifeType,CreateBy=@CreateBy,
GraphicDesign=@GraphicDesign,InvoiceNum=@InvoiceNum
WHERE OrderNumber=@OrderNumber


DROP PROCEDURE  dbo.Get_ORDERS
Create Procedure dbo.Get_ORDERS @OrderNumber integer
AS
Select*from dbo.ORDERS
WHERE OrderNumber=@OrderNumber


--employees in events
DROP TABLE dbo.EMP_EVENT
CREATE TABLE dbo.EMP_EVENT(
	EventNum int REFERENCES dbo.EVENTS(EventNum) NOT NULL,
	EmployeeNum int REFERENCES dbo.EMPLOYEES(EmployeeNum) NOT NULL,

	CONSTRAINT PK_EvP PRIMARY KEY(EventNum, EmployeeNum)
	)



DROP PROCEDURE dbo.SP_add_EMPEVENT
CREATE PROCEDURE dbo.SP_add_EMPEVENT
@EventNum integer, @EmployeeNum int
AS
INSERT INTO dbo.EMP_EVENT
Values (@EventNum,@EmployeeNum)



DROP PROCEDURE dbo.SP_DELETE_EMPEVENT
CREATE PROCEDURE dbo.SP_DELETE_EMPEVENT
@EventNum integer, @EmployeeNum int
AS
DELETE FROM dbo.EMP_EVENT
WHERE EventNum=@EventNum AND EmployeeNum=@EmployeeNum


--ôøåöãåøä áùáéì äöâú øùéîú îùúúôéí áàéøåò îñåéí
DROP PROCEDURE dbo.SP_ShowEmp_InEvent
CREATE PROCEDURE dbo.SP_ShowEmp_InEvent
@EventNum int
AS
select  dbo.EMPLOYEES.EmployeeName

from dbo.EMP_EVENT
 join dbo.EMPLOYEES
on dbo.EMP_EVENT.EmployeeNum = dbo.EMPLOYEES.EmployeeNum
group by dbo.EMP_EVENT.EventNum, dbo.EMPLOYEES.EmployeeName
having dbo.EMP_EVENT.EventNum=@EventNum

--ôøåöãåøä áùáéì äöâú øùéîú àéøåòéí áàåúä ÷èâåøéä
DROP PROCEDURE  dbo.SP_ShowEvents_ByCategory
CREATE PROCEDURE dbo.SP_ShowEvents_ByCategory
@Category varchar(20)
AS
select dbo.EVENTS.Category, dbo.EVENTS.EventNum,dbo.EVENTS.EventDate, dbo.EVENTS.Description
from dbo.EVENTS
where dbo.EVENTS.Category= @Category


-- inventory order and sticker paper
DROP TABLE dbo.INVENTORYORDERSTICKERPAPER  
CREATE TABLE dbo.INVENTORYORDERSTICKERPAPER (
		OrderNumber int REFERENCES dbo.INVENTORYORDERS(OrderNumber) NOT NULL,
		ProductNumber int REFERENCES dbo.STICKERPAPERS(ProductNumber) NOT NULL,
		Quantity int NOT NULL,
		
		CONSTRAINT PK_IOStickPap PRIMARY KEY(OrderNumber, ProductNumber)

		)



DROP PROCEDURE dbo.SP_add_INVENTORYORDERSTICKERPAPER
CREATE PROCEDURE dbo.SP_add_INVENTORYORDERSTICKERPAPER
@OrderNumber integer, @ProductNumber int, @Quantity int
AS
INSERT INTO dbo.INVENTORYORDERSTICKERPAPER  
Values (@OrderNumber,@ProductNumber,@Quantity)



--supplier and sticker paper
DROP TABLE dbo.StickerSupp
CREATE TABLE dbo.StickerSupp(
		SupNumber int REFERENCES dbo.SUPPLIERS(SupNumber) NOT NULL,
		ProductNumber int REFERENCES dbo.STICKERPAPERS(ProductNumber) NOT NULL,
		
		CONSTRAINT PK_StickSupp PRIMARY KEY(SupNumber, ProductNumber)
	)

DROP PROCEDURE  dbo.Get_all_StickerSupps
CREATE PROCEDURE dbo.Get_all_StickerSupps
AS
Select * from dbo.StickerSupp


DROP PROCEDURE dbo.SP_add_StickerSupp
CREATE PROCEDURE dbo.SP_add_StickerSupp
@SupNumber integer, @ProductNumber integer
AS
INSERT INTO dbo.StickerSupp
Values (@SupNumber,@ProductNumber)



DROP PROCEDURE dbo.SP_DELETE_StickerSupp
CREATE PROCEDURE dbo.SP_DELETE_StickerSupp
@SupNumber integer, @ProductNumber integer
AS
DELETE FROM dbo.StickerSupp
WHERE SupNumber=@SupNumber AND ProductNumber=@ProductNumber


--מראה את המוצרים שספק מספק לפי מספר ספק
DROP PROCEDURE dbo.SP_Show_Products
CREATE PROCEDURE dbo.SP_Show_Products
@SupNumber int
AS
select dbo.STICKERPAPERS.ProductNumber, dbo.STICKERPAPERS.ProductName

from dbo.StickerSupp
join dbo.STICKERPAPERS
on dbo.StickerSupp.ProductNumber = dbo.STICKERPAPERS.ProductNumber
where dbo.StickerSupp.SupNumber = @SupNumber


execute dbo.SP_Show_Products @SupNumber=5;


--  ôøåöãåøä äîöéâä àú ëì äñô÷éí äîñô÷éí ðééø îñåéí ìôé îñôø îåöø
DROP PROCEDURE dbo.SP_Show_Suppliers
CREATE PROCEDURE dbo.SP_Show_Suppliers
@ProductNumber int
AS
select SUPPLIERS.SupNumber, SUPPLIERS.Contact
from dbo.StickerSupp
join dbo.SUPPLIERS
on dbo.StickerSupp.SupNumber = dbo.SUPPLIERS.SupNumber
where dbo.StickerSupp.ProductNumber=@ProductNumber



DROP VIEW newSuppliers as
select * from dbo.SUPPLIERS


DROP TABLE dbo.PaperInOrder
CREATE TABLE dbo.PaperInOrder(
		OrderNumber int PRIMARY KEY NOT NULL,
		ProductNumber int NOT NULL
	)

DROP PROCEDURE dbo.SP_add_PaperOrder
CREATE PROCEDURE dbo.SP_add_PaperOrder
@OrderNumber integer, @ProductNumber int
AS
INSERT INTO dbo.PaperInOrder
Values (@OrderNumber,@ProductNumber)

DROP PROCEDURE  dbo.SP_Update_PaperOrder
CREATE PROCEDURE dbo.SP_Update_PaperOrder
@OrderNumber integer,@ProductNumber int
AS
Update dbo.PaperInOrder
SET
OrderNumber=@OrderNumber, ProductNumber=@ProductNumber
WHERE OrderNumber=@OrderNumber


DROP PROCEDURE  dbo.Get_PaperOrder
Create Procedure dbo.Get_PaperOrder @OrderNumber integer
AS
Select dbo.stickerpapers.ProductName
from dbo.PaperInOrder join dbo.STICKERPAPERS 
on dbo.PaperInOrder.productNumber=dbo.STICKERPAPERS.ProductNumber
WHERE OrderNumber=@OrderNumber


DROP PROCEDURE  dbo.SP_ShowAllOrder_ByDates
CREATE PROCEDURE  dbo.SP_ShowAllOrder_ByDates
@FromDate datetime, @UntilDate datetime
AS
select *
from dbo.ORDERS
where dbo.ORDERS.DueDate between @FromDate and @UntilDate

--EXECUTE dbo.SP_ShowAllOrder_ByDates @FromDate= '2000-01-01 00:00:00', @UntilDate='2023-12-31 00:00:00'

DROP PROCEDURE  dbo.SP_ShowAEventPerEmp
CREATE PROCEDURE  dbo.SP_ShowAEventPerEmp
@EmployeeNum int
AS
select *
from dbo.EMP_EVENT join dbo.EVENTS on EMP_EVENT.EventNum=EVENTS.EventNum
where dbo.EMP_EVENT.EmployeeNum=@EmployeeNum

EXECUTE dbo.SP_ShowAEventPerEmp @EmployeeNum=1421