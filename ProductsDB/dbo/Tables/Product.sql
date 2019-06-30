CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductID] INT NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL, 
    [Sizes] NVARCHAR(50) NOT NULL, 
    [Price] DECIMAL NOT NULL
)
