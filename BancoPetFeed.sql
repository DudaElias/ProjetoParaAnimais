create table Cliente(
id int identity(1,1) primary key,
nome varchar(50) not null,
email varchar(100) not null,
cpf varchar(14) not null,
senha varchar(50) not null,
telefone varchar(14) not null,
)
create table Pedido(
id int identity(1,1) primary key,
dataPedido date not null,
codCliente int not null,
constraint fkCodCliente foreign key (codCliente) references Cliente(id),
codPedido int not null,
constraint fxCodPedido foreign key(codPedido) references ItemPedido(id),
dataEntrega date not null,
precoEntrega money not null,
endereco varchar(100) not null
)


create table Loja(
id int identity(1,1) primary key,
nome varchar(30) not null,
email varchar(100) not null,
cpfDono varchar(14) not null,
rgDono varchar(12) not null,
orgaoEmissor varchar(5) not null
)

create table Filtro(
id int identity(1,1) primary key,
animal varchar(50) not null
)

create table Produto(
id int identity(1,1) primary key,
codLoja int not null,
constraint fkCodLoja foreign key (codLoja) references Loja(id),
codFiltro int not null
constraint fkCodFiltro foreign key(codFiltro) references Filtro(id),
imagem varchar(max) not null,
nome varchar(70) not null,
descricao varchar(max) not null,
preco money not null
)

create table ItemPedido(
id int identity(1,1) primary key,
codProduto int not null,
constraint fkCodProduto foreign key(codProduto) references Produto(id),
quantidade int not null
)

