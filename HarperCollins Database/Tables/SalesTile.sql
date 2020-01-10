CREATE TABLE [dbo].[SalesTile]
(
	[SalesTileId] INT NOT NULL IDENTITY(1,1),
    [SalesId] UNIQUEIDENTIFIER NOT NULL, 
    [ISBN] VARCHAR(20) NOT NULL, 
    [OrderQuantity] INT NOT NULL DEFAULT 1
	CONSTRAINT [PK_SalesTile] PRIMARY KEY ([SalesTileId]), 
	CONSTRAINT [FK_SalesTile_ToTileData] FOREIGN KEY ([ISBN]) REFERENCES [dbo].[TileData]([ISBN])

)
