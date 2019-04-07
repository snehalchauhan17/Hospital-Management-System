CREATE TABLE [dbo].[roombooking]
(
    [PID] INT NOT NULL, 
    [RoomType] NVARCHAR(50) NOT NULL, 
    [Roomno] INT NOT NULL, 
    [Price] INT NOT NULL, 
    [Status] NVARCHAR(50) NOT NULL, 
    [StartDate] NCHAR(10) NOT NULL, 
    [EndDate] NCHAR(10) NOT NULL, 
    CONSTRAINT [PK_roombooking] PRIMARY KEY ([PID])
);

CREATE TABLE [dbo].[PatientInfo] (
    [pid]     INT          NOT NULL,
    [date]    VARCHAR (20) NOT NULL,
    [name]    VARCHAR (20) NOT NULL,
    [gender]  VARCHAR (10) NOT NULL,
    [age]     INT          NOT NULL,
    [address] VARCHAR (50) NOT NULL,
    [disease] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([pid] ASC)
);
