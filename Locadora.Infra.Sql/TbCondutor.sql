CREATE TABLE [dbo].[TbCondutor]
(
    [Id] UNIQUEIDENTIFIER NOT NULL, 
    [Nome] NVARCHAR(60) NOT NULL, 
    [Cpf] NVARCHAR(14) NOT NULL, 
    [Cnh] NVARCHAR(11) NOT NULL, 
    [Endereco] NVARCHAR(150) NOT NULL, 
    [Email] NVARCHAR(80) NOT NULL, 
    [Telefone] NVARCHAR(16) NOT NULL, 
    [Cliente_Id] INT NOT NULL,
    CONSTRAINT [FK_TbCondutor_TbCliente] FOREIGN KEY (Cliente_Id) REFERENCES [TbCliente]([Id]), 
    CONSTRAINT [PK_TbCondutor] PRIMARY KEY ([Id])
)
