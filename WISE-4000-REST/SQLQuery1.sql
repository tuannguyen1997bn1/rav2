Create database ManagerCNC
go 

use ManagerCNC
go

create table CaLamViec
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(100),
	TimeStart time,
	TimeEnd time
)
go

create table ChucVu
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(100)
)
go

create table HienTrangMayCNC
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(100)
)
go

create table HienTrangCuaMayCNC
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(100)
)
go

create table BaoTriCuaMayCNC
(
	Id int identity(1,1) primary key,	
	DisplayName nvarchar(100),
	FromTime Datetime,
	EndTime datetime		
)
go

create table NhanVien
(
	Id int identity(1,1) primary key,
	FullName nvarchar(100),
	IdCaLamViec int not null,
	IdChucVu int not null,
	Password nvarchar(max)

	foreign key(IdCaLamViec) references CaLamViec(Id),
	foreign key(IdChucVu) references ChucVu(Id)
)
go

create table MachinesCNC
(
	Id int identity(1,1) primary key,
	Model nvarchar(100),
	IdHienTrangMayCNC int not null,
	IdHienTrangCuaMayCNC int not null,
	IdBaoTriCuaMay int not null	

	foreign key(IdHienTrangMayCNC) references HienTrangMayCNC(Id),
	foreign key(IdHienTrangCuaMayCNC) references HienTrangCuaMayCNC(Id),
	foreign key(IdBaoTriCuaMay) references BaoTriCuaMayCNC(Id)
)
go