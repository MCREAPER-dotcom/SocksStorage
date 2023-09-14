CREATE TABLE [dbo].[CompanyTable]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CompanyName] NCHAR(10) NULL, 
    [SocksId] INT foreign key references dbo.SocksTable(SocksId)
)
