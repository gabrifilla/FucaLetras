CREATE DATABASE fucaletrasWeb;
USE fucaletrasWeb;

CREATE TABLE musica
(
id_musica int identity(1,1) PRIMARY KEY NOT NULL,
nome_musica varchar(150) NOT NULL,
duracao_musica int NOT NULL,
letra_musica text NOT NULL,
caminho varchar(300) NOT NULL,
CONSTRAINT UK_Nome_e_Caminho UNIQUE(nome_musica,caminho)
);

CREATE TABLE album
(
id_album int identity(1,1) PRIMARY KEY NOT NULL,
nome_album varchar(150) NOT NULL
);

CREATE TABLE genero
(
id_genero int identity(1,1) PRIMARY KEY NOT NULL,
nome_genero varchar(50) NOT NULL
);

CREATE TABLE banda
(
id_banda int identity(1,1) PRIMARY KEY NOT NULL,
nome_banda varchar(150) NOT NULL
);

CREATE TABLE musica_album
(
id_musica_banda int identity(1,1) PRIMARY KEY NOT NULL,
id_musica int NOT NULL FOREIGN KEY REFERENCES musica(id_musica) ,
id_album int NOT NULL FOREIGN KEY REFERENCES album(id_album)
);

CREATE TABLE musica_genero
(
id_musica_genero int identity(1,1) PRIMARY KEY NOT NULL,
id_musica int NOT NULL FOREIGN KEY REFERENCES musica(id_musica),
id_genero int NOT NULL FOREIGN KEY REFERENCES genero(id_genero)

);

CREATE TABLE album_genero
(
id_album_genero int identity(1,1) PRIMARY KEY NOT NULL,
id_genero int NOT NULL FOREIGN KEY REFERENCES genero(id_genero),
id_album int NOT NULL FOREIGN KEY REFERENCES album(id_album)

);

CREATE TABLE banda_genero
(
id_banda_genero int identity(1,1) PRIMARY KEY NOT NULL,
id_banda int NOT NULL FOREIGN KEY REFERENCES banda(id_banda),
id_genero int NOT NULL FOREIGN KEY REFERENCES genero(id_genero)
);

CREATE TABLE album_banda
(
id_album_banda int identity(1,1) PRIMARY KEY NOT NULL,
id_album int NOT NULL FOREIGN KEY REFERENCES album(id_album),
id_banda int NOT NULL FOREIGN KEY REFERENCES banda(id_banda)
);

CREATE TABLE musica_banda
(
id_musica_banda int identity(1,1) PRIMARY KEY NOT NULL,
id_musica int NOT NULL FOREIGN KEY REFERENCES musica(id_musica),
id_banda int NOT NULL FOREIGN KEY REFERENCES banda(id_banda)
);

CREATE PROCEDURE BuscarLetra
@caminho varchar(300)
AS
BEGIN
SELECT letra_musica FROM musica 
WHERE caminho = @caminho
END


Insert Into musica VALUES ('This is War',3,'A Warning to the people
The Good and the Evil

This Is War

To the Soldier 
The Civilian 
The Martyr
The Victim

This is War

Its the moment of truth and the moment to lie
The moment to live and the moment to die
The moment to fight, the moment to fight
To fight, to fight, to fight

To the right 
To the left 
We will fight to the death
To the Edge of the Earth
Its a Brave New World 
From the last to the first

To the right
To the left
We will fight to the death
To the Edge of the Earth
Its a Brave New World 
Its a Brave New World 

A warning to the prophet
The liar
The honest

This is War

To the leader
The pariah
The victim
The messiah

This is war

Its the moment of truth and the moment to lie
The moment to live and the moment to die
The moment to fight, the moment to fight, 
To fight, to fight, to fight

To the right
To the left
We will fight to the death
To the Edge of the Earth
Its a Brave New World 
From the last to the first

To the right
To the left
We will fight to the death
To the Edge of the Earth 
Its a Brave New World
Its a Brave New World
Its a Brave New World

I do believe in the light
Raise your hands up to the sky
Fight is done
The war is won
Lift your hands toward the sun
Toward the sun
Toward the sun
Toward the sun
The war is won

Fight, fight, fight, fight, fight! (choir)

To the right
To the left
We will fight to the death
To the Edge of the Earth
Its a Brave New World 
From the last to the first

To the right
To the left
We will fight to the death
To the Edge of the Earth 
Its a Brave New World 

Its a Brave New World 
Its A Brave New World

A Brave New World
The war is won,
The war is won,
A Brave New World

I believe in nothing, not the end and not the start
I believe in nothing, not the earth and not the stars
I believe in nothing, not the day and not the dark
I believe in nothing, but the beating of our hearts
I believe in nothing, 100 suns until we part
I believe in nothing, not in satan, not in god
I believe in nothing, not in peace and not in war
I believe in nothing, but the truth of who we are', '');

Insert Into musica VALUES ('Kings and Queens',3,'Into the night
Desperate and broken
The sound of a fight
Father has spoken

We were the Kings and Queens of promise
We were the victims of ourselves
Maybe the Children of a Lesser God
Between Heaven and Hell
Heaven and Hell

Into your lives
Hopeless and Taken
We stole our new lives
Through blood and pain
In defense of our dreams
In defense of our dreams

We were the Kings and Queens of promise
We were the victims of ourselves
Maybe the Children of a Lesser God
Between Heaven and Hell
Heaven and Hell

The age of man is over
A darkness comes and all
These lessons that weve learned here
Have only just begun

We were the Kings and Queens of promise
We were the victims of ourselves
Maybe the Children of a Lesser God
Between Heaven and Hell

We are the Kings
We are the Queens
We are the Kings
We are the Queens', '');

Insert Into musica VALUES ('Era um Garoto que Como eu...',3,'Era um garoto
Que como eu
Amava os Beatles
E os Rolling Stones..

Girava o mundo
Sempre a cantar
As coisas lindas
Da América...

Não era belo
Mas mesmo assim
Havia mil garotas afim
Cantava Help
And Ticket To Ride
Oh Lady Jane, Yesterday...

Cantava viva, à liberdade
Mas uma carta sem esperar
Da sua guitarra, o separou
Fora chamado na América...

Stop! Com Rolling Stones
Stop! Com Beatles songs
Mandado foi ao Vietnã
Lutar com vietcongs...

Ratá-tá tá tá...
Tatá-rá tá tá...
Ratá-tá tá tá...
Tatá-rá tá tá...
Ratá-tá tá tá...
Tatá-rá tá tá...
Ratá-tá tá tá...

Era um garoto
Que como eu!
Amava os Beatles
E os Rolling Stones
Girava o mundo
Mas acabou!
Fazendo a guerra
No Vietnã...

Cabelos longos
Não usa mais
Nem toca a sua
Guitarra e sim
Um instrumento
Que sempre dá
A mesma nota
Ra-tá-tá-tá...

Não tem amigos
Nem vê garotas
Só gente morta
Caindo ao chão
Ao seu país
Não voltará
Pois está morto
No Vietnã...

Stop! Com Rolling Stones
Stop! Com Beatles songs
No peito um coração não há
Mas duas medalhas sim....

Ratá-tá tá tá...
Tatá-rá tá tá...
Ratá-tá tá tá...
Tatá-rá tá tá...
Ratá-tá tá tá...
Tatá-rá tá tá...
Ratá-tá tá tá...

Ra-tá-tá tá-tá ...
Ra-tá-tá tá-tá ...', '');

Insert Into musica VALUES ('Infinita Highway',3,'Você me faz correr demais 
Os riscos desta highway 
Você me faz correr atrás 
Do horizonte desta highway 
Ninguém por perto, silêncio no deserto, 
Deserta highway 
Estamos sós e nenhum de nós 
Sabe exatamente onde vai parar 

Mas não precisamos saber pra onde vamos 
Nós só precisamos ir 
Não queremos ter o que não temos 
Nós só queremos viver 
Sem motivos nem objetivos 
Nós estamos vivos e é tudo 
É sobretudo a lei 
Dessa infinita highway, highway

Escute garota, o vento canta uma canção 
Dessas que a gente nunca toca sem razão 
Então me diga, garota: "Será a estrada uma prisão?" 
Eu acho que sim, você finge que não 
Mas nem por isso ficaremos parados 
Com a cabeça nas nuvens e os pés no chão 
Tudo bem, garota, não adianta mesmo ser livre 
Se tanta gente vive sem ter como viver 

Estamos sós e nenhum de nós 
Sabe onde vai parar
Estamos vivos sem motivos 
Que motivos temos pra estar? 
Atrás de palavras escondidas 
Nas entre linhas do horizonte 
Desta highway, 
Silenciosa highway, 
Infinita highway. 

"Eu vejo um horizonte trêmulo 
Tenho os olhos úmidos" 
"Eu posso estar completamente enganado 
Posso estar correndo pro lado errado" 
Mas "A dúvida é o preço da pureza" 
E é inútil ter certeza 
Eu vejo as placas dizendo "Não corra" 
"Não morra", "Não fume" 
"Eu vejo as placas cortando o horizonte 
Elas parecem facas de dois gumes" 

Minha vida é tao confusa quanto a América Central 
Por isso não me acuse de ser irracional 
Escute garota, façamos um trato: 
Você desliga o telefone se eu ficar um pé no saco

Cento e dez 
Cento e vinte 
Cento e sessenta 
Só pra ver até quando 
O motor aguenta
Na boca, em vez de um beijo,
Um chiclet de menta
E a sombra de um sorriso que eu deixei 
Numa das curvas da highway', '');

Insert Into musica VALUES('Sunrise',3,'Full of despair inside a darkness
Self conscious and scared, held prisoner of war
Running out of air, buried in a sadness
Want a way out of this paralyzing world
And the sound of the cries when a familys loved one dies
It echoes through a vacant room 
where a young soul still resides

When the night is cold and you feel like no-one knows
what its like to be the only one buried in this hole
You can make it to the sunrise
(Woah. Woah. Woah)
You can make it to the sunrise
(Woah. Woah. Woah.)

Searching for a way to escape the madness
A dire need for change as we fight for better days
The hurt and the pain cut deep like a razor blade
Holding in a cry for love, abandoned and afraid

When the night is cold and you feel like no-one knows
what its like to be the only one buried in this hole
You can make it to the sunrise
(Woah. Woah. Woah)
You can make it to the sunrise
(Woah. Woah. Woah.)

I wont go to my grave until a difference is made
I wont go to my grave until a difference is made
(Until a difference is made)

When the night is cold and you feel like no-one knows
what its like to be the only one buried in this hole
You can make it to the sunrise
(Woah. Woah. Woah)
You can make it to the sunrise
(Woah. Woah. Woah.)

I wont go to my grave until a difference is made
(Until the difference is made)
Until the difference is made

(From time to time, there arise among human beings
people, who seem to exude love, 
as naturally as the sun gives out heat.)', '')