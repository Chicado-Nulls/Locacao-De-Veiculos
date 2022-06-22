CREATE TABLE [dbo].[TbFuncionario]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NULL, 
    [Login] NVARCHAR(50) NULL, 
    [Senha] NVARCHAR(50) NULL, 
    [DataEntrada] DATE NULL
)
