CREATE TABLE [dbo].[roombooking] (
    [PID]       INT        NOT NULL,
    [RoomType]  VARCHAR (10) NOT NULL,
    [Roomno]    INT        NOT NULL,
    [Price]     INT        NOT NULL,
    [Status]    VARCHAR (10) NOT NULL,
    [StartDate] VARCHAR (20) NOT NULL,
    [EndDate]   VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_roombooking] PRIMARY KEY CLUSTERED ([PID] ASC)
);



CREATE TABLE [dbo].[PatientInfo] (
    [pid]     INT          NOT NULL,
    [date]    VARCHAR (20) NULL,
    [name]    VARCHAR (20) NULL,
    [gender]  VARCHAR (10) NULL,
    [age]     INT          NULL,
    [address] VARCHAR (50) NULL,
    [disease] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([pid] ASC)
);



CREATE TABLE [dbo].[BillPayment] (
    [PID]             INT NOT NULL,
    [RoomRent]        INT NOT NULL,
    [medicineCharges] INT NOT NULL,
    [doctorCharges]   INT NOT NULL,
    [reportCharges]   INT NOT NULL,
    [otherCharges]    INT NOT NULL,
    [total]           INT NOT NULL,
    PRIMARY KEY CLUSTERED ([PID] ASC)
);
