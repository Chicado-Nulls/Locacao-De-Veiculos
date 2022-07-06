CREATE TABLE [dbo].[TbPlanoCobranca]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Grupo_Veiculo_Id] INT NOT NULL, 
    [Diario_Diaria] DECIMAL(18, 2) NOT NULL, 
    [Diario_Por_Km] DECIMAL(18, 2) NOT NULL, 
    [Livre_Diaria] DECIMAL(18, 2) NOT NULL, 
    [Controlado_Diaria] DECIMAL(18, 2) NOT NULL, 
    [Controlado_Por_Km] DECIMAL(18, 2) NOT NULL, 
    [Controlado_Limite_Km] DECIMAL(18, 2) NOT NULL, 
    CONSTRAINT [FK_TbPlanoCobranca_TbGrupoDeVeiculos] FOREIGN KEY ([Grupo_Veiculo_Id]) REFERENCES [TbGrupoVeiculo]([Id])
)
