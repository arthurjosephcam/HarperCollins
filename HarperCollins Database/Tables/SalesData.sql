CREATE TABLE [dbo].[SalesData]
(
--SalesId could be guid. --Decided to make it guid, rather than int
	[ActualSalesId] int not null primary key IDENTITY(1,1),
	[SalesId] UNIQUEIDENTIFIER NOT NULL, 
    [OrderDate] DATETIME NOT NULL DEFAULT GetDate(), 
    [ISBN] VARCHAR(20) NOT NULL, 
    [CustomerNumber] INT NOT NULL, 
    [OrderQuantity] INT NOT NULL DEFAULT 1, 

	--Should be a lookup. Pending, Preparing, Shipping, Shipped, Complete, Returned.
    [OrderStatus] VARCHAR(20) NOT NULL DEFAULT 'Pending', 
    CONSTRAINT [FK_SalesData_ToCustomerData] FOREIGN KEY (CustomerNumber) REFERENCES [dbo].[CustomerData]([CustomerNumber]), 
    CONSTRAINT [FK_SalesData_ToTileData] FOREIGN KEY ([ISBN]) REFERENCES [dbo].[TileData]([ISBN])

)
