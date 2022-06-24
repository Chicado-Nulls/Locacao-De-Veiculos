CREATE TABLE [dbo].[TbTaxa]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Valor] DECIMAL NOT NULL, 
    [Descricao] VARCHAR(50) NULL, 
    [Enum_TipoDeCalculo] INT NULL
)
