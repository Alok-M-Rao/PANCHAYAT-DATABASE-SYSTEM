create database PANCHAYAT 
use PANCHAYAT



GRAMA_SABHA(VillageNumber)
CITIZEN (Fname,Mname,Lname,UID,Sex,DOB,Phone,Address,VNumber)
MEMBER (MemberID,MUID,Department,Salary)
SARPANCH (SarpanchID,SUID,Salary)
PANCHAYAT (VillageName,DistrictName,SarID,VNo)
GOVERNMENT (StateName,ChiefMinister,Governor,GID)
SECRETARY (Fname,Mname,Lname,SecretaryID,AUID,Sex,DOB,Qualification,Phone,Salary,VNum,GovID)
MEETING (MID,Info)
ISSUE (IID,IUID,IType,MeetID)
LAW (LawNumber,Description)
WELFARE (WID,WUID,Wname,Amount,Duration)
DEVELOPMENT_PROJECT(PID,ViNum,LeadEngineer,Funding,LandAlloted)
WORKS_ON(WorkID,DPID,PUID)





create table GRAMA_SABHA
(
	VillageNumber int primary key
);


create table CITIZEN
(
	Fname varchar(20) not null,
	Mname char,
	Lname varchar(20),
	UID char(12) primary key,
	Sex char,
	DOB datetime,
	Phone char(10),
	Address varchar(20),
	VNumber int foreign Key(VNumber) references GRAMA_SABHA(VillageNumber) on update cascade on delete cascade
);


create table MEMBER
(
	MemberID char(10) primary key,
	MUID char(12) unique foreign key(MUID) references CITIZEN(UID) on update cascade on delete cascade,
	Department varchar(20),
	Salary float,
);


create table SARPANCH
(	
	SarpanchID char(10) primary key,
	SUID char(12) unique foreign key(SUID) references CITIZEN(UID) on update cascade on delete cascade,
	Salary float,
);


create table PANCHAYAT
(
	VillageName varchar(20),
	District varchar(20),
	SarID char(10) unique foreign key(SarID) references SARPANCH(SarpanchID) on update cascade on delete cascade,
	VNo int unique foreign key(VNo) references GRAMA_SABHA(VillageNumber) 
);



create table GOVERNMENT
(
	StateName varchar(20),
	ChiefMinister varchar(25),
	Governor varchar(25),
	GID int primary key
);


create table SECRETARY
(
	Fname varchar(20) not null,
	Mname char,
	Lname varchar(20),
	SecretaryID char(10) primary key,
	AUID char(12),
	Sex char,
	DOB datetime,
	Qualification varchar(20),
	Phone char(10),
	Salary float,
	VNum int unique foreign key(VNum) references GRAMA_SABHA(VillageNumber) on update cascade on delete cascade,
	GovID int foreign key(GovID) references GOVERNMENT(GID) on update cascade on delete cascade
);


create table MEETING
(
	MID char(10) primary key,
	Info datetime 
);


create table ISSUE
(
	IID varchar(8) primary key,
	IUID char(12) foreign key(IUID) references CITIZEN(UID) on update cascade on delete cascade,
	IType varchar(50),
	MeetID char(10)  foreign key(MeetID) references MEETING(MID) on update cascade on delete cascade
);


create table LAW
(
	LawNumber varchar(5) primary key,
	Description varchar(200)
);


create table WELFARE 
(
	WID	char(10) primary key,
	WUID char(12) foreign key(WUID) references CITIZEN(UID) on update cascade on delete cascade,
	Wname varchar(10),
	Amount float,
	Duration int
);


create table DEVELOPMENT_PROJECT
(
	PID char(10) primary key,
	ViNum int foreign key(ViNum) references GRAMA_SABHA(VillageNumber),
	LeadEngineer varchar(20),
	Funding float,
	LandAlloted float
);

create table WORKS_ON
(
	WorkID char(7) primary key,
	DPID char(10) foreign key(DPID) references DEVELOPMENT_PROJECT(PID) on update cascade on delete cascade,
	PUID char(12) unique foreign key(PUID) references CITIZEN(UID) on update cascade on delete cascade
);



drop table CITIZEN

drop table MEMBER

drop table SARPANCH

drop table PANCHAYAT

drop table GRAMA_SABHA

drop table GOVERNMENT

drop table SECRETARY

drop table MEETING

drop table ISSUE

drop table LAW

drop table WELFARE

drop table DEVELOPMENT_PROJECT

drop table WORKS_ON




--GRAMA_SABHA

insert into GRAMA_SABHA values ('1')
insert into GRAMA_SABHA values ('2')
insert into GRAMA_SABHA values ('3')
insert into GRAMA_SABHA values ('4')

Select *
From GRAMA_SABHA






--CITIZEN

insert into CITIZEN values ('ALOK','M','RAO','378611840185','M','1996-06-15','9538468710','KODIALBAIL,MANGALORE','1')
insert into CITIZEN values ('AKSHAY','A','SAKSENA','378611840187','M','1967-04-13','9633746543','KADRI,MANGALORE','1')
insert into CITIZEN values ('ANANTHU','T','KANIVE','378611840186','M','1967-05-23','8946585748','LALBAGH,MANGALORE','1')
insert into CITIZEN values ('ADARSH','A','SHETTY','378611840188','M','1958-04-05','9675274682','LADYHILL,MANGALORE','1')
insert into CITIZEN values ('ADITYA','P','SINGH','378611840189','M','1954-02-15','8924764625','KUDROLI,MMANGALORE','1')
insert into CITIZEN values ('ARJUN','S','NAYAK','378611840190','M','1968-12-26','5487248932','KOTTARA,MANGALORE','1')
insert into CITIZEN values ('PRAJWAL','B','RAO','378611840191','M','1976-04-29','9626735473','LALBAGH,MANGALORE','1')
insert into CITIZEN values ('HARSHINI','H','SRIVASTA','378611840192','F','1983-01-15','9038467354','PVS,MANGALORE','1')
insert into CITIZEN values ('CRYSTAL','F','LOBO','378611840193','F','1946-06-14','9826453648','JYOTHI,MANGALORE','1')
insert into CITIZEN values ('BHUVANA','P','PRABU','378611840194','F','1979-11-28','9024836645','BEJAI,MANGALORE','1')
insert into CITIZEN values ('PRAFFUL','M','CHOWDARY','378611840195','M','1987-09-23','9294849590','KOTTARI,MANGALORE','1')
insert into CITIZEN values ('ANANT','T','ACHARYA','378611840196','M','1989-12-01','9256435627','KADRI,MANGALORE','1')
insert into CITIZEN values ('DEEKSHA','D','GOANKAR','378611840197','F','1967-04-02','8533484687','KUDROLI,MANGALORE','1')
insert into CITIZEN values ('ASHRITH','V','KUMAR','378611840198','M','1985-04-19','7239876788','BANDARU,MANGALORE','1')
insert into CITIZEN values ('NISHMITHA','P','RAI','378611840199','F','1991-08-11','8926873224','KODIALBAIL,MANGALORE','1')

insert into CITIZEN values ('VIJAY','D','ALVAS','378611840001','M','1997-02-15','9829647536','AJJARKAD,UDUPI','2')
insert into CITIZEN values ('GANGADHAR','V','VILAS','378611840002','M','1956-11-13','9723546758','KATPADI,UDUPI','2')
insert into CITIZEN values ('SAMPURNA','M','AMADALI','378611840003','F','1978-06-13','9982364876','MANIPAL,UDUPI','2')
insert into CITIZEN values ('YATHEESH','M','VINAY','378611840004','M','1967-08-19','9538483984','KALSANKADU,UDUPI','2')
insert into CITIZEN values ('JENSIL','E','DSOUZA','378611840005','M','1967-09-18','8754786298','NITTUR,UDUPI','2')
insert into CITIZEN values ('FIONA','M','SALDANA','378611840006','F','1998-07-12','9845231159','SANTEKATTE,UDUPI','2')
insert into CITIZEN values ('ALAN','M','SALDANA','378611840007','M','1976-05-19','9243080987','ADAKADAKATTE,UDUPI','2')
insert into CITIZEN values ('CAROL','F','DIAS','378611840008','F','1996-11-17','8884919621','AMBHAGILU,UDUPI','2')
insert into CITIZEN values ('BALAKRISHNA','S','VISHNU','378611840009','M','1956-06-25','7259103265','KATPADI,UDUPI','2')
insert into CITIZEN values ('AQUIL','M','AHMED','378611840010','M','1978-11-13','7222016412','BAIDUR,UDUPI','2')
insert into CITIZEN values ('ANNAPURNA','N','PAI','378611840011','F','1967-11-08','7222064122','SULTANPUR,UDUPI','2')
insert into CITIZEN values ('ANUSHA','M','BHAT','378611840012','F','1991-07-03','6742587548','WALSALLI,UDUPI','2')
insert into CITIZEN values ('ADITYA','G','KUMAR','378611840013','M','1992-04-20','7875436259','KUNJUBETTU,UDUPI','2')
insert into CITIZEN values ('AKANKSHA','S','SHETY','378611840014','M','1979-06-10','0238748643','GUNDIBAIL,UDUPI','2')
insert into CITIZEN values ('ABHISHEK','O','KUMAR','378611840015','M','1989-12-15','2235673543','SHIVALLI,UDUPI','2')

insert into CITIZEN values ('AMAN','K','SINHA','378611840016','M','1984-12-10','6735487728','HEBRI,KARKALA','3')
insert into CITIZEN values ('ACHALA','V','BALGI','378611840017','F','1986-03-08','5347642537','AJEKAR,KARKALA','3')
insert into CITIZEN values ('AKSHATHA','S','SANIL','378611840018','F','1983-04-29','9384657834','NITTE,KARKALA','3')
insert into CITIZEN values ('ANUSHRI','M','PRABHU','378611840019','F','1967-08-21','9465745353','ATTUR,KARKALA','3')
insert into CITIZEN values ('ATREYA','G','KRISHNA','378611840020','M','1979-09-10','9436538745','KEMMAN,KARKALA','3')
insert into CITIZEN values ('ASHWIJA','R','PAI','378611840021','F','1985-11-20','9983835473','HALEGETTE,KARKALA','3')
insert into CITIZEN values ('CHAITRA','R','RAO','378611840022','F','1986-12-28','9538468710','KENDINGE,KARKALA','3')
insert into CITIZEN values ('ANUSHREE','S','SHETTY','378611840023','F','1976-06-04','5456735543','BAJKALA,KARKALA','3')
insert into CITIZEN values ('NIKHIL','N','REVANKAR','378611840024','M','1987-02-13','9073647663','BORGALGUDDE,KARKALA','3')
insert into CITIZEN values ('AKSHITHA','P','SANIL','378611840025','F','1969-04-19','9734689569','BAIKALA,KARKALA','3')
insert into CITIZEN values ('KRISHNA','T','KUMAR','378611840026','M','1994-11-01','9374679964','SANNOR,KARKALA','3')

insert into CITIZEN values ('ADITYA','R','KAPOOR','378611840027','M','1954-11-30','9654872827','MALVIYA,JAIPUR','4')
insert into CITIZEN values ('JOHN','M','ABRAHIM','378611840028','M','1969-03-04','2897874874','AMRAPALI,JAIPUR','4')
insert into CITIZEN values ('BIPASHA','T','BASU','378611840029','F','1985-11-12','7526684489','VIJAYADAR,JAIPUR','4')
insert into CITIZEN values ('PRIYANKA','D','CHOPRA','378611840030','F','1978-05-23','9213678436','GANDHIPANTH,JAIPUR','4')
insert into CITIZEN values ('ABHISHEK','W','BACCHAN','378611840031','M','1974-04-19','6754635466','MALVIYA,JAIPUR','4')
insert into CITIZEN values ('AISHWARYA','T','RAI','378611840032','F','1975-08-23','8193740465','AMRAPALI,JAIPUR','4')
insert into CITIZEN values ('AKSHAY','A','SAXENA','378611840033','M','1963-04-13','9384765643','CHORNAGAR,JAIPUR','4')
insert into CITIZEN values ('YUVRAJ','T','SINGH','378611840034','M','1973-02-14','9912938483','GAURAVNAGAR,JAIPUR','4')
insert into CITIZEN values ('RAJ','T','KOOTHRAPALLI','378611840035','M','1992-05-18','9234212233','AKSHAYNAGAR,JAIPUR','4')
insert into CITIZEN values ('SHELDON','T','JACKSON','378611840036','M','1991-08-23','9014798478','MALVIYA,JAIPUR','4')


Select * 
From CITIZEN
order by VNumber




--MEMBER

insert into MEMBER values ('MEMBER0001','378611840190','EDUCATION','56000')
insert into MEMBER values ('MEMBER0002','378611840186','HEALTHCARE','78000')
insert into MEMBER values ('MEMBER0003','378611840187','SECURITY','67980')
insert into MEMBER values ('MEMBER0004','378611840188','HOUSING','98000')

insert into MEMBER values ('MEMBER0005','378611840004','EDUCATION','60000')
insert into MEMBER values ('MEMBER0006','378611840010','HEALTHCARE','80000')
insert into MEMBER values ('MEMBER0007','378611840014','SECURITY','70000')
insert into MEMBER values ('MEMBER0008','378611840011','HOUSING','94000')

insert into MEMBER values ('MEMBER0009','378611840027','EDUCATION','56000')
insert into MEMBER values ('MEMBER0010','378611840023','HEALTHCARE','79000')
insert into MEMBER values ('MEMBER0011','378611840024','SECURITY','89000')
insert into MEMBER values ('MEMBER0012','378611840026','HOUSING','90000')

insert into MEMBER values ('MEMBER0013','378611840031','EDUCATION','54000')
insert into MEMBER values ('MEMBER0014','378611840032','HEALTHCARE','75000')
insert into MEMBER values ('MEMBER0015','378611840036','SECURITY','87000')
insert into MEMBER values ('MEMBER0016','378611840035','HOUSING','93000')

Select *
From MEMBER






--SARPANCH

insert into SARPANCH values ('SARPANCH01','378611840185','100000')
insert into SARPANCH values ('SARPANCH02','378611840003','105000')
insert into SARPANCH values ('SARPANCH03','378611840020','120000')
insert into SARPANCH values ('SARPANCH04','378611840033','100000')

Select * 
From SARPANCH






--PANCHAYAT

insert into PANCHAYAT values ('MANGALORE','DAKSHINA KANNNADA','SARPANCH01','1')
insert into PANCHAYAT values ('UDUPI','UDUPI','SARPANCH02','2')
insert into PANCHAYAT values ('NITTE','UDUPI','SARPANCH03','3')
insert into PANCHAYAT values ('JAIPUR','JAIPUR','SARPANCH04','4')

Select *
From PANCHAYAT


		



--GOVERNMENT

insert into GOVERNMENT values ('KARNATAKA','SIDDARAMAIAH','VAJUBHAI RUDABHAIVALA','1')
insert into GOVERNMENT values ('RAJASTHAN','VASUNDHARA RAJE','KALYAN SINGH','2')

Select * 
From GOVERNMENT






--SECRETARY

insert into SECRETARY values ('RAMESH','D','VISWAS','SECRETARY1','378611840001','M','1986-12-01','BCOM','9875983279','60000','1','1')
insert into SECRETARY values ('GAYATHRI','S','NAYAR','SECRETARY2','378611840002','F','1981-09-13','BCOM','8179267613','67000','2','1')
insert into SECRETARY values ('SUSHANG','F','POOJARY','SECRETARY3','378611840003','M','1986-06-12','BE','9523456721','63000','3','1')
insert into SECRETARY values ('AKEEL','R','MUHAMMAD','SECRETARY4','378611840004','M','1979-01-01','BCOM','7164352642','61000','4','2')

Select *
From SECRETARY






--MEETING

insert into MEETING values ('MEETING001','2016-11-01')
insert into MEETING values ('MEETING002','2016-10-10')
insert into MEETING values ('MEETING003','2016-05-05')
insert into MEETING values ('MEETING004','2015-12-15')
insert into MEETING values ('MEETING005','2015-11-21')
insert into MEETING values ('MEETING006','2015-12-25')

Select * 
From MEETING





--ISSUE

insert into ISSUE values ('ISSUE001','378611840019','ROBBERY','MEETING001')
insert into ISSUE values ('ISSUE002','378611840194','CHILD LABOUR','MEETING001')
insert into ISSUE values ('ISSUE003','378611840009','LAND DISPUTE','MEETING002')
insert into ISSUE values ('ISSUE004','378611840199','HARRASMENT','MEETING003')
insert into ISSUE values ('ISSUE005','378611840005','DOMESTIC VIOLENCE','MEETING004')
insert into ISSUE values ('ISSUE006','378611840017','HUMAN TRAFFICKING','MEETING005')
insert into ISSUE values ('ISSUE007','378611840012','PROPERTY DISPUTE','MEETING006')
insert into ISSUE values ('ISSUE008','378611840030','DISCRIMINATION','MEETING006')

Select *
From ISSUE






--LAW

insert into LAW values ('LAW01','LAW AGAINST DOMESTIC VIOLENCE AND ABUSE: THIS LAW DEALS CRUELTY BY A HUSBAND OR HIS FAMILY TOWARDS A MARRIED WOMAN.')
insert into LAW values ('LAW02','LAW AGAINST DOWRY: THIS ACT PROVIDES THE PENALTY FORDIRECTLY AND INDIRECTLY DEMANDING DOWRY.')
insert into LAW values ('LAW03','LAW AGAINST CHILD MARRIAGE: THIS LAW PROHIBITS THE PRATICE OF CHILD MARRIAGE.')
insert into LAW values ('LAW04','LAW AGAINST DESCRIMINATION: PROHIBITS THE EMPLOYERS TO DESCRIMINATE EMPLOYEES BASED ON RACE,SEX,COLOR,RELIGION AND SEX.')
insert into LAW values ('LAW05','LAW ON OWNERSHIP OF PROPERTY AND LAND: DEALS WITH THE AREA OF LAW THAT GOVERNS THE VARIOUS FORMS OF OWNERSHIP AND TENANCY IN REAL PROPERTY.')
insert into LAW values ('LAW07','LAW AGAINST THEFT: THEFT IS THE ILLEAGLE TAKING OF ANOTHER PERSONS PROPERTY WITHOUT THAT PERSONS CONSENT.')
insert into LAW values ('LAW08','LAW AGAINST HAR5RASMENT: THE UNLAWFUL VIOLENCE LIKE ASSAULT OR BATTERY OR STALKING OR A CREDIBLE THREAT OF VIOLENCE.')


Select * 
From LAW





--WELFARE

insert into WELFARE values ('WELFARE001','378611840195','HEALTHCARE','10000','10')
insert into WELFARE values ('WELFARE002','378611840198','EDUCATION','16000','9')
insert into WELFARE values ('WELFARE003','378611840194','SECURITY','15000','10')
insert into WELFARE values ('WELFARE004','378611840003','HOUSING','60000','10')

insert into WELFARE values ('WELFARE005','378611840003','SECURITY','15000','10')
insert into WELFARE values ('WELFARE006','378611840005','EDUCATION','16000','6')
insert into WELFARE values ('WELFARE007','378611840009','HEALTHCARE','60000','6')
insert into WELFARE values ('WELFARE008','378611840010','HOUSING','600000','6')

insert into WELFARE values ('WELFARE009','378611840019','EDUCATION','40000','5')
insert into WELFARE values ('WELFARE010','378611840025','SECURITY','60000','7')
insert into WELFARE values ('WELFARE011','378611840016','HOUSING','60000','6')
insert into WELFARE values ('WELFARE012','378611840017','HOUSING','60000','6')

insert into WELFARE values ('WELFARE013','378611840033','HEALTHCARE','65000','7')
insert into WELFARE values ('WELFARE014','378611840034','HOUSING','60000','4')
insert into WELFARE values ('WELFARE015','378611840027','HOUSING','60000','4')
insert into WELFARE values ('WELFARE016','378611840028','EDUCATION','60000','6')

Select *
From WELFARE





--DEVELOPMENT_PROJECT

insert into DEVELOPMENT_PROJECT values ('PROJECT001','1','SHAURYA ADVAITH','200000000','50')
insert into DEVELOPMENT_PROJECT values ('PROJECT002','1','KABIR KALYAN','30000000','60')
insert into DEVELOPMENT_PROJECT values ('PROJECT003','2','DARSH DURV','10000000','50')
insert into DEVELOPMENT_PROJECT values ('PROJECT004','2','PARI AVANI','12500000','78')
insert into DEVELOPMENT_PROJECT values ('PROJECT005','3','JOSEPH MATIZ','32000000','100.5')
insert into DEVELOPMENT_PROJECT values ('PROJECT006','3','LEAH JOHN','10000000','76')
insert into DEVELOPMENT_PROJECT values ('PROJECT007','4','AYUSH GAVANI','6000000','45')
insert into DEVELOPMENT_PROJECT values ('PROJECT008','4','PAVITHRA RAJAN','30000000','70')

Select * 
From DEVELOPMENT_PROJECT






--WORKS_ON

insert into WORKS_ON values ('WORK001','PROJECT001','378611840190')
insert into WORKS_ON values ('WORK002','PROJECT001','378611840186')
insert into WORKS_ON values ('WORK003','PROJECT002','378611840191')

insert into WORKS_ON values ('WORK004','PROJECT003','378611840004')
insert into WORKS_ON values ('WORK005','PROJECT003','378611840010')
insert into WORKS_ON values ('WORK006','PROJECT004','378611840011')
insert into WORKS_ON values ('WORK007','PROJECT004','378611840014')

insert into WORKS_ON values ('WORK008','PROJECT005','378611840022')
insert into WORKS_ON values ('WORK009','PROJECT005','378611840026')
insert into WORKS_ON values ('WORK010','PROJECT006','378611840023')
insert into WORKS_ON values ('WORK011','PROJECT006','378611840024')

insert into WORKS_ON values ('WORK012','PROJECT007','378611840031')
insert into WORKS_ON values ('WORK013','PROJECT008','378611840035')


Select * 
From WORKS_ON
