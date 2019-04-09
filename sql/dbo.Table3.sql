CREATE TABLE [dbo].[BillPayment]
(
	[PID] INT NOT NULL PRIMARY KEY, 
    [RoomRent] INT NOT NULL, 
    [medicineCharges] INT NOT NULL, 
    [doctorCharges] INT NOT NULL, 
    [reportCharges] INT NOT NULL, 
    [otherCharges] INT NOT NULL, 
    [total] INT NOT NULL
)
