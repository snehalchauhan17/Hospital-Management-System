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
)
