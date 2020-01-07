CREATE TABLE [dbo].[TileData]
(
--Used Varchar because int may remove the zeros 
--Numeric types like INTEGER will remove leading zeroes in ISBNs
	[ISBN] VARCHAR(20) NOT NULL PRIMARY KEY, 
    [Title] NTEXT NOT NULL, 

	--Author should be a lookup table, but I kept it here to make it simple.
    [Author] NVARCHAR(250) NOT NULL, 

	--format should be a lookup table, but I kept it here to make it simple.
    [Format] VARCHAR(100) NOT NULL, 
    [ListPrice] MONEY NOT NULL DEFAULT 0.00
)
