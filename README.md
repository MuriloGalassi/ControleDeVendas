# Sistema de Controle de Vendas

Este é um projeto simples de sistema de controle de vendas desenvolvido em **C#** para praticar conceitos de programação orientada a objetos (POO), manipulação de listas e interação com o usuário em um ambiente de console. Ele permite o cadastro de produtos, cadastro de clientes, realização de vendas e exibição de um relatório de vendas.

## Sumário
- [Sobre o Projeto](#sobre-o-projeto)
- [Funcionalidades](#funcionalidades)
- [Estrutura do Código](#estrutura-do-código)
- [Como Executar o Projeto](#como-executar-o-projeto)
- [Explicação das Principais Partes do Código](#explicação-das-principais-partes-do-código)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)

## Sobre o Projeto

Este projeto é uma aplicação de console onde o usuário pode:
1. Cadastrar produtos com nome, preço e quantidade em estoque.
2. Cadastrar clientes com nome e CPF.
3. Realizar vendas, associando clientes a produtos e controlando o estoque.
4. Visualizar um relatório de todas as vendas realizadas.

## Funcionalidades

1. **Cadastro de Produtos:** O usuário pode registrar novos produtos, incluindo nome, preço e quantidade em estoque.
2. **Cadastro de Clientes:** O usuário pode registrar novos clientes com nome e CPF (validado para ter exatamente 11 dígitos).
3. **Realizar Venda:** O usuário seleciona um cliente e produtos para realizar uma venda. A quantidade em estoque dos produtos é reduzida conforme a quantidade vendida.
4. **Relatório de Vendas:** Exibe uma lista de todas as vendas realizadas, incluindo cliente, produtos comprados e o valor total de cada venda.

## Estrutura do Código

O código é organizado em classes principais para representar cada entidade e operação do sistema:

- **Produto:** Representa um item com `Nome`, `Preço` e `QuantidadeEmEstoque`.
- **Cliente:** Representa um cliente com `Nome` e `CPF`.
- **ItemVenda:** Representa um produto incluído em uma venda, com `Produto` e `Quantidade`.
- **Venda:** Representa uma venda realizada, associando um `Cliente` a uma lista de `ItemVenda` (produtos vendidos e suas quantidades).
- **Program:** Contém o método `Main`, que controla o fluxo do programa e chama os métodos de acordo com a opção selecionada pelo usuário.

## Como Executar o Projeto

Para executar este projeto, você precisa ter o **.NET SDK** instalado em sua máquina. Siga os passos abaixo:

1. Clone o repositório:
   ```bash
   git clone https://github.com/MuriloGalassi/ControleDeVendas.git
