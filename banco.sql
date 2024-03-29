USE [master]
GO
/****** Object:  Database [PIZZARIA]    Script Date: 29/06/2019 13:26:22 ******/
CREATE DATABASE [PIZZARIA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PIZZARIA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\PIZZARIA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PIZZARIA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\PIZZARIA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PIZZARIA] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PIZZARIA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PIZZARIA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PIZZARIA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PIZZARIA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PIZZARIA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PIZZARIA] SET ARITHABORT OFF 
GO
ALTER DATABASE [PIZZARIA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PIZZARIA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PIZZARIA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PIZZARIA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PIZZARIA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PIZZARIA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PIZZARIA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PIZZARIA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PIZZARIA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PIZZARIA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PIZZARIA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PIZZARIA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PIZZARIA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PIZZARIA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PIZZARIA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PIZZARIA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PIZZARIA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PIZZARIA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PIZZARIA] SET  MULTI_USER 
GO
ALTER DATABASE [PIZZARIA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PIZZARIA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PIZZARIA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PIZZARIA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PIZZARIA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PIZZARIA] SET QUERY_STORE = OFF
GO
USE [PIZZARIA]
GO
/****** Object:  Table [dbo].[Atendimento]    Script Date: 29/06/2019 13:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atendimento](
	[idAtendimento] [int] IDENTITY(1,1) NOT NULL,
	[h_pagamento] [datetime] NULL,
	[vlr_total] [numeric](6, 2) NULL,
	[vlr_pago] [numeric](6, 2) NULL,
	[troco] [numeric](5, 2) NULL,
	[cliente_idCliente] [int] NULL,
	[finalizado] [bit] NULL,
 CONSTRAINT [PK_Atendimento] PRIMARY KEY CLUSTERED 
(
	[idAtendimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cidade]    Script Date: 29/06/2019 13:26:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cidade](
	[idCidade] [int] IDENTITY(1,1) NOT NULL,
	[nome_cid] [varchar](35) NULL,
	[idEstado] [int] NULL,
 CONSTRAINT [PK_Cidade] PRIMARY KEY CLUSTERED 
(
	[idCidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Classificacao]    Script Date: 29/06/2019 13:26:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classificacao](
	[idClassificacao] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NULL,
 CONSTRAINT [PK_Classificacao] PRIMARY KEY CLUSTERED 
(
	[idClassificacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 29/06/2019 13:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[CPF] [char](11) NOT NULL,
	[telefone] [char](11) NULL,
	[nome_cli] [varchar](40) NULL,
	[dt_nascimento] [date] NULL,
	[endereco] [varchar](80) NULL,
	[numero] [int] NULL,
	[complemento] [varchar](80) NULL,
	[bairro] [varchar](50) NULL,
	[CEP] [char](8) NULL,
	[Cidade_idCidade] [int] NULL,
 CONSTRAINT [PK_Cliente_1] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 29/06/2019 13:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[idEstado] [int] IDENTITY(1,1) NOT NULL,
	[UF] [nchar](2) NULL,
	[nome_est] [nvarchar](40) NULL,
 CONSTRAINT [PK_Estado_1] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesa]    Script Date: 29/06/2019 13:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesa](
	[idMesa] [int] IDENTITY(1,1) NOT NULL,
	[status] [bit] NULL,
	[qtdLugares] [int] NULL,
 CONSTRAINT [PK_Mesa] PRIMARY KEY CLUSTERED 
(
	[idMesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 29/06/2019 13:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[observacao] [varchar](200) NULL,
	[atend_idAtend] [int] NULL,
	[produto_idProduto] [int] NULL,
	[quantidade] [int] NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 29/06/2019 13:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[idProduto] [int] IDENTITY(1,1) NOT NULL,
	[preco] [numeric](5, 2) NULL,
	[descricao] [varchar](80) NULL,
	[Classificacao_idClassificacao] [int] NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[idProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rua]    Script Date: 29/06/2019 13:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rua](
	[idRua] [int] IDENTITY(1,1) NOT NULL,
	[CEP] [nchar](8) NULL,
	[nome_rua] [varchar](50) NULL,
	[bairro] [varchar](40) NULL,
 CONSTRAINT [PK_Rua] PRIMARY KEY CLUSTERED 
(
	[idRua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Atendimento] ON 

INSERT [dbo].[Atendimento] ([idAtendimento], [h_pagamento], [vlr_total], [vlr_pago], [troco], [cliente_idCliente], [finalizado]) VALUES (1, CAST(N'2019-06-17T09:38:00.000' AS DateTime), CAST(58.00 AS Numeric(6, 2)), CAST(60.00 AS Numeric(6, 2)), CAST(2.00 AS Numeric(5, 2)), 2, 0)
INSERT [dbo].[Atendimento] ([idAtendimento], [h_pagamento], [vlr_total], [vlr_pago], [troco], [cliente_idCliente], [finalizado]) VALUES (2, CAST(N'2019-06-17T09:41:00.000' AS DateTime), CAST(30.00 AS Numeric(6, 2)), CAST(30.00 AS Numeric(6, 2)), CAST(4.00 AS Numeric(5, 2)), 3, 0)
INSERT [dbo].[Atendimento] ([idAtendimento], [h_pagamento], [vlr_total], [vlr_pago], [troco], [cliente_idCliente], [finalizado]) VALUES (26, CAST(N'2000-01-01T00:00:00.000' AS DateTime), CAST(0.00 AS Numeric(6, 2)), CAST(0.00 AS Numeric(6, 2)), CAST(0.00 AS Numeric(5, 2)), 4, 0)
INSERT [dbo].[Atendimento] ([idAtendimento], [h_pagamento], [vlr_total], [vlr_pago], [troco], [cliente_idCliente], [finalizado]) VALUES (27, CAST(N'1900-01-01T00:00:00.000' AS DateTime), CAST(0.00 AS Numeric(6, 2)), CAST(0.00 AS Numeric(6, 2)), CAST(0.00 AS Numeric(5, 2)), 4, 0)
INSERT [dbo].[Atendimento] ([idAtendimento], [h_pagamento], [vlr_total], [vlr_pago], [troco], [cliente_idCliente], [finalizado]) VALUES (28, CAST(N'1900-01-01T00:00:00.000' AS DateTime), CAST(0.00 AS Numeric(6, 2)), CAST(0.00 AS Numeric(6, 2)), CAST(0.00 AS Numeric(5, 2)), 3, 0)
INSERT [dbo].[Atendimento] ([idAtendimento], [h_pagamento], [vlr_total], [vlr_pago], [troco], [cliente_idCliente], [finalizado]) VALUES (29, CAST(N'1900-01-01T00:00:00.000' AS DateTime), CAST(0.00 AS Numeric(6, 2)), CAST(0.00 AS Numeric(6, 2)), CAST(0.00 AS Numeric(5, 2)), 3, 0)
SET IDENTITY_INSERT [dbo].[Atendimento] OFF
SET IDENTITY_INSERT [dbo].[Cidade] ON 

INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (1, N'São Paulo', 1)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (2, N'Cândido Mota', 1)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (15, N'Londrina', 3)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (17, N'Duque de Caxias', 2)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (20, N'Bandeirantes', 3)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (21, N'Belo Horizonte', 16)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (22, N'Curitiba', 3)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (24, N'Presidente Prudente', 1)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (26, N'Rio de Janeiro', 2)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (27, N'Porto Alegre', 22)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (28, N'Palmital', 1)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (29, N'Assis', 1)
SET IDENTITY_INSERT [dbo].[Cidade] OFF
SET IDENTITY_INSERT [dbo].[Classificacao] ON 

INSERT [dbo].[Classificacao] ([idClassificacao], [nome]) VALUES (1, N'Pizza')
INSERT [dbo].[Classificacao] ([idClassificacao], [nome]) VALUES (2, N'Pizza Gourmet')
INSERT [dbo].[Classificacao] ([idClassificacao], [nome]) VALUES (3, N'Pizza Doce')
INSERT [dbo].[Classificacao] ([idClassificacao], [nome]) VALUES (4, N'Aperitivo')
INSERT [dbo].[Classificacao] ([idClassificacao], [nome]) VALUES (5, N'Suco')
INSERT [dbo].[Classificacao] ([idClassificacao], [nome]) VALUES (6, N'Refrigerante')
INSERT [dbo].[Classificacao] ([idClassificacao], [nome]) VALUES (7, N'Cerveja')
SET IDENTITY_INSERT [dbo].[Classificacao] OFF
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([idCliente], [CPF], [telefone], [nome_cli], [dt_nascimento], [endereco], [numero], [complemento], [bairro], [CEP], [Cidade_idCidade]) VALUES (2, N'1234567810 ', N'1833511236 ', N'João Augusto Paião Bonifácio', CAST(N'1999-02-09' AS Date), N'Rosalina Candida Franco', 67, N'Casa', N'Jardim Bela Vista', N'19970000', 28)
INSERT [dbo].[Cliente] ([idCliente], [CPF], [telefone], [nome_cli], [dt_nascimento], [endereco], [numero], [complemento], [bairro], [CEP], [Cidade_idCidade]) VALUES (3, N'1087654321 ', N'1833514816 ', N'Bruno Luciano', CAST(N'2000-07-11' AS Date), N'Pedro Elias', 1, N'Fundos', N'São José', N'19970000', 28)
INSERT [dbo].[Cliente] ([idCliente], [CPF], [telefone], [nome_cli], [dt_nascimento], [endereco], [numero], [complemento], [bairro], [CEP], [Cidade_idCidade]) VALUES (4, N'6924116669 ', N'1840028922 ', N'Guilherme Coletinho', CAST(N'2000-12-25' AS Date), N'Casa do Chapel', 24, N'Casa', N'Jardim Centro', N'19696900', 2)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[Estado] ON 

INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (1, N'SP', N'São Paulo')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (2, N'RJ', N'Rio de Janeiro')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (3, N'PR', N'Paraná')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (4, N'AC', N'Acre')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (5, N'AL', N'Alagoas')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (6, N'AP', N'Amapá')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (7, N'AM', N'Amazonas')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (8, N'BA', N'Bahia')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (9, N'CE', N'Ceará')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (10, N'DF', N'Distrito Federal')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (11, N'ES', N'Espírito Santo')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (12, N'GO', N'Goiás')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (13, N'MA', N'Maranhão')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (14, N'MT', N'Mato Grosso')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (15, N'MS', N'Mato Grosso do Sul')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (16, N'MG', N'Minas Gerais')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (17, N'PA', N'Pará')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (18, N'PB', N'Paraíba')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (19, N'PE', N'Pernambuco')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (20, N'PI', N'Piauí')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (21, N'RN', N'Rio Grande do Norte')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (22, N'RS', N'Rio Grande do Sul')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (23, N'RO', N'Rondônia')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (24, N'RR', N'Roraima')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (25, N'SC', N'Santa Catarina')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (26, N'SE', N'Sergipe')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (27, N'TO', N'Tocantins')
SET IDENTITY_INSERT [dbo].[Estado] OFF
SET IDENTITY_INSERT [dbo].[Mesa] ON 

INSERT [dbo].[Mesa] ([idMesa], [status], [qtdLugares]) VALUES (1, 0, 6)
INSERT [dbo].[Mesa] ([idMesa], [status], [qtdLugares]) VALUES (2, 0, 4)
INSERT [dbo].[Mesa] ([idMesa], [status], [qtdLugares]) VALUES (3, 0, 2)
INSERT [dbo].[Mesa] ([idMesa], [status], [qtdLugares]) VALUES (4, 0, 4)
INSERT [dbo].[Mesa] ([idMesa], [status], [qtdLugares]) VALUES (5, 0, 4)
INSERT [dbo].[Mesa] ([idMesa], [status], [qtdLugares]) VALUES (6, 0, 4)
INSERT [dbo].[Mesa] ([idMesa], [status], [qtdLugares]) VALUES (7, 0, 8)
SET IDENTITY_INSERT [dbo].[Mesa] OFF
SET IDENTITY_INSERT [dbo].[Pedido] ON 

INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (1, N'Sem Azeitona', 1, 3, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (2, N' ', 2, 5, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (3, N' ', 1, 2, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (4, N'', 2, 4, 3)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (5, N'', 1, 7, 4)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (9, N'', 26, 5, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (14, N'', 26, 3, 4)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (19, N'', 26, 2, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (21, N'Sem chocolate', 26, 4, 2)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (28, N' ', 1, 2, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (30, N' ', 1, 7, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (45, N'', 0, 5, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (47, N'', 0, 1, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (49, N'', 0, 5, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (50, N'', 26, 6, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (53, N'', 2, 3, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (59, N'', 27, 5, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (60, N'', 26, 3, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (61, N'', 26, 5, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (63, N'', 26, 1, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (64, N'', 27, 6, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (65, N'', 27, 3, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (66, N'', 26, 5, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (67, N'', 26, 3, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (68, N'', 27, 5, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (70, N'', 2, 5, 1)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (71, N'', 2, 1, 8)
INSERT [dbo].[Pedido] ([id], [observacao], [atend_idAtend], [produto_idProduto], [quantidade]) VALUES (72, N'', 2, 7, 5)
SET IDENTITY_INSERT [dbo].[Pedido] OFF
SET IDENTITY_INSERT [dbo].[Produto] ON 

INSERT [dbo].[Produto] ([idProduto], [preco], [descricao], [Classificacao_idClassificacao]) VALUES (1, CAST(4.50 AS Numeric(5, 2)), N'Coca-Cola Lata 350ml', 6)
INSERT [dbo].[Produto] ([idProduto], [preco], [descricao], [Classificacao_idClassificacao]) VALUES (2, CAST(48.00 AS Numeric(5, 2)), N'Calabresa', 1)
INSERT [dbo].[Produto] ([idProduto], [preco], [descricao], [Classificacao_idClassificacao]) VALUES (3, CAST(58.00 AS Numeric(5, 2)), N'Mussarela de Búfala', 2)
INSERT [dbo].[Produto] ([idProduto], [preco], [descricao], [Classificacao_idClassificacao]) VALUES (4, CAST(51.00 AS Numeric(5, 2)), N'Brigadeiro', 3)
INSERT [dbo].[Produto] ([idProduto], [preco], [descricao], [Classificacao_idClassificacao]) VALUES (5, CAST(20.00 AS Numeric(5, 2)), N'Batata Frita', 4)
INSERT [dbo].[Produto] ([idProduto], [preco], [descricao], [Classificacao_idClassificacao]) VALUES (6, CAST(6.00 AS Numeric(5, 2)), N'Laranja', 5)
INSERT [dbo].[Produto] ([idProduto], [preco], [descricao], [Classificacao_idClassificacao]) VALUES (7, CAST(2.50 AS Numeric(5, 2)), N'Skoll Lata 300ml', 7)
INSERT [dbo].[Produto] ([idProduto], [preco], [descricao], [Classificacao_idClassificacao]) VALUES (8, CAST(45.00 AS Numeric(5, 2)), N'Mussarela', 1)
INSERT [dbo].[Produto] ([idProduto], [preco], [descricao], [Classificacao_idClassificacao]) VALUES (9, CAST(52.00 AS Numeric(5, 2)), N'Frango com Catupiry', 1)
INSERT [dbo].[Produto] ([idProduto], [preco], [descricao], [Classificacao_idClassificacao]) VALUES (10, CAST(4.00 AS Numeric(5, 2)), N'Pepsi Lata 350ml', 6)
SET IDENTITY_INSERT [dbo].[Produto] OFF
ALTER TABLE [dbo].[Atendimento]  WITH CHECK ADD  CONSTRAINT [FK_Atendimento_Cliente] FOREIGN KEY([cliente_idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Atendimento] CHECK CONSTRAINT [FK_Atendimento_Cliente]
GO
ALTER TABLE [dbo].[Cidade]  WITH CHECK ADD  CONSTRAINT [FK_Cidade_Estado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[Estado] ([idEstado])
GO
ALTER TABLE [dbo].[Cidade] CHECK CONSTRAINT [FK_Cidade_Estado]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Cidade] FOREIGN KEY([Cidade_idCidade])
REFERENCES [dbo].[Cidade] ([idCidade])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Cidade]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [Classificacao_idClassificacao] FOREIGN KEY([produto_idProduto])
REFERENCES [dbo].[Classificacao] ([idClassificacao])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [Classificacao_idClassificacao]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Classificacao] FOREIGN KEY([Classificacao_idClassificacao])
REFERENCES [dbo].[Classificacao] ([idClassificacao])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Classificacao]
GO
USE [master]
GO
ALTER DATABASE [PIZZARIA] SET  READ_WRITE 
GO
