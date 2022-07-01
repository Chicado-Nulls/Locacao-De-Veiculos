CREATE TABLE [dbo].[TbPlanoCobranca]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [GrupoVeiculoId] INT NOT NULL, 
    [DiarioValorDiario] DECIMAL(18, 2) NOT NULL, 
    [DiarioValorPorKm] DECIMAL(18, 2) NOT NULL, 
    [LivreValorDiario] DECIMAL(18, 2) NOT NULL, 
    [ControladoValorDiario] DECIMAL(18, 2) NOT NULL, 
    [ControladoValorPorKm] DECIMAL(18, 2) NOT NULL, 
    [ControladoLimiteDeKm] DECIMAL(18, 2) NOT NULL, 
    CONSTRAINT [FK_TbPlanoCobranca_TbGrupoDeVeiculos] FOREIGN KEY (GrupoVeiculoId) REFERENCES [TbGrupoDeVeiculos]([Id])
)
