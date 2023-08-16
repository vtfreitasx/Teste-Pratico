# Documentação da API de Decomposição de Números

Bem-vindo à documentação da API de decomposição de números. Esta API permite a decomposição de números inteiros em seus divisores e divisores primos correspondentes.

**Acesse a API: [URL da API](http://localhost:5000)**

## Instruções de Configuração

Antes de começar, siga estas etapas para configurar seu ambiente de desenvolvimento:

1. Instale o .NET Core SDK: [Download do .NET Core](https://dotnet.microsoft.com/download)
2. Clone o repositório do projeto: `git clone <URL do repositório>`
3. Abra um terminal na pasta do projeto: `cd api`
4. Execute o projeto: `dotnet run`

## Instalação de Dependências

As seguintes dependências são necessárias para executar o projeto:

- Swashbuckle.AspNetCore: Biblioteca para geração de documentação Swagger.

Para instalar as dependências, execute o seguinte comando:

```bash
dotnet add package Swashbuckle.AspNetCore

## Exemplos de Uso

### Exemplo 1: Decomposição do Número 30

1. Faça uma solicitação GET para o endpoint `GET /api/decomposicao/30`.
2. A API retornará a decomposição do número 30 em seus divisores e divisores primos correspondentes.

## Tratamento de Erros

A API pode retornar os seguintes códigos de status:

- 200 OK: A solicitação foi bem-sucedida e os dados foram retornados.
- 400 Bad Request: A solicitação é inválida ou não possui parâmetros válidos.
- 500 Internal Server Error: Ocorreu um erro interno no servidor.

## Recursos Adicionais

- [Documentação do .NET Core](https://docs.microsoft.com/dotnet/)
- [Documentação do Swagger](https://swagger.io/docs/)

