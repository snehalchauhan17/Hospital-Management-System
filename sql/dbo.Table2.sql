CREATE TABLE [dbo].[roombooking]
(
    [PID] INT NOT NULL, 
    [Normal] INT NULL, 
    [Medium] INT NULL, 
    [VIP] INT NULL, 
    [Room no] INT NULL, 
    [Number of bed] INT NULL, 
    [Building] NVARCHAR(50) NULL, 
    [Price] INT NULL, 
    CONSTRAINT [PK_roombooking] PRIMARY KEY ([PID])
)
