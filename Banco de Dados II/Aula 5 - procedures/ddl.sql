/* Banco de Dados dbpro 
-- Creditos: Flávia Bertoni e Raphael Magalhães
*/
DROP DATABASE IF EXISTS db;
CREATE DATABASE IF NOT EXISTS db;
use db;

-- Table: cliente
CREATE TABLE IF NOT EXISTS db.cliente (
    id_cliente INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
    nome_cliente VARCHAR(50) NOT NULL,
    cpf_cliente CHAR(14) NOT NULL,
    endereco_cliente VARCHAR(100) NULL DEFAULT 'Endereço não cadastrado',
    PRIMARY KEY (id_cliente)
)  ENGINE=InnoDB;

-- Table: vendedor
CREATE TABLE IF NOT EXISTS db.vendedor (
    id_vendedor INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
    nome_vendedor VARCHAR(50) NOT NULL,
    cpf_vendedor CHAR(14) NOT NULL,
    endereco_vendedor VARCHAR(100) NULL DEFAULT 'Endereço não cadastrado',
    PRIMARY KEY (id_vendedor)
)  ENGINE=InnoDB;

-- Table: fornecedor
CREATE TABLE IF NOT EXISTS db.fornecedor (
    id_fornecedor INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
    cnpj_fornecedor VARCHAR(45),
    nome_fornecedor VARCHAR(50),
    endereco_fornecedor VARCHAR(100),
    contato_fornecedor VARCHAR(15),
    PRIMARY KEY (id_fornecedor)
)  ENGINE=InnoDB;

-- Table: produto
CREATE TABLE IF NOT EXISTS db.produto (
    id_produto INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
    id_grupo_produto INT(10) UNSIGNED NOT NULL,
    nome_produto VARCHAR(50) NOT NULL,
    codigo_barra_produto CHAR(13) DEFAULT 'Não possui',
    preco_custo_produto DOUBLE,
    preco_venda_produto DOUBLE NOT NULL,
    estoque_produto INT DEFAULT 0,
    PRIMARY KEY (id_produto)
)  ENGINE=InnoDB;

-- Table: venda (referente à saída de produtos)
CREATE TABLE IF NOT EXISTS db.venda (
    id_venda INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
    id_cliente_venda INT(10) UNSIGNED NOT NULL,
    id_vendedor_venda INT(10) UNSIGNED NOT NULL,
    data_orcamento_venda CHAR(10),
    status_venda CHAR(1) DEFAULT 'E',
    PRIMARY KEY (id_venda),
    FOREIGN KEY (id_cliente_venda)
        REFERENCES db.cliente (id_cliente),
    FOREIGN KEY (id_vendedor_venda)
        REFERENCES db.vendedor (id_vendedor)
)  ENGINE=InnoDB;

-- Table: compra (referente à entrada de produtos)
CREATE TABLE IF NOT EXISTS db.compra (
    id_compra INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
    data_compra CHAR(10) NULL,
    nota_fiscal_compra VARCHAR(45) NULL,
    id_fornecedor_compra INT(10) UNSIGNED NOT NULL,
    PRIMARY KEY (id_compra),
    FOREIGN KEY (id_fornecedor_compra)
        REFERENCES db.fornecedor (id_fornecedor)
)  ENGINE=InnoDB;

-- Table: saida (venda_has_produto)
CREATE TABLE IF NOT EXISTS db.saida (
    id_venda_saida INT(10) UNSIGNED NOT NULL,
    id_produto_saida INT(10) UNSIGNED NOT NULL,
    quantidade_saida INT NOT NULL,
    PRIMARY KEY (id_venda_saida, id_produto_saida),
    FOREIGN KEY (id_venda_saida)
        REFERENCES db.venda (id_venda),
	FOREIGN KEY (id_produto_saida)
        REFERENCES db.produto (id_produto)
)  ENGINE=InnoDB;

-- Table: entrada (compra_has_produto)
CREATE TABLE IF NOT EXISTS db.entrada (
    id_compra_entrada INT(10) UNSIGNED NOT NULL,
    id_produto_entrada INT(10) UNSIGNED NOT NULL,
    quantidade_entrada INT NOT NULL,
    PRIMARY KEY (id_compra_entrada , id_produto_entrada),
    FOREIGN KEY (id_compra_entrada)
        REFERENCES db.compra (id_compra),
	FOREIGN KEY (id_produto_entrada)
        REFERENCES db.produto (id_produto)
)  ENGINE=InnoDB;
/*==========================================================================*/
