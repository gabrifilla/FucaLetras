CREATE DATABASE fucaletrasbd;
USE fucaletrasbd;

CREATE TABLE album(
	id_album int IDENTITY(1,1) NOT NULL,
	nome_album varchar(200),
PRIMARY KEY CLUSTERED 
(
	id_album ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE album_banda(
	id_album_banda int IDENTITY(1,1) NOT NULL,
	id_album int NOT NULL,
	id_banda int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	id_album_banda ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE album_genero(
	id_album_genero int IDENTITY(1,1) NOT NULL,
	id_genero int NOT NULL,
	id_album int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	id_album_genero ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE banda(
	id_banda int IDENTITY(1,1) NOT NULL,
	nome_banda varchar(200),
PRIMARY KEY CLUSTERED 
(
	id_banda ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE banda_genero(
	id_banda_genero int IDENTITY(1,1) NOT NULL,
	id_banda int NOT NULL,
	id_genero int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	id_banda_genero ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE genero(
	id_genero int IDENTITY(1,1) NOT NULL,
	nome_genero varchar(20),
PRIMARY KEY CLUSTERED 
(
	id_genero ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE musica(
	id_musica int IDENTITY(1,1) NOT NULL,
	nome_musica varchar(200),
	duracao_musica int,
	letra_musica text,
	caminho varchar(300) NOT NULL,
	constraint UK_Musica_Caminho_e_Nome UNIQUE (nome_musica,caminho),
PRIMARY KEY CLUSTERED 
(
	id_musica ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE musica_album(
	id_musica_banda int IDENTITY(1,1) NOT NULL,
	id_musica int NOT NULL,
	id_album int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	id_musica_banda ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE musica_banda(
	id_musica_banda int IDENTITY(1,1) NOT NULL,
	id_musica int NOT NULL,
	id_banda int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	id_musica_banda ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE musica_genero(
	id_musica_genero int IDENTITY(1,1) NOT NULL,
	id_musica int NOT NULL,
	id_genero int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	id_musica_genero ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE musica_playlist(
	id_musica_playlist int IDENTITY(1,1) NOT NULL,
	id_musica int NULL,
	id_playlist int NULL,
PRIMARY KEY CLUSTERED 
(
	id_musica_playlist ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE playlist(
	id_playlist int IDENTITY(1,1) NOT NULL,
	nome_playlist varchar(200),
PRIMARY KEY CLUSTERED 
(
	id_playlist ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE PROCEDURE insertMusica

@nome varchar(50) ,
@duracao int,
@letra text,
@nome_banda varchar(50),
@nome_genero varchar(50),
@caminho varchar(300),
@nome_album varchar(200)

AS
BEGIN

DECLARE		@ErrorMessage   VARCHAR(2000)
          , @ErrorSeverity  TINYINT
          , @ErrorState     TINYINT

BEGIN TRY
Insert into musica (nome_musica, duracao_musica, letra_musica, caminho)
values (@nome, @duracao, @letra, @caminho)

Insert into banda (nome_banda)
values(@nome_banda)

Insert into genero(nome_genero)
values(@nome_genero)

Insert into album(nome_album)
values(@nome_album)

Select @@IDENTITY AS retorno;

  END TRY

BEGIN CATCH
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
        SET @ErrorState    = ERROR_STATE()
		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END


CREATE PROCEDURE [dbo].[UpdateLetra]
@letra text,
@caminho varchar(300)
AS
BEGIN

UPDATE musica
   SET letra_musica = @letra
 WHERE caminho = @caminho

END

drop procedure UpdateMusica;
CREATE PROCEDURE [dbo].[UpdateMusica]
@nome varchar(200),
@caminho varchar(300),
@id int,
@nome_banda varchar(200),
@nome_genero varchar(20),
@nome_album varchar(200)
AS
BEGIN
UPDATE musica
   SET nome_musica = @nome
 WHERE caminho = @caminho

 UPDATE B 
   SET nome_banda = @nome_banda
   FROM banda AS B
   INNER JOIN musica_banda MB
   ON B.id_banda = MB.id_banda
 WHERE caminho = @caminho

  UPDATE G 
   SET nome_genero = @nome_genero
   FROM genero AS G
   INNER JOIN musica_genero MG
   ON G.id_genero = MG.id_genero
 WHERE caminho = @caminho

  UPDATE A 
   SET @nome_album = @nome_album
   FROM album AS A
   INNER JOIN musica_album MA
   ON A.id_album = MA.id_album
 WHERE caminho = @caminho

END

CREATE PROCEDURE insertMusNoLetra

@nome varchar(50) ,
@duracao int,
@nome_banda varchar(50),
@nome_genero varchar(50),
@caminho varchar(300),
@nome_album varchar(200)

AS
BEGIN

DECLARE		@ErrorMessage   VARCHAR(2000)
          , @ErrorSeverity  TINYINT
          , @ErrorState     TINYINT

BEGIN TRY
Insert into musica (nome_musica, duracao_musica, caminho)
values (@nome, @duracao, @caminho)

Insert into banda (nome_banda)
values(@nome_banda)

Insert into genero(nome_genero)
values(@nome_genero)

Insert into album(nome_album)
values(@nome_album)

Select @@IDENTITY AS retorno;

  END TRY

BEGIN CATCH
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
        SET @ErrorState    = ERROR_STATE()
		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END

CREATE PROCEDURE BuscarLetra
@caminho varchar(300)
AS
BEGIN
Select letra_musica from musica
WHERE caminho = @caminho
END