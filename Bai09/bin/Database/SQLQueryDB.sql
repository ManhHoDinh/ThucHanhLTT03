create table Students
(
	MSSV varchar(10) not null primary key,
	Name varchar(50) not null,
	Major varchar(250) not null,
	Gender varchar(10),
)
create table Subjects(
	MaMH varchar(10) not null primary key,
	Name varchar(50) not null,
)

create table StudentRecords(
	MSSV varchar(10) not null,
	MaMH varchar(10) not null
	primary key (MSSV,MaMH)
	constraint FK_SubjectRecords_Students foreign key (MSSV) references Students(MSSV),
	constraint FK_SubjectRecords_Subjects foreign key (MaMH) references Subjects(MaMH)
)

--Fix database :
alter table Students alter column gender varchar(10) not null 
ALTER DATABASE Students COLLATE Vietnamese_CI_AS
 

--
insert into Subjects values('MH01','Cơ sở dữ liệu')
insert into Subjects values('MH02','Lập trình hướng đối tượng')
insert into Subjects values('MH03','Nhập môn lập trình')
insert into Subjects values('MH04','Lập trình trực quan')
insert into Subjects values('MH05','Hệ điều hành')
insert into Subjects values('MH06','Nhập môn mạng máy tính')

insert into Students values('St1','Hồ Đình Mạnh','Kỹ Thuật Phần Mềm', 'Nam')

insert into Students values('St2','Nguyễn Văn A','Kỹ Thuật Máy Tính', 'Nam')


insert into StudentRecords values('St1','MH01')
insert into StudentRecords values('St1','MH02')
insert into StudentRecords values('St1','MH03')

insert into StudentRecords values('St2','MH02')
insert into StudentRecords values('St2','MH03')
insert into StudentRecords values('St2','MH04')
insert into StudentRecords values('St2','MH06')

--Hien thi students
select *
from Students
--Hiển thị Students and count subject
select s.MSSV, Name, Major, Gender,count(MaMH) SubjectCount
from Students s, StudentRecords sr
where s.MSSV = sr.MSSV
group by s.MSSV, Name, Major, Gender

