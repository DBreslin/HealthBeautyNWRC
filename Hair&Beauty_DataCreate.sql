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

IF OBJECT_ID ('FacialElectro') IS NOT NULL
	DROP table FacialElectro
GO

IF OBJECT_ID ('Medical') IS NOT NULL
	DROP table Medical
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


---------------------------------------------------- Create Tables --------------------------------------------------------------------
CREATE TABLE UserLogin
(
	UserID				int					NOT NULL,
	UserName			varchar(20)			NOT NULL,
	UserRole			varchar(10)			NOT NULL,
	StaffLevel			varchar(10)			NOT NULL,
	Passkey				varchar(50)			NOT NULL,
	Super				varchar(3)			NOT NULL,

	CONSTRAINT pkUserID PRIMARY KEY (UserID),
	CONSTRAINT unqUserID unique (UserID),
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
	DOB				date				NOT NULL,
	TelNo			varchar(11)			NOT NULL,
	Email			varchar(30)					,
	
	UserID				int				NOT NULL,

	CONSTRAINT ClientNo PRIMARY KEY (ClientNo),

	CONSTRAINT unqClientNo unique (ClientNo),
	CONSTRAINT chkTitle CHECK (Title IN ('Mr','Mrs','Miss','Ms','Dr')),
	CONSTRAINT chkPostcode CHECK (Postcode LIKE '[A-Z][A-Z][0-9][0-9] [0-9][A-Z][A-Z]'),
	CONSTRAINT chkDOB CHECK (DOB >= dateAdd(Year, -17, getDate())and DOB < getDate()),
	CONSTRAINT chkTelNo CHECK (TelNo LIKE REPLICATE('[0-9]', 11)),
	CONSTRAINT chkEmail CHECK (Email LIKE '%_@__%.__%'),
	CONSTRAINT fkUserID	FOREIGN KEY (UserID) REFERENCES UserLogin(UserID)
)

CREATE TABLE Stock 
(
	StockNo			int				NOT NULL,
	StockName		varchar(30)		NOT NULL,
	Size			int				NOT NULL,
	Specifications	varchar(30)		NOT NULL,
	Qty				int				NOT NULL,
	PriceExtVat		money			NOT NULL,
	StockType		varchar(30)		NOT NULL,
	TotalExtVat		money			NOT NULL,

	CONSTRAINT pkStockNo PRIMARY KEY (StockNo)
	
)

CREATE TABLE Treatments 
(
	TreatmentNo		int				NOT NULL,
	TreatGroup		varchar(20)		NOT NULL,
	TreatName		varchar(20)		NOT NULL,
	Price			money			NOT NULL,
	Paid			char			NOT NULL,

	ClientNo		int				NOT NULL IDENTITY,
	StockNo			int				NOT NULL,

	CONSTRAINT pkTreatmentNo PRIMARY KEY (TreatmentNo),
	CONSTRAINT unqTreatmentNo UNIQUE (TreatmentNo),
	CONSTRAINT chkPaid CHECK (Paid IN ('Y','N')),
	CONSTRAINT fkClientNo	FOREIGN KEY (ClientNo) REFERENCES Client(ClientNo),
	CONSTRAINT fkStockNo	FOREIGN KEY (StockNo) REFERENCES Stock(StockNo)
)

CREATE TABLE Medical 
(
	ConditionNo		int				NOT NULL,
	ConditionName	varchar(20)		NOT NULL,
	LastCheck		date					,
	
	ClientNo		int				NOT NULL IDENTITY,
	
	CONSTRAINT pkConditionNo PRIMARY KEY (ConditionNo),
	CONSTRAINT unqConditionNo UNIQUE (ConditionNo),
	CONSTRAINT fkClientNo2	FOREIGN KEY (ClientNo) REFERENCES Client(ClientNo)
)

CREATE TABLE FacialElectro 
(
	ContraNo			int				NOT NULL,
	ContraIndPrevent	varchar(30)		NOT NULL,
	ContraIndRestrict	varchar(30)		NOT NULL,
	SkinType			varchar(10)		NOT NULL,
	SkinCond			varchar(10)		NOT NULL,
	SkinAnalysis		varchar(20)		NOT NULL,
	SkinConds			varchar(10)		NOT NULL,
	Equipment			varchar(30)		NOT NULL,
	FacialProducts		varchar(20)		NOT NULL,
	EffectBenefits		varchar(20)		NOT NULL,

	ClientNo		int				NOT NULL,
	UserID			int				NOT NULL,

	CONSTRAINT pkContraNo PRIMARY KEY (ContraNo),
	CONSTRAINT unqContraNo UNIQUE (ContraNo),
	CONSTRAINT fkClientNo3	FOREIGN KEY (ClientNo) REFERENCES Client(ClientNo),
	CONSTRAINT fkUserID2	FOREIGN KEY (UserID) REFERENCES UserLogin(UserID)
)

CREATE TABLE Booking 
(
	BookingNo		int					NOT NULL,
	ClientNo		int					NOT NULL,
	DateofApp		datetime			NOT NULL,
	NoBlocks		int					NOT NULL,
	MedicalCheck	char				NOT NULL,
	UserID			int					NOT NULL,
	TreatmentNo		int				NOT NULL,

	CONSTRAINT pkBookingNo PRIMARY KEY (BookingNo),
	CONSTRAINT chkMedicalCheck CHECK (MedicalCheck IN ('Y','N')),
	CONSTRAINT chkNoDays CHECK (NoBlocks > 0),
	CONSTRAINT fkClientNo4	FOREIGN KEY (ClientNo) REFERENCES Client(ClientNo),
	CONSTRAINT chkDateofApp CHECK (DateofApp >= GetDate()),
	CONSTRAINT fkUserID3	FOREIGN KEY (UserID) REFERENCES UserLogin(UserID),
	CONSTRAINT fkTreatmentNo	FOREIGN KEY (TreatmentNo) REFERENCES Treatments(TreatmentNo)
)

CREATE TABLE Payment 
(
	PaymentNo		int				NOT NULL,
	BookingNo		int				NOT NULL,
	TreatmentNo		int				NOT NULL,
	Amount			money			NOT NULL,
	DatePaid		date			NOT NULL,
	
	
	CONSTRAINT pkPaymentNo PRIMARY KEY (PaymentNo),
	CONSTRAINT fkBookingNo FOREIGN KEY (BookingNo) REFERENCES Booking (BookingNo),
	CONSTRAINT fkTreatmentNo2	FOREIGN KEY (TreatmentNo) REFERENCES Treatments(TreatmentNo),
	CONSTRAINT chkAmount CHECK (Amount > 0),
	CONSTRAINT chkDatePaid CHECK (DatePaid >= GetDate())
)

---------------------------------------------------- END OF TABLE SETUP --------------------------------------------------------------

 -------populating User table initial Setup

INSERT INTO UserLogin (UserID, UserName, UserRole, StaffLevel, Passkey, Super) VALUES 
(1, 'Susan', 'Lecturer', 'Full','Testing123','Y'),   
(2, 'Breige', 'Lecturer', 'Full','Testing123','Y')

SELECT * FROM UserLogin

 