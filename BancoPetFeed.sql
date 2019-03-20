create table Cliente(
codCliente int primary key,
nome varchar(50) not null,
email varchar(100) not null,
cpf varchar(14) not null,
senha varchar(50) not null,
telefone varchar(14) not null,
)

create table Pedido(
codPedido int primary key,
dataPedido date not null,
codCliente int not null,
constraint fkCodCliente foreign key (codCliente) references Cliente(codCliente),
dataEntrega date not null,
codSedex int not null,
endereco varchar(100) not null
)

create table Loja(
codLoja int primary key,
nome varchar(30) not null,
email varchar(100) not null,
cpfDono varchar(14) not null,
rgDono varchar(12) not null,
orgaoEmissor varchar(5) not null
)

create table Filtro(
codFiltro int primary key,
animal varchar(50) not null
)

create table Produto(
codProduto int primary key,
codLoja int not null,
constraint fkCodLoja foreign key (codLoja) references Loja(codLoja),
codFiltro int not null
constraint fkCodFiltro foreign key(codFiltro) references Filtro(codFiltro),
nome varchar(70) not null,
descricao nText not null,
preco money not null
)

create table ItemPedido(
codItem int primary key,
codProduto int not null,
constraint fkCodProduto foreign key(codProduto) references Produto(codProduto),
quantidade int not null
)

