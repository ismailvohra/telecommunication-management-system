CREATE TABLE Networks (
  idNetworks INTEGER  NOT NULL   IDENTITY ,
  NetworkName VARCHAR(255)      ,
PRIMARY KEY(idNetworks));
GO




CREATE TABLE Rate (
  CallType  INTEGER  NOT NULL   IDENTITY ,
  Rateperminute INTEGER  NOT NULL    ,
PRIMARY KEY(CallType ));
GO




CREATE TABLE Staff (
  StaffID INTEGER  NOT NULL   IDENTITY ,
  StaffName VARCHAR(255)    ,
  Designation VARCHAR(255)    ,
  NIC INTEGER    ,
  Address VARCHAR(255)    ,
  Salary INTEGER    ,
  BankAccountNumber VARCHAR(255)    ,
  LoginPassword VARCHAR(255)      ,
PRIMARY KEY(StaffID));
GO




CREATE TABLE Customer (
  UserID INTEGER  NOT NULL   IDENTITY ,
  UserNIC INTEGER    ,
  UserName VARCHAR(255)    ,
  Occupation VARCHAR(255)    ,
  Constituency VARCHAR(255)    ,
  Address VARCHAR(255)    ,
  LoginPassword VARCHAR(255)      ,
PRIMARY KEY(UserID));
GO




CREATE TABLE Administrator (
  AdministratorID INTEGER  NOT NULL   IDENTITY ,
  Staff_StaffID INTEGER  NOT NULL  ,
  Date_start DATE    ,
  Date_end DATE    ,
  CurrentAdmin bit      ,
PRIMARY KEY(AdministratorID)  ,
  FOREIGN KEY(Staff_StaffID)
    REFERENCES Staff(StaffID));
GO


CREATE INDEX Administrator_FKIndex1 ON Administrator (Staff_StaffID);
GO


CREATE INDEX IFK_Rel_09 ON Administrator (Staff_StaffID);
GO


CREATE TABLE StaffDisciplinaryRecord (
  StaffDisciplinaryRecordID INTEGER  NOT NULL   IDENTITY ,
  Staff_StaffID INTEGER  NOT NULL  ,
  DateTime_2 DATETIME    ,
  Summary VARCHAR(255)      ,
PRIMARY KEY(StaffDisciplinaryRecordID, Staff_StaffID)  ,
  FOREIGN KEY(Staff_StaffID)
    REFERENCES Staff(StaffID));
GO


CREATE INDEX StaffDisciplinaryRecord_FKIndex1 ON StaffDisciplinaryRecord (Staff_StaffID);
GO


CREATE INDEX IFK_Rel_13 ON StaffDisciplinaryRecord (Staff_StaffID);
GO


CREATE TABLE Network_WeakEntity (
  CellNumber VARCHAR(255)  NOT NULL  ,
  Customer_UserID INTEGER  NOT NULL  ,
  Networks_idNetworks INTEGER  NOT NULL  ,
  RegistrationDate DATE  NOT NULL  ,
  Active bit  NOT NULL  ,
  DeactivationDate DATE      ,
PRIMARY KEY(CellNumber)    ,
  FOREIGN KEY(Networks_idNetworks)
    REFERENCES Networks(idNetworks),
  FOREIGN KEY(Customer_UserID)
    REFERENCES Customer(UserID));
GO


CREATE INDEX Network_WeakEntity_FKIndex2 ON Network_WeakEntity (Networks_idNetworks);
GO
CREATE INDEX Network_WeakEntity_FKIndex3 ON Network_WeakEntity (Customer_UserID);
GO


CREATE INDEX IFK_Rel_10 ON Network_WeakEntity (Networks_idNetworks);
GO
CREATE INDEX IFK_Rel_11 ON Network_WeakEntity (Customer_UserID);
GO


CREATE TABLE CallLog (
  CallID INTEGER  NOT NULL   IDENTITY ,
  Network_WeakEntity_CellNumber2 VARCHAR(255)  NOT NULL  ,
  Network_WeakEntity_CellNumber1 VARCHAR(255)  NOT NULL  ,
  Rate_CallType  INTEGER  NOT NULL  ,
  DateTime_2 DATETIME    ,
  Call_Duration INTEGER  NOT NULL  ,
  PackageDiscount INTEGER      ,
PRIMARY KEY(CallID)      ,
  FOREIGN KEY(Network_WeakEntity_CellNumber1)
    REFERENCES Network_WeakEntity(CellNumber),
  FOREIGN KEY(Rate_CallType )
    REFERENCES Rate(CallType ),
  FOREIGN KEY(Network_WeakEntity_CellNumber2)
    REFERENCES Network_WeakEntity(CellNumber));
GO


CREATE INDEX CallLog_FKIndex1 ON CallLog (Network_WeakEntity_CellNumber1);
GO
CREATE INDEX CallLog_FKIndex2 ON CallLog (Rate_CallType );
GO
CREATE INDEX CallLog_FKIndex3 ON CallLog (Network_WeakEntity_CellNumber2);
GO


CREATE INDEX IFK_Rel_14 ON CallLog (Network_WeakEntity_CellNumber1);
GO
CREATE INDEX IFK_Rel_15 ON CallLog (Rate_CallType );
GO
CREATE INDEX IFK_Rel_16 ON CallLog (Network_WeakEntity_CellNumber2);
GO


CREATE TABLE Payment (
  PaymentID INTEGER  NOT NULL   IDENTITY ,
  Network_WeakEntity_CellNumber VARCHAR(255)  NOT NULL  ,
  MonthYear DATE    ,
  Total_Bill INTEGER      ,
PRIMARY KEY(PaymentID)  ,
  FOREIGN KEY(Network_WeakEntity_CellNumber)
    REFERENCES Network_WeakEntity(CellNumber));
GO


CREATE INDEX Payment_FKIndex1 ON Payment (Network_WeakEntity_CellNumber);
GO


CREATE INDEX IFK_Rel_18 ON Payment (Network_WeakEntity_CellNumber);
GO


CREATE TABLE MessageLog (
  MessageID INTEGER  NOT NULL   IDENTITY ,
  Network_WeakEntity_CellNumber VARCHAR(255)  NOT NULL  ,
  DateTime_2 DATETIME    ,
  Rate INTEGER    ,
  PackageDiscount INTEGER      ,
PRIMARY KEY(MessageID)  ,
  FOREIGN KEY(Network_WeakEntity_CellNumber)
    REFERENCES Network_WeakEntity(CellNumber));
GO


CREATE INDEX MessageLog_FKIndex1 ON MessageLog (Network_WeakEntity_CellNumber);
GO


CREATE INDEX IFK_Rel_19 ON MessageLog (Network_WeakEntity_CellNumber);
GO
