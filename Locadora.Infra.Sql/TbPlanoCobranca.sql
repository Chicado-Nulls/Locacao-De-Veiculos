CREATE TABLE [dbo].[TbPlanoCobranca]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Grupo_Veiculo_Id] INT NOT NULL, 
    [Diario_Valor_Diario] DECIMAL(18, 2) NOT NULL, 
    [Diario_Valor_Por_Km] DECIMAL(18, 2) NOT NULL, 
    [Livre_Valor_Diario] DECIMAL(18, 2) NOT NULL, 
    [Controlado_Valor_Diario] DECIMAL(18, 2) NOT NULL, 
    [Controlado_Valor_Por_Km] DECIMAL(18, 2) NOT NULL, 
    [Controlado_Limite_De_Km] DECIMAL(18, 2) NOT NULL, 
    CONSTRAINT [FK_TbPlanoCobranca_TbGrupoDeVeiculos] FOREIGN KEY ([Grupo_Veiculo_Id]) REFERENCES [TbGrupoDeVeiculos]([Id])
)
