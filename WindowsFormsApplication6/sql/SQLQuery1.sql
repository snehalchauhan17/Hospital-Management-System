CREATE TABLE [dbo].[roombooking] (
    [PID]       INT  NOT NULL,
    [RoomType]  TEXT NOT NULL,
    [Roomno]    INT  NOT NULL,
    [Price]     INT  NOT NULL,
    [StartDate] TEXT NOT NULL,
    [EndDate]   TEXT NOT NULL,
    [Status]    TEXT NOT NULL,
    CONSTRAINT [PK_roombooking] PRIMARY KEY CLUSTERED ([PID] ASC), 
    CONSTRAINT [FK_roombooking_PatientInfo] FOREIGN KEY ([PID]) REFERENCES [PatientInfo]([pid])
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
    PRIMARY KEY CLUSTERED ([PID] ASC), 
    CONSTRAINT [FK_BillPayment_To_PatientInfo] FOREIGN KEY ([PID]) REFERENCES [PatientInfo]([pid])
);



CREATE TABLE [dbo].[Login] (
    [userId]    VARCHAR (50) NOT NULL,
    [password]  VARCHAR (50) NOT NULL,
    [firstName] VARCHAR (50) NOT NULL,
    [lastName]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([userId] ASC)
);


