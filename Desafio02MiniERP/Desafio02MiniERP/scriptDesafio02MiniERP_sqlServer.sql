CREATE DATABASE supermercado_db;

USE supermercado_db;

CREATE TABLE fornecedores (
id int IDENTITY PRIMARY KEY,
razao_social varchar(45) NOT NULL,
nome_fantasia varchar(45) NOT NULL,
cnpj varchar(18) NOT NULL
);

CREATE TABLE produtos (
id int IDENTITY PRIMARY KEY,
codigo_barra varchar(20) NOT NULL,
descricao varchar(45) NOT NULL,
marca varchar(45),
valor decimal(19,2) NOT NULL,
id_fornecedor int NOT NULL

FOREIGN KEY (id_fornecedor) REFERENCES fornecedores(id)
);

CREATE TABLE clientes (
id int IDENTITY PRIMARY KEY,
nome varchar(45) NOT NULL,
endereco varchar(90),
telefone varchar(15),
email varchar(45),
cpf varchar(14) NOT NULL

);


CREATE TABLE notas_fiscais (
id int IDENTITY PRIMARY KEY,
id_cliente int NOT NULL,
data_compra datetime NOT NULL,
total_pagar decimal(19,2) NOT NULL

FOREIGN KEY (id_cliente) REFERENCES clientes(id)
);

CREATE TABLE notas_produtos (
id int IDENTITY PRIMARY KEY,
id_nota_fiscal int NOT NULL,
id_produto int NOT NULL

FOREIGN KEY (id_nota_fiscal) REFERENCES notas_fiscais(id),
FOREIGN KEY (id_produto) REFERENCES produtos(id)
);
