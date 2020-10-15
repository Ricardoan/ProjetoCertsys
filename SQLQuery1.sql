

select * from dbo.Fornecedoress

 CREATE TABLE [dbo].[Fornecedoress](
	[Id] [int] IDENTITY NOT NULL,
	[Nome] [nvarchar] (255)  NULL,
	[CNPJ] [nvarchar] (255)  NULL,
	[Endereco] [nvarchar] (255)  NULL ,
	[Ativo] [nvarchar] (255)  NULL ,
	
 CONSTRAINT [PK_dbo.Fornecedoress] PRIMARY KEY ([Id]))

 CREATE TABLE [dbo].[Produtos](
	[Id] [int] IDENTITY NOT NULL,
	[Nome] [nvarchar] (255)  NULL,
	[Fornecedor] [nvarchar] (255)  NULL,
	[Quantidade] [int]   NULL ,
	
	
 CONSTRAINT [PK_dbo.Produtos] PRIMARY KEY ([Id]))