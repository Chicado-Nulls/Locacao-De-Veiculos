CREATE TABLE [dbo].[TbTaxa]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Valor] DECIMAL(18, 2) NOT NULL, 
    [Descricao] VARCHAR(50) NOT NULL, 
    [Enum_TipoDeCalculo] INT NOT NULL
)
