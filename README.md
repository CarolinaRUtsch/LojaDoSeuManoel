# Loja do Seu Manoel API

Este projeto � uma API RESTful para a "Loja do Seu Manoel", desenvolvida em ASP.NET Core. A API permite gerenciar pedidos, produtos e opera��es de autentica��o, sendo ideal para lojas que precisam de uma solu��o simples e pr�tica para seu sistema de vendas.

## Funcionalidades

- **CRUD de Produtos**: Permite criar, ler, atualizar e deletar produtos da loja.
- **Gest�o de Pedidos**: Possibilita criar e gerenciar pedidos feitos na loja.
- **Suporte ao Swagger**: Documenta��o autom�tica da API para facilitar o uso e desenvolvimento.
- **CORS Configurado**: A API est� configurada para permitir requisi��es de diferentes origens.

## Tecnologias Utilizadas

- **.NET 6**: Framework principal para o desenvolvimento da API.
- **ASP.NET Core**: Utilizado para criar os servi�os web e endpoints da API.
- **Swagger (Swashbuckle)**: Para documenta��o e teste dos endpoints.

## Como Executar o Projeto

1. **Pr�-requisitos**:
   - [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) instalado.
   - Um editor de c�digo, como [Visual Studio Code](https://code.visualstudio.com/) ou [Visual Studio](https://visualstudio.microsoft.com/).

2. **Clone o Reposit�rio**:
   ```sh
   git clone https://github.com/CarolinaRUtsch/LojaDoSeuManoel
   cd loja-do-seu-manoel
   ```

3. **Restaurar Depend�ncias**:
   ```sh
   dotnet restore
   ```

4. **Executar a Aplica��o**:
   ```sh
   dotnet run
   ```

5. **Acessar a Documenta��o Swagger**:
   - Acesse `https://localhost:5001/swagger` no navegador para visualizar e testar os endpoints dispon�veis.

## Estrutura do Projeto

- **Controllers**: Cont�m os endpoints que exp�em a l�gica do neg�cio.
- **Models**: Classes que representam as entidades do sistema, como `Produto` e `Pedido`.
- **Services**: Cont�m a l�gica de autentica��o e manipula��o dos dados.
- **Program.cs**: Arquivo principal de inicializa��o do projeto, configurando servi�os e middlewares.
