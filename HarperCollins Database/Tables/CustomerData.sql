CREATE TABLE [dbo].[CustomerData]
(
	[CustomerNumber] INT NOT NULL PRIMARY KEY, 
    [CustomerName] NVARCHAR(250) NOT NULL, 
    [AddressLine1] NTEXT NOT NULL, 
    [AddressLine2] NTEXT NULL, 
    [AddressLine3] NTEXT NULL
)
