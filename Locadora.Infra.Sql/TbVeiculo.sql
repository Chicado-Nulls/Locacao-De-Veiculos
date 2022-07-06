CREATE TABLE [dbo].[TbVeiculo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Modelo] VARCHAR(50) NOT NULL, 
    [Placa ] VARCHAR(50) NOT NULL, 
    [Marca] VARCHAR(50) NOT NULL, 
    [Cor] VARCHAR(50) NOT NULL, 
    [EnumTipoDeCombustivel] INT NULL, 
    [CapacidadeTanque] DECIMAL(18, 2) NOT NULL, 
    [KmPercorrido] DECIMAL(18, 2) NOT NULL, 
    [GrupoDeVeiculo_Id] INT NOT NULL, 
    [Foto] VARBINARY(MAX) NULL, 
    CONSTRAINT [FK_TbVeiculo_TbGrupoDeVeiculos] FOREIGN KEY (GrupoDeVeiculo_Id) REFERENCES TbGrupoDeVeiculos(Id) 
)
