CREATE TABLE [dbo].[TbVeiculo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Modelo] VARCHAR(50) NULL, 
    [Placa ] VARCHAR(50) NULL, 
    [Marca] VARCHAR(50) NULL, 
    [Cor] VARCHAR(50) NULL, 
    [EnumTipoDeCombustivel] INT NULL, 
    [CapacidadeTanque] DECIMAL(18, 2) NULL, 
    [KmPercorrido] DECIMAL(18, 2) NULL, 
    [GrupoDeVeiculo_Id] INT NULL 
)
