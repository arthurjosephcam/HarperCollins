﻿CREATE TABLE [dbo].[SalesData]
(
--SalesId could be guid. --Decided to make it guid, rather than int
	[SalesId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [OrderDate] DATETIME NOT NULL DEFAULT GetDate(), 
    [ISBN] VARCHAR(20) NOT NULL, 
    [CustomerNumber] INT NOT NULL, 
    [OrderQuantity] INT NOT NULL DEFAULT 1, 

	--Should be a lookup. Pending, Preparing, Shipping, Shipped, Complete, Returned.
    [OrderStatus] VARCHAR(20) NOT NULL DEFAULT 'Pending', 
    CONSTRAINT [FK_SalesData_ToCustomerData] FOREIGN KEY (CustomerNumber) REFERENCES [dbo].[CustomerData]([CustomerNumber]), 
    CONSTRAINT [FK_SalesData_ToTileData] FOREIGN KEY ([ISBN]) REFERENCES [dbo].[TileData]([ISBN])

)
