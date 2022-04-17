CREATE DATABASE QuanLyChungCuMini;
GO
USE	QuanLyChungCuMini;

CREATE TABLE Room(
	RoomId INT PRIMARY KEY NOT NULL,
	Cost FLOAT NOT NULL,
	RoomFloor INT NOT NULL,
	RoomArea FLOAT NOT NULL,
	RoomStatusTitle NVARCHAR(50) NOT NULL,
	RoomStatus INT NOT NULL,
);

CREATE TABLE Tenant(
	TenantIdCard VARCHAR(255) PRIMARY KEY,
	TenantEmail VARCHAR(255),
	TenantPhoneNumber VARCHAR(255),
	CreditNumber VARCHAR(255),
	Bank NVARCHAR(255)
);

CREATE TABLE Dweller(
	DwellerId INT IDENTITY(1,1) PRIMARY KEY,
	DwellerName NVARCHAR(255) NOT NULL,
	DwellerGender NVARCHAR(30) NOT NULL,
	DwellerBirthday DATE NOT NULL,
	DwellerIdCard VARCHAR(255) NOT NULL UNIQUE,
	TenantIdCard VARCHAR(255) FOREIGN KEY REFERENCES Tenant(TenantIdCard) NOT NULL,
	DwellerStatusTitle NVARCHAR(255) NOT NULL,
	DwellerStatus INT NOT NULL
);

CREATE TABLE Contract(
	ContractId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	RoomId INT FOREIGN KEY REFERENCES Room(RoomId) NOT NULL,
	TenantIdCard VARCHAR(255) FOREIGN KEY REFERENCES Tenant(TenantIdCard) NOT NULL,
	DateStart DATE NOT NULL,
	DateEnd DATE NOT NULL,
	ContractStatusTitle NVARCHAR(255) NOT NULL,
	ContractStatus INT NOT NULL
);

CREATE TABLE Account(
	Username VARCHAR(255),
	Password VARCHAR(255),
	AccountName NVARCHAR(255),
	Position NVARCHAR(255)
);

CREATE TABLE Rent(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	RentId NVARCHAR(20) UNIQUE NOT NULL, 
	ContractId INT FOREIGN KEY REFERENCES Contract(ContractId) NOT NULL,
	Month INT NOT NULL,
	Payday DATE NOT NULL,
	SettlementDay DATE,	
	RentStatusTitle NVARCHAR(50) NOT NULL,
	RentStatus INT NOT NULL
);

INSERT INTO Room(RoomId, Cost, RoomFloor, RoomArea, RoomStatusTitle, RoomStatus) VALUES
('101', '6500000', '1', '50', N'Phòng trống', '0'),
('102', '6500000', '1', '50', N'Phòng trống', '0'),
('103', '6500000', '1', '50', N'Phòng có người thuê', '3'),
('201', '5200000', '2', '50', N'Phòng trống', '0'),
('202', '5200000', '2', '50', N'Phòng trống', '0'),
('203', '5200000', '2', '50', N'Phòng có người thuê', '3'),
('301', '5000000', '3', '50', N'Phòng trống', '0'),
('302', '5000000', '3', '50', N'Phòng trống', '0'),
('303', '5000000', '3', '50', N'Phòng trống', '0'),
('401', '4800000', '4', '50', N'Phòng có người thuê', '3'),
('402', '4800000', '4', '50', N'Phòng trống', '0'),
('403', '4800000', '4', '50', N'Phòng trống', '0'),
('501', '4500000', '5', '50', N'Phòng trống', '0'),
('502', '4500000', '5', '50', N'Phòng trống', '0'),
('503', '4500000', '5', '50', N'Phòng trống', '0');

INSERT INTO Tenant(TenantIdCard, TenantEmail, TenantPhoneNumber, CreditNumber, Bank) VALUES
('001245368425', 'nguyenvanlong@gmail.com', '0344521489', '21410002778000', 'BIDV'),
('001293658413', 'yeuemmaimai@gmail.com', '0978180386', '21411477077153', 'BIDV'),
('001305368476', 'tranvanphuong@gmail.com', '0489302587', '58130214563690', 'Agribank');

INSERT INTO Dweller(DwellerName, DwellerGender, DwellerBirthday, DwellerIdCard, DwellerStatusTitle, TenantIdCard, DwellerStatus) VALUES
(N'Nguyễn Văn Long', N'Nam', '2001-08-06', '001245368425', N'Đang ở', '001245368425', '1'),
(N'Nguyễn Nam Dương', N'Nam', '1996-11-02', '001244578523', N'Đang ở', '001245368425', '1'),
(N'Trần Thị Chi', N'Nữ', '2003-08-11', '001034635291', N'Đang ở', '001245368425', '1'),
(N'Nguyễn Văn Dũng', N'Nam', '2006-07-03', '001202113544', N'Đang ở', '001245368425', '1'),
(N'Nguyễn Thị Em', N'Nữ', '1994-04-04', '001245875425', N'Đang ở', '001245368425', '1'),
(N'Nguyễn Thị Oanh', N'Nữ', '2001-04-08', '001293658413', N'Đang ở', '001293658413', '1'),
(N'Đỗ Hồng Vân', N'Nữ', '2001-10-20', '001136547893', N'Đang ở', '001293658413', '1'),
(N'Đỗ Tiến Dũng', N'Nam', '2001-06-08', '001203060020', N'Đang ở', '001293658413', '1'),
(N'Trần Vân Phượng', N'Nam', '1990-10-10', '001305368476', N'Đang ở', '001305368476', '1');

INSERT INTO Account(Username, Password, AccountName, Position) VALUES
('admin', 'admin', 'Administrator', 'admin'),
('nv1', 'nv1', N'Nhân viên 1', 'employee'),
('nv2', 'nv2', N'Nhân viên 2', 'employee'),
('nv3', 'nv3', N'Nhân viên 3', 'employee');

INSERT INTO Contract(RoomId, TenantIdCard, DateStart, DateEnd, ContractStatusTitle, ContractStatus) VALUES
('103', '001245368425', '2022-01-19', '2022-06-19', N'Đang hiệu lực', '2'),
('203', '001293658413', '2022-03-03', '2022-09-03', N'Đang hiệu lực', '2'),
('401', '001305368476', '2022-04-18', '2022-07-18', N'Đang hiệu lực', '2');

INSERT INTO Rent(RentId, RentStatusTitle, Month, Payday, SettlementDay, ContractId, RentStatus) VALUES
('022201', N'Đã đóng tiền', '2', '2022-02-01', '2022-02-03', '1', '1'),
('032201', N'Đã đóng tiền', '3', '2022-03-01', '2022-03-01', '1', '1'),
('042201', N'Đã đóng tiền', '4', '2022-04-01', '2022-04-01', '1', '1'),
('042202', N'Đã đóng tiền', '4', '2022-04-01', '2022-04-02', '1', '1');