# Resolu-o-Desafio-Est-gio-Tegra
Resolução Desafio Estágio Tegra

Diferenciais utilizados:
*Banco de Dados MySQL.
*Filtro de pesquisa : Adicionado Filtro por "Autor".
* Tratamento de erros utilizando método Try / Catch.

-> Conexão MySQL = ("server=localhost;port=3306;User Id=root;database=bd_livraria; password=proview7")

-> Código tabela MySQL :
create database bd_livraria;

use bd_livraria;

create table tb_livros(
ID int not null primary key,
titulo varchar(110) not null,    
autor varchar(50) not null,
valor decimal(5,2) not null,
qtd int not null);
    
// Software de uma livraria, divido em duas etapas :
1º - Loja de livros, onde é possivel escolher a quantidade de livros para venda,mostrando o valor em um "carrinho de compras".
2º - Parte Administrativa, onde é possivel buscar, cadastrar, alterar e apagar as informações de um livro, com autor, titulo, quantidadee preço.
Obrigado //
      
