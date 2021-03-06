CREATE DATABASE NWRC_HairBeauty

GO



use NWRC_HairBeauty

GO



---------------------------------------------------- Delete Any Current Tables ------------------------------------------------------------

IF OBJECT_ID ('Payment') IS NOT NULL

	DROP table Payment

GO



IF OBJECT_ID ('Booking') IS NOT NULL

	DROP table Booking

GO





IF OBJECT_ID ('Treatments') IS NOT NULL

	DROP table Treatments

GO



IF OBJECT_ID ('Stock') IS NOT NULL

	DROP table Stock

GO



IF OBJECT_ID ('Client') IS NOT NULL

	DROP table Client

GO



IF OBJECT_ID ('UserLogin') IS NOT NULL

	DROP table UserLogin

GO



IF OBJECT_ID ('Sale') IS NOT NULL

	DROP table UserLogin

GO



IF OBJECT_ID ('SaleDetails') IS NOT NULL

	DROP table UserLogin

GO



IF OBJECT_ID ('BookingDetails') IS NOT NULL

	DROP table UserLogin

GO

---------------------------------------------------- Create Tables --------------------------------------------------------------------

CREATE TABLE UserLogin

(

	UserID				int					NOT NULL,

	Username			varchar(20)			NOT NULL,

	UserForename		varchar(20)			NOT NULL,

	UserSurname			varchar(20)			NOT NULL,

	UserEmail			varchar(40)			NOT NULL,

	UserLevel			varchar(10)			NOT NULL,

	Passkey				varchar(50)			NOT NULL,

	Super				varchar(3)			NOT NULL,



	CONSTRAINT pkUserID PRIMARY KEY (UserID),

	CONSTRAINT unqUserID unique (UserID),

	CONSTRAINT unqUsername unique (Username),

	CONSTRAINT chkPasskey CHECK (Passkey LIKE '%[A-Z]%' AND Passkey LIKE '%[0-9]%'),

	CONSTRAINT chkSuper CHECK (Super IN ('Yes','No','Y','N'))

)



CREATE TABLE Client

(

	ClientNo		int					NOT NULL IDENTITY,

	Title			varchar(4)			NOT NULL,

	Surname			varchar(20)			NOT NULL,

	Forename		varchar(20)			NOT NULL,

	Street			varchar(30)			NOT NULL,

	Town			varchar(30)			NOT NULL,

	County			varchar(30)			NOT NULL,

	PostCode		varchar(8)			NOT NULL,

	Country			varchar(30)			NOT NULL,

	--DOB				date				NOT NULL,

	TelNo			varchar(11)			NOT NULL,

	Email			varchar(30)					,

	SkinTest		varchar(3)			NOT NULL,

	--SkinTestDate	date				NOT NULL,



	CONSTRAINT ClientNo PRIMARY KEY (ClientNo),

	CONSTRAINT unqClientNo unique (ClientNo),

	CONSTRAINT chkTitle CHECK (Title IN ('Mr','Mrs','Miss','Ms','Dr')),

	CONSTRAINT chkPostcode CHECK (Postcode LIKE '[A-Z][A-Z][0-9][0-9] [0-9][A-Z][A-Z]'),

	--CONSTRAINT chkDOB CHECK (DOB >= dateAdd(Year, -17, getDate())and DOB < getDate()),

	CONSTRAINT chkTelNo CHECK (TelNo LIKE REPLICATE('[0-9]', 11)),

	CONSTRAINT chkEmail CHECK (Email LIKE '%_@__%.__%'),

	CONSTRAINT chkSkinTest CHECK (SkinTest IN ('Yes','No','Y','N'))

)



CREATE TABLE Stock 

(

	StockNo			int				NOT NULL IDENTITY(800, 1),

	StockName		varchar(30)		NOT NULL,

	StockSpecs		varchar(30)		NOT NULL,

	StockSize		int				NOT NULL,

	StockQty		int				NOT NULL,

	StockCost		money			NOT NULL,

	StockType		varchar(30)		NOT NULL,

	StockPrice		money			NOT NULL,

	TotalCost		money			NOT NULL,

	QtySold			int				NOT NULL,

	UseageType		varchar(15)		NOT NULL,



	CONSTRAINT pkStockNo PRIMARY KEY (StockNo),

	CONSTRAINT unqStockNo  unique (StockNo )

)



CREATE TABLE Treatments 

(

	TreatmentNo		int				NOT NULL,

	TreatGroup		varchar(20)		NOT NULL,

	TreatName		varchar(50)		NOT NULL,

	TreatType		varchar(50)		NOT NULL,

	Price			money			NOT NULL,



	CONSTRAINT pkTreatmentNo PRIMARY KEY (TreatmentNo),

	CONSTRAINT unqTreatmentNo UNIQUE (TreatmentNo)

)



CREATE TABLE Booking 

(

	BookingNo		int					NOT NULL,

	DateofApp		date				NOT NULL,

	BookingTotal	money				NOT NULL,

	Salon			varchar(10)			NOT NULL,

	SalonNo			varchar(10)			NOT NULL,

	TreatmentNo		varchar(30)			NOT NULL,

	Check1			BIT					null DEFAULT 0,

	Check2			BIT					null DEFAULT 0,

	Check3			BIT					null DEFAULT 0,

	Check4			BIT					null DEFAULT 0,

	Check5			BIT					null DEFAULT 0,

	Check6			BIT					null DEFAULT 0,

	Check7			BIT					null DEFAULT 0,

	Check8			BIT					null DEFAULT 0,

	Check9			BIT					null DEFAULT 0,

	Check10			BIT					null DEFAULT 0,

	Check11			BIT					null DEFAULT 0,

	Check12			BIT					null DEFAULT 0,

	Check13			BIT					null DEFAULT 0,

	Check14			BIT					null DEFAULT 0,

	Check15			BIT					null DEFAULT 0,

	Check16			BIT					null DEFAULT 0,

	Check17			BIT					null DEFAULT 0,

	Check18			BIT					null DEFAULT 0,

	Check19			BIT					null DEFAULT 0,

	Check20			BIT					null DEFAULT 0,

	LocX			int					NOT NULL,

	LocY			int					NOT NULL,

	UserID			int					NOT NULL,

	ClientNo		int					NOT NULL,



	CONSTRAINT pkBookingNo PRIMARY KEY (BookingNo),



	CONSTRAINT fkClientNo	FOREIGN KEY (ClientNo) REFERENCES Client(ClientNo),

	CONSTRAINT fkUserID	FOREIGN KEY (UserID) REFERENCES UserLogin(UserID),



)



CREATE TABLE BookingDetails 

(

	NoBlocks		int					NOT NULL,

	BookingNo		int					NOT NULL,

	TreatmentNo		int					NOT NULL,



	CONSTRAINT pkBookingDet PRIMARY KEY (BookingNo, TreatmentNo),

	CONSTRAINT chkNoDays CHECK (NoBlocks > 0),

	

	CONSTRAINT fkBookingNo	FOREIGN KEY (BookingNo) REFERENCES Booking(BookingNo),

	CONSTRAINT fkTreatmentNo	FOREIGN KEY (TreatmentNo) REFERENCES Treatments(TreatmentNo)

)



CREATE TABLE Sale 

(

	SaleNo			int					NOT NULL,

	DateofSale		datetime			NOT NULL,

	SaleTotal		money				NOT NULL,

	

	UserID			int					NOT NULL,

	ClientNo		int					NOT NULL,



	CONSTRAINT pkSaleNo PRIMARY KEY (SaleNo),

	CONSTRAINT chkDateofSale CHECK (DateofSale >= GetDate()),

	

	CONSTRAINT fkClientNo2	FOREIGN KEY (ClientNo) REFERENCES Client(ClientNo),

	CONSTRAINT fkUserID2	FOREIGN KEY (UserID) REFERENCES UserLogin(UserID),



)



CREATE TABLE SaleDetails 

(

	Quantity		int					NOT NULL,



	SaleNo			int					NOT NULL,

	StockNo			int					NOT NULL,



	CONSTRAINT pkSaleDet PRIMARY KEY (SaleNo, StockNo),

	CONSTRAINT chkQuantity CHECK (Quantity > 0),

	

	CONSTRAINT fkSaleNo	FOREIGN KEY (SaleNo) REFERENCES Sale(SaleNo),

	CONSTRAINT fkStockNo	FOREIGN KEY (StockNo) REFERENCES Stock(StockNo)

)



---------------------------------------------------- END OF TABLE SETUP --------------------------------------------------------------



 -------populating User table initial Setup



INSERT INTO UserLogin (UserID, Username, UserForename, UserSurname, UserEmail, UserLevel, Passkey,Super) VALUES 

(1001, 'SCassidy','Susan','Cassidy', 'susan.cassidy@nwrc.ac.uk','Full','Testing123','Y'),   

(1002, 'BJohnston','Breige', 'Johnston', 'breidge.johnston@nwrc.ac.uk','Full','Testing123','Y'),

(1003, 'Hair','Hair', 'Department', 'breidge.johnston@nwrc.ac.uk','Limited','Testing123','N'),   

(1004, 'Beauty','Breige', 'Johnston', 'susan.cassidy@nwrc.ac.uk','Limited','Testing123','N')



SELECT * FROM UserLogin



/*SET IDENTITY_INSERT Client ON

go

 INSERT INTO Client (ClientNo, Title, Surname, Forename, Street, Town, County, PostCode, TelNo, Country, DOB, Email, SkinTest, SkinTestDate) VALUES 

(10000, 'Mr', 'Morrison', 'Brenden', '159 Main Street','Eglinton','Co Derry','BT47 4TB','02871261548','United Kingdom','19800202','test@test.com','YES','20190102'),   

(10001, 'Miss', 'Rankin', 'Kathy', '56 Greenhaven','Drumahoe','Co Derry','BT48 3SY', '02871346562','United Kingdom','19850121','test1@test.com','YES','20190102'),  

(10002, 'Mr', 'Carlin', 'Patrick', '98 Larch Road','Greysteel','Co Derry','BT47 4TB', '02871249876','United Kingdom','1990521','test2@test.com','YES','20190102'), 

(10003, 'Mr', 'Cunning', 'Tom', '115 NewLine Road','Newbuildings','Co Derry','BT47 4TB', '02871375921','United Kingdom','19800202','test3@test.com','YES','20190102'), 

(10004, 'Mr', 'Wilson', 'Robert', '45 Hollyfoot Hill','Ballykelly','Co Derry','BT47 4TB', '07561020748','United Kingdom','19850121','test4@test.com','YES','20190102'), 

(10005, 'Mr', 'Lynch', 'Conan', '126 Dungiven Road','Derry','Co Derry','BT47 4TB', '02871361782','United Kingdom','19800202','test5@test.com','YES','20190102'),

(10006, 'Mrs', 'Collins', 'Joanne', '62 Limavady Road','Derry','Co Derry','BT47 4TB', '02871267183','United Kingdom','19850121','test6@test.com','YES','20190102'),

(10007, 'Mr', 'Gallagher', 'Adam', '76 Church Brae','Derry','Co Derry','BT47 4TB', '02871348527','United Kingdom','19800202','test7@test.com','YES','20190102'),

(10008, 'Mrs', 'Costello', 'Niamh', '34 Strand Road','Derry','Co Derry','BT47 4TB', '07865255486','United Kingdom','19850121','test8@test.com','YES','20190102'), 

(10009, 'Mr', 'Doherty', 'Kevin', '624 Glenshane Road','Claudy','Co Derry','BT47 4TB', '07759631458','United Kingdom','19800202','test9@test.com','YES','20190102'),

(10010, 'Miss', 'Heaney', 'Amanda', '22 Dungiven Road','Limavady','Co Derry','BT47 4TB', '07566584748','United Kingdom','1990521','test10@test.com','YES','20190102'), 

(10011, 'Mr', 'Evans', 'Rory', '70 Rosewood Avenue','Derry','Co Derry','BT47 4TB', '02871346582','United Kingdom','19850121','test11@test.com','YES','20190102'),

(10012, 'Mr', 'Coyle', 'Stephen', '32 Culmore Road','Derry','Co Derry','BT47 4TB', '07756914238','United Kingdom','1990521','test12@test.com','YES','20190102'), 

(10013, 'Mr', 'Murray', 'Mark', '4b Enfield Street','Derry','Co Derry','BT47 4TB', '07925688149','United Kingdom','19850121','test13@test.com','YES','20190102'), 

(10014, 'Mr', 'Donaghy', 'Martin', '582 Duncrun Road','Limavady','Co Derry','BT47 4TB', '02877741596','United Kingdom','19850121','test14@test.com','YES','20190102'), 

(10015, 'Miss', 'Jenkins', 'Hannah', '94 Carrickbeg Avenue','Eglinton','Co Derry','BT47 4TB', '02871362894','United Kingdom','19850121','test15@test.com','YES','20190102'), 

(10016, 'Mrs', 'Matthews', 'Louise', '241 Clagan Road','Claudy','Co Derry','BT47 4TB', '07774698315','United Kingdom','1990521','test16@test.com','YES','20190102'), 

(10017, 'Miss', 'Cartin', 'Charlene', '200 Rallagh Road','Dungiven','Co Derry','BT47 4TB', '07892579143','United Kingdom','1990521','test17@test.com','YES','20190102'), 

(10018, 'Mr', 'Holmes', 'Kieran', '34 Spencer Road','Waterside','Co Derry','BT47 4TB', '07985020748','United Kingdom','19850121','test18@test.com','YES','20190102') 



SELECT * FROM Client*/ -- Problems entering the date formatting ??? , cant convert errors etc.



SET IDENTITY_INSERT Client ON -- Why do I need To DO this ? 

go

INSERT INTO Client (ClientNo, Title, Surname, Forename, Street, Town, County, PostCode, TelNo, Country, Email, SkinTest) VALUES 

(10000, 'Mr', 'Morrison', 'Brenden', '159 Main Street','Eglinton','Co Derry','BT47 4TB','02871261548','United Kingdom','test@test.com','YES'),   

(10001, 'Miss', 'Rankin', 'Kathy', '56 Greenhaven','Drumahoe','Co Derry','BT48 3SY', '02871346562','United Kingdom','test1@test.com','YES'),  

(10002, 'Mr', 'Carlin', 'Patrick', '98 Larch Road','Greysteel','Co Derry','BT47 4TB', '02871249876','United Kingdom','test2@test.com','YES'), 

(10003, 'Mr', 'Cunning', 'Tom', '115 NewLine Road','Newbuildings','Co Derry','BT47 4TB', '02871375921','United Kingdom','test3@test.com','YES'), 

(10004, 'Mr', 'Wilson', 'Robert', '45 Hollyfoot Hill','Ballykelly','Co Derry','BT47 4TB', '07561020748','United Kingdom','test4@test.com','YES'), 

(10005, 'Mr', 'Lynch', 'Conan', '126 Dungiven Road','Derry','Co Derry','BT47 4TB', '02871361782','United Kingdom','test5@test.com','YES'),

(10006, 'Mrs', 'Collins', 'Joanne', '62 Limavady Road','Derry','Co Derry','BT47 4TB', '02871267183','United Kingdom','test6@test.com','YES'),

(10007, 'Mr', 'Gallagher', 'Adam', '76 Church Brae','Derry','Co Derry','BT47 4TB', '02871348527','United Kingdom','test7@test.com','YES'),

(10008, 'Mrs', 'Costello', 'Niamh', '34 Strand Road','Derry','Co Derry','BT47 4TB', '07865255486','United Kingdom','test8@test.com','YES'), 

(10009, 'Mr', 'Doherty', 'Kevin', '624 Glenshane Road','Claudy','Co Derry','BT47 4TB', '07759631458','United Kingdom','test9@test.com','YES'),

(10010, 'Miss', 'Heaney', 'Amanda', '22 Dungiven Road','Limavady','Co Derry','BT47 4TB', '07566584748','United Kingdom','test10@test.com','YES'), 

(10011, 'Mr', 'Evans', 'Rory', '70 Rosewood Avenue','Derry','Co Derry','BT47 4TB', '02871346582','United Kingdom','test11@test.com','YES'),

(10012, 'Mr', 'Coyle', 'Stephen', '32 Culmore Road','Derry','Co Derry','BT47 4TB', '07756914238','United Kingdom','test12@test.com','YES'), 

(10013, 'Mr', 'Murray', 'Mark', '4b Enfield Street','Derry','Co Derry','BT47 4TB', '07925688149','United Kingdom','test13@test.com','YES'), 

(10014, 'Mr', 'Donaghy', 'Martin', '582 Duncrun Road','Limavady','Co Derry','BT47 4TB', '02877741596','United Kingdom','test14@test.com','YES'), 

(10015, 'Miss', 'Jenkins', 'Hannah', '94 Carrickbeg Avenue','Eglinton','Co Derry','BT47 4TB', '02871362894','United Kingdom','test15@test.com','YES'), 

(10016, 'Mrs', 'Matthews', 'Louise', '241 Clagan Road','Claudy','Co Derry','BT47 4TB', '07774698315','United Kingdom','test16@test.com','YES'), 

(10017, 'Miss', 'Cartin', 'Charlene', '200 Rallagh Road','Dungiven','Co Derry','BT47 4TB', '07892579143','United Kingdom','test17@test.com','YES'), 

(10018, 'Mr', 'Holmes', 'Kieran', '34 Spencer Road','Waterside','Co Derry','BT47 4TB', '07985020748','United Kingdom','test18@test.com','YES') 



SELECT * FROM Client



INSERT INTO Stock (StockName, StockSpecs, StockSize, StockQty, StockCost, StockType, StockPrice, TotalCost, QtySold, UseageType) VALUES 

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 121, 'Retail'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 12, 'Retail'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 47, 'Retail'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 16, 'Retail'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 578, 'Retail'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 23, 'Retail'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 121, 'Retail'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 12, 'Retail'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 47, 'Internal'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 16, 'Internal'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 578, 'Retail'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 23, 'Internal'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 121, 'Internal'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 12, 'Retail'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 47, 'Internal'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 16, 'Retail'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 578, 'Retail'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 23, 'Internal'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 121, 'Internal'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 12, 'Internal'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 47, 'Retail'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 16, 'Retail'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 578, 'Retail'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 23, 'Retail'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 121, 'Retail'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 12, 'Retail'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 47, 'Internal'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 16, 'Internal'),

('Test', 'Morrison', 1000, 100, 19.99, 'Hair', 29.99, 1999, 578, 'Retail'),   

('Test', 'Rankin', 1000, 56, 14.99,'Beauty',21.99, 839.44, 23, 'Retail')



select * from stock



INSERT INTO Treatments (TreatmentNo,TreatGroup,TreatName,TreatType,Price) VALUES 

(100,'Hair', 'Wash & Blow Dry/Set','Hairdressing', 5.00),   

(101,'Hair', 'Wash,Cut & Blow Dry/Set','Hairdressing', 10.00),

(102,'Hair', 'Up Style','Hairdressing', 5.00),   

(103,'Hair', 'Conditioning Treatment','Hairdressing',2.00),

(104,'Hair', 'Semi-permanent Colour','Hairdressing',12.00),   

(105,'Hair', 'Quasi Colour','Hairdressing',15.00),

(106,'Hair', 'Permanent Colour','Hairdressing',20.00),   

(107,'Hair', 'Cap/Foil Hi lights / Low lights','Hairdressing',20.00),

(108,'Hair', 'Permanent Colour & Hi/Low lights','Hairdressing',25.00),   

(109,'Hair', 'Color Correction','Hairdressing',25.00),

(110,'Hair', 'Perms','Hairdressing',15.00),   

(111,'Beauty', 'Manicure including massage','Hand and Feet Treats',3.00),

(112,'Beauty', 'Manicure including paraffin','Hand and Feet Treats',4.00),   

(113,'Beauty', 'French manicure.','Hand and Feet Treats',4.00),

(114,'Beauty', 'Pedicure including massage','Hand and Feet Treats',4.00),   

(115,'Beauty', 'Pedicure including paraffin','Hand and Feet Treats',5.00),

(116,'Beauty', 'Eyebrow Shape or Tint','Eye Treatments',2.00),

(117,'Beauty', 'Eyelash Tint','Eye Treatments',3.00),   

(118,'Beauty', 'Lash & Brow Tint','Eye Treatments',4.00),

(119,'Beauty', 'Lash & Brow Tint and Shape','Eye Treatments',5.00),   

(120,'Beauty', 'False Lash Application','Eye Treatments',5.00),

(121,'Beauty', 'Prescriptive Facial','Facial Treatments',5.00),

(122,'Beauty', 'Make-up','Facial Treatments',3.00),   

(123,'Beauty', 'Facial using electro machines','Facial Treatments',10.00),

(124,'Beauty', 'Microdermabrasion or Microcurrent','Facial Treatments',11.00),   

(125,'Beauty', 'Eyebrow Wax','Waxing',3.00),

(126,'Beauty', 'Lip Wax / Chin Wax','Waxing',2.00),

(127,'Beauty', 'Underarm / Bikini Wax','Waxing',4.00),   

(128,'Beauty', '� Leg Wax','Waxing',5.00),

(129,'Beauty', '� Leg Wax','Waxing',7.00),   

(130,'Beauty', 'Full Leg Wax','Waxing',8.00),

(131,'Beauty', 'Full Leg & Bikini Wax','Waxing',11.00),

(132,'Beauty', 'Full Body Massage','Body Treatments',8.00),   

(133,'Beauty', 'Full Body including Head','Body Treatments',10.00),

(134,'Beauty', 'Neck/back/shoulders','Body Treatments',6.00),   

(135,'Beauty', 'Indian Head Massage','Body Treatments',5.00),

(136,'Beauty', 'Massage with Aroma Oils','Body Treatments',10.00),

(137,'Beauty', 'Massage with Aroma Oils including Head','Body Treatments',11.00),   

(138,'Beauty', 'Stone Therapy Massage','Body Treatments',10.00),

(139,'Beauty', 'Tan Application(spray/manual) full body','Body Treatments',10.00),   

(140,'Beauty', 'Tan Application(spray/manual) half body','Body Treatments',5.00)



select * from Treatments