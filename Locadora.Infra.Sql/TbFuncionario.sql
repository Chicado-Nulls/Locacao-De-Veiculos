CREATE TABLE [dbo].[TbFuncionario]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NOT NULL, 
    [Login] NVARCHAR(50) NOT NULL, 
    [Senha] NVARCHAR(50) NOT NULL, 
    [DataEntrada] DATE NOT NULL, 
    [Administrador] BIT NOT NULL, 
    [Salario] DECIMAL(18, 2) NOT NULL
)
