CREATE TABLE [dbo].[TbCondutor]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NCHAR(60) NOT NULL, 
    [Cpf] NCHAR(14) NOT NULL, 
    [Cnh] NCHAR(11) NOT NULL, 
    [Endereco] NCHAR(150) NOT NULL, 
    [Email] NCHAR(80) NOT NULL, 
    [Telefone] NCHAR(15) NOT NULL, 
    [Cliente_Id] INT NOT NULL, 
    CONSTRAINT [FK_TbCondutor_TbCliente] FOREIGN KEY (Cliente_Id) REFERENCES [TbCliente]([Id])
)
