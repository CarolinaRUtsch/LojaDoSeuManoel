# Loja do Seu Manoel API

Este projeto é uma API RESTful para a "Loja do Seu Manoel", desenvolvida em ASP.NET Core. A API permite gerenciar pedidos, produtos e operações de autenticação, sendo ideal para lojas que precisam de uma solução simples e prática para seu sistema de vendas.

## Funcionalidades

- **CRUD de Produtos**: Permite criar, ler, atualizar e deletar produtos da loja.
- **Gestão de Pedidos**: Possibilita criar e gerenciar pedidos feitos na loja.
- **Suporte ao Swagger**: Documentação automática da API para facilitar o uso e desenvolvimento.
- **CORS Configurado**: A API está configurada para permitir requisições de diferentes origens.

## Tecnologias Utilizadas

- **.NET 6**: Framework principal para o desenvolvimento da API.
- **ASP.NET Core**: Utilizado para criar os serviços web e endpoints da API.
- **Swagger (Swashbuckle)**: Para documentação e teste dos endpoints.

## Como Executar o Projeto

1. **Pré-requisitos**:
   - [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) instalado.
   - Um editor de código, como [Visual Studio Code](https://code.visualstudio.com/) ou [Visual Studio](https://visualstudio.microsoft.com/).

2. **Clone o Repositório**:
   ```sh
   git clone https://github.com/CarolinaRUtsch/LojaDoSeuManoel
   cd loja-do-seu-manoel
   ```

3. **Restaurar Dependências**:
   ```sh
   dotnet restore
   ```

4. **Executar a Aplicação**:
   ```sh
   dotnet run
   ```

5. **Acessar a Documentação Swagger**:
   - Acesse `https://localhost:5001/swagger` no navegador para visualizar e testar os endpoints disponíveis.

## Estrutura do Projeto

- **Controllers**: Contêm os endpoints que expõem a lógica do negócio.
- **Models**: Classes que representam as entidades do sistema, como `Produto` e `Pedido`.
- **Services**: Contêm a lógica de autenticação e manipulação dos dados.
- **Program.cs**: Arquivo principal de inicialização do projeto, configurando serviços e middlewares.
