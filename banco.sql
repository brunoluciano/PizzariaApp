USE [master]
GO
/****** Object:  Database [PIZZARIA]    Script Date: 22/06/2019 15:33:50 ******/
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
/****** Object:  Table [dbo].[Atendimento]    Script Date: 22/06/2019 15:33:50 ******/
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
 CONSTRAINT [PK_Atendimento] PRIMARY KEY CLUSTERED 
(
	[idAtendimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cidade]    Script Date: 22/06/2019 15:33:51 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 22/06/2019 15:33:51 ******/
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
/****** Object:  Table [dbo].[Estado]    Script Date: 22/06/2019 15:33:51 ******/
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
/****** Object:  Table [dbo].[Mesa]    Script Date: 22/06/2019 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesa](
	[idMesa] [int] IDENTITY(1,1) NOT NULL,
	[status] [bit] NULL,
	[descricao] [nchar](10) NULL,
 CONSTRAINT [PK_Mesa] PRIMARY KEY CLUSTERED 
(
	[idMesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 22/06/2019 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[observacao] [varchar](200) NULL,
	[mesa_idMesa] [int] NULL,
	[atend_idAtend] [int] NULL,
	[produto_idProduto] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 22/06/2019 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[idProduto] [int] IDENTITY(1,1) NOT NULL,
	[classificacao] [varchar](30) NULL,
	[preco] [numeric](5, 2) NULL,
	[descricao] [varchar](80) NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[idProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rua]    Script Date: 22/06/2019 15:33:51 ******/
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

INSERT [dbo].[Atendimento] ([idAtendimento], [h_pagamento], [vlr_total], [vlr_pago], [troco], [cliente_idCliente]) VALUES (1, CAST(N'2019-06-17T09:38:00.000' AS DateTime), CAST(58.00 AS Numeric(6, 2)), CAST(60.00 AS Numeric(6, 2)), CAST(2.00 AS Numeric(5, 2)), 2)
INSERT [dbo].[Atendimento] ([idAtendimento], [h_pagamento], [vlr_total], [vlr_pago], [troco], [cliente_idCliente]) VALUES (2, CAST(N'2019-06-17T09:41:00.000' AS DateTime), CAST(26.00 AS Numeric(6, 2)), CAST(30.00 AS Numeric(6, 2)), CAST(4.00 AS Numeric(5, 2)), 3)
SET IDENTITY_INSERT [dbo].[Atendimento] OFF
SET IDENTITY_INSERT [dbo].[Cidade] ON 

INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (1, N'Palmital  ', 1)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (2, N'Assis     ', 1)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (8, N'São Paulo ', 1)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (14, N'Rio de Janeiro', 2)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (15, N'Londrina', 3)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (16, N'Curitiba', 3)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (17, N'Duque de Caxias', 2)
INSERT [dbo].[Cidade] ([idCidade], [nome_cid], [idEstado]) VALUES (18, N'', NULL)
SET IDENTITY_INSERT [dbo].[Cidade] OFF
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([idCliente], [CPF], [telefone], [nome_cli], [dt_nascimento], [endereco], [numero], [complemento], [bairro], [CEP], [Cidade_idCidade]) VALUES (2, N'1234567810 ', N'1833511236 ', N'João Augusto', CAST(N'1999-12-09' AS Date), N'Rosalina Candida Franco', 67, NULL, N'Jardim Bela Vista', N'19970000', 1)
INSERT [dbo].[Cliente] ([idCliente], [CPF], [telefone], [nome_cli], [dt_nascimento], [endereco], [numero], [complemento], [bairro], [CEP], [Cidade_idCidade]) VALUES (3, N'1087654321 ', N'1833514816 ', N'Bruno Luciano', CAST(N'2000-07-11' AS Date), N'Pedro Elias', 1, N'Fundos', N'São José', N'19970000', 1)
INSERT [dbo].[Cliente] ([idCliente], [CPF], [telefone], [nome_cli], [dt_nascimento], [endereco], [numero], [complemento], [bairro], [CEP], [Cidade_idCidade]) VALUES (4, N'6924116669 ', N'1840028922 ', N'Gaylherme Coletinho', CAST(N'1347-01-01' AS Date), N'Casa do Chapel', 24, NULL, N'Jardim Centro', N'19696900', 2)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[Estado] ON 

INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (1, N'SP', N'São Paulo')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (2, N'RJ', N'Rio de Janeiro')
INSERT [dbo].[Estado] ([idEstado], [UF], [nome_est]) VALUES (3, N'PR', N'Paraná')
SET IDENTITY_INSERT [dbo].[Estado] OFF
SET IDENTITY_INSERT [dbo].[Mesa] ON 

INSERT [dbo].[Mesa] ([idMesa], [status], [descricao]) VALUES (1, 0, N'6 lugares ')
INSERT [dbo].[Mesa] ([idMesa], [status], [descricao]) VALUES (2, 0, N'4 lugares ')
INSERT [dbo].[Mesa] ([idMesa], [status], [descricao]) VALUES (3, 0, N'2 lugares ')
INSERT [dbo].[Mesa] ([idMesa], [status], [descricao]) VALUES (4, 0, N'4 lugares ')
INSERT [dbo].[Mesa] ([idMesa], [status], [descricao]) VALUES (5, 0, N'4 lugares ')
INSERT [dbo].[Mesa] ([idMesa], [status], [descricao]) VALUES (6, 0, N'4 lugares ')
INSERT [dbo].[Mesa] ([idMesa], [status], [descricao]) VALUES (7, 0, N'8 lugares ')
SET IDENTITY_INSERT [dbo].[Mesa] OFF
INSERT [dbo].[Pedido] ([observacao], [mesa_idMesa], [atend_idAtend], [produto_idProduto]) VALUES (N'Sem Azeitona', 1, 1, 3)
SET IDENTITY_INSERT [dbo].[Produto] ON 

INSERT [dbo].[Produto] ([idProduto], [classificacao], [preco], [descricao]) VALUES (1, N'Bebida', CAST(4.50 AS Numeric(5, 2)), N'Coca-Cola Lata 350ml')
INSERT [dbo].[Produto] ([idProduto], [classificacao], [preco], [descricao]) VALUES (2, N'Pizza', CAST(48.00 AS Numeric(5, 2)), N'Calabreza')
INSERT [dbo].[Produto] ([idProduto], [classificacao], [preco], [descricao]) VALUES (3, N'Pizza gourmet', CAST(58.00 AS Numeric(5, 2)), N'Mussarela de Búfala')
INSERT [dbo].[Produto] ([idProduto], [classificacao], [preco], [descricao]) VALUES (4, N'Pizza Doce', CAST(51.00 AS Numeric(5, 2)), N'Brigadeiro')
INSERT [dbo].[Produto] ([idProduto], [classificacao], [preco], [descricao]) VALUES (5, N'Aperitivo', CAST(20.00 AS Numeric(5, 2)), N'Batata Frita')
INSERT [dbo].[Produto] ([idProduto], [classificacao], [preco], [descricao]) VALUES (6, N'Suco', CAST(6.00 AS Numeric(5, 2)), N'Laranja')
INSERT [dbo].[Produto] ([idProduto], [classificacao], [preco], [descricao]) VALUES (7, N'Bebida', NULL, N'Skoll')
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
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Produto] FOREIGN KEY([produto_idProduto])
REFERENCES [dbo].[Produto] ([idProduto])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Produto]
GO
USE [master]
GO
ALTER DATABASE [PIZZARIA] SET  READ_WRITE 
GO
