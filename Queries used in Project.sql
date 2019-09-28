/**
Dummy data insertion starts ...
**/
insert into Staff(StaffName,Designation,NIC,Address,Salary, BankAccountNumber, LoginPassword)
values
('Bashir', 'CEO', '1234561234561', 'abcdefg', 25000, 1234567899878, 'hi'),
('Ismail Vohra' , 'Manager' , '1234561231231', 'DHA, Karachi' , 1000 , 1234578 , 'pass123'),
('Saman Gaziani' , 'Manager' , '1264757384673', 'Gulberg, Karachi' , 2000, 2847734, 'pass456'),
('Emad Abid', 'Administrator', '1737478462736','Karimabad, Karachi', 3000, 8487474,	'hello'),
('Waseem Khan','Marketing Director', '7374273763747', 'Gulberg, Lahore',4000, 8384637, '1234'),
('Gulab Khan','Finance Director','7274826484728', 'Liberty, Lahore', 5000, 9274294, '8hfeh'),
('Saleha Sikandar',	'Finance Director',	'7264826483826',	'F-8, Islamabad',	1000,	2949472,	'bdgw7'),
('Ahmed Baloch'	,'IT Manager',	'7274827486264',	'Ayesha Manzil, Karachi', 1500,	2938749,	'bdvs7'),
('Sami Qadeer',	'IT Manager',	'1237476472222',	'Clifton, Karachi',	2000,	7473847,	'bdjs8'),
('Abdullah Khan',	'Outreach Director',	'2737463736473',	'Atta Bahn Road, Hyderabad',	8000,	3737493,	'hfks8'),
('Ashraf Wathra','Sponsorship Director',	'2737463736465',	'F-9, Islamabad',	9000,	8474937,	'bjsgf8')

insert into Administrator(Staff_StaffID, Date_start, Date_end,CurrentAdmin)
values
(3, DATEFROMPARTS(2016,02,02) ,DatefromParts(2016,03,02),	0),
(5,DATEFROMPARTS(2016,10,06) ,DatefromParts(2016,11,06),	0),
(7,DATEFROMPARTS(2017,05,05) ,DatefromParts(2017,06,05),	0),
(6,DATEFROMPARTS(2016,07,02) ,DatefromParts(2016,08,02),	0),
(10,DATEFROMPARTS(2018,08,06) ,DatefromParts(2016,06,18),	1)


insert into StaffDisciplinaryRecord(Staff_StaffID,DateTime_2,Summary)
values
(4, smalldatetimefromparts(2016,02,02,10,24),	'Rude to Customer'),
(5, smalldatetimefromparts(2016, 02, 06 ,10,22),'Harrasement against fellow employee'),
(3, smalldatetimefromparts(2016,10,5,11,20),	'Financial concerns'),
(7, smalldatetimefromparts(2015,10,25, 09,21),	'Rude to Customer'),
(8, SMALLDATETIMEFROMPARTS(2017,09,11,8,10),	'Financial concerns')

insert into Customer(UserNIC,UserName,Occupation,Constituency,Address,LoginPassword)
values
('1747573747373',	'ismailvohra',	'Businessman',	'NA-120',	'DHA, Lahore',	'hello123'),
('2748748747274',	'smanagz',	'Businessman',	'NA-240',	'DHA, Karachi',	'hello456'),
('8374835683748',	'emadabid',	'Employed',	'NA-260',	'DHA, Islamabad',	'hello786'),
('9284737493794',	'sameergh',	'Employed',	'NA-100',	'Clifton, Karachi',	'jhg234'),
('8384924943948',	'aghazki',	'Student',	'NA-90',	'Ayesha Manzil, Karachi',	'khi783'),
('9385983959385',	'ehsangz',	'Student',	'NA-80',	'Gulberg, Lahore',	'lhr234'),
('9284038494803',	'jamesrd',	'Student',	'NA-70',	'Liberty, Lahore',	'lki384'),
('3808485938038',	'ahmedty',	'Businessman',	'NA-60',	'Kalma Chowk, Lahore',	'hdhfk'),
('9284084038494',	'ghaziab',	'Businessman',	'NA-50',	'Lahore Cantt, Lahore',	'hs83hd'),
('9380385938408',	'ayeshabh',	'Student',	'NA-40',	'Gulshan, Karachi',	'shdjjd8')

insert into Networks(NetworkName)
values
('Zong'),
('Jazz'),
('Telenor'),
('Ufone'),
('Djuice')

insert into Network_WeakEntity(Networks_idNetworks, Customer_UserID, RegistrationDate,Active, DeactivationDate, CellNumber)
values
(2,	3,	datefromparts(2016,08,01),	1,	DATEFROMPARTS(2017,09,10),	3331234575),
(3,	4,	datefromparts(2016,08,02),	1,	datefromparts(2017,10,11),	3213456785),
(4,	5,	datefromparts(2017,08,03),	0,	datefromparts(2017,09,11),	3004858839),
(5,	10,	datefromparts(2017,09,10),	0,	datefromparts(2017,10,15),	3458822844),
(1,	9,	datefromparts(2017,10,10),	1,	datefromparts(2017,12,23),	3338583958)

insert into MessageLog(Network_WeakEntity_CellNumber,DateTime_2,Rate,PackageDiscount)
values
('3338583958', smalldatetimefromparts(2017,02,02,8,12),5,	100),
('3331234575', smalldatetimefromparts(2017,10,02,12,00),5,	200),
('3458822844', SMALLDATETIMEFROMPARTS(2016,11,02,09,00), 5,	300),
('3004858839', smalldatetimefromparts(2017,05,10,11,11),5,	400),
('3331234575', smalldatetimefromparts(2017,05,01,06,00),5,	500)

insert into Payment(Network_WeakEntity_CellNumber,MonthYear,Total_Bill)
values
('3213456785', datefromparts(2016,08,01),	2000),
('3458822844', datefromparts(2017,10,01),	5000),
('3004858839', datefromparts(2017,09,01),	2000),
('3213456785', datefromparts(2017,01,01),	3000),
('3458822844', datefromparts(2017,11,01),	2000)

insert into Rate(Rateperminute)
values
(2),
(3)

insert into CallLog(Network_WeakEntity_CellNumber1,Network_WeakEntity_CellNumber2, Rate_CallType,DateTime_2,Call_Duration,PackageDiscount)
values
('3213456785', '3458822844', 2, SMALLDATETIMEFROMPARTS(2017,02,02,8,12), 1, 1000),
('3213456785', '3004858839',2, SMALLDATETIMEFROMPARTS(2017,10,02,12,00), 2, 2000),
('3004858839', '3458822844', 2, SMALLDATETIMEFROMPARTS(2016,11,02,9,00),3,3000),
('3004858839' , '3458822844' , 2, SMALLDATETIMEFROMPARTS(2017,10,05,11,11) , 5, 2000),
( '3458822844', '3213456785' , 2, SMALLDATETIMEFROMPARTS(2017,01,05,6,01), 6,4000)
/**
Dummy data insertion ends ...
**/
---------------------------------------------------------------------------------------------------------


/**
Table states
**/
select * from Staff
select * from Administrator
select * from StaffDisciplinaryRecord
select * from Customer
select * from Networks
select * from Network_WeakEntity
select * from MessageLog
select * from Payment
select * from Rate
select * from CallLog

---------------------------------------------------------------------------------------------------------

