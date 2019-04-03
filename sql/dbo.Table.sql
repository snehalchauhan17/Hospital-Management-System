CREATE TABLE [dbo].[PatientInfo]
(
	[pid] INT NOT NULL PRIMARY KEY, 
    [date] VARCHAR(20) NULL, 
    [name] VARCHAR(20) NULL, 
    [gender] VARCHAR(10) NULL, 
    [age] INT NULL, 
    [address] VARCHAR(50) NULL, 
    [disease] VARCHAR(50) NULL
)
