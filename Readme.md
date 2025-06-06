# Setup do Entity Framework Core com PostgreSQL

Este README contém os passos para configurar o Entity Framework Core com o banco de dados PostgreSQL no seu projeto ASP.NET Core.

---

## 1. Instalar os pacotes necessários
Execute os seguintes comandos no terminal na pasta do seu projeto:

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
```

---

## 2. Instalar a CLI do EF Core (se necessário)
Se o comando `dotnet ef` não estiver disponível, instale a ferramenta globalmente:

```bash
dotnet tool install --global dotnet-ef
```

Você pode testar executando:

```bash
dotnet ef
```

---

## 3. Criar a primeira migration

Execute na raiz do seu projeto:

```bash
dotnet ef migrations add 'NomeDaMigration'
```

---

## 4. Aplicar a migration no banco de dados

```bash
dotnet ef database update
```

---

## 5. Requisitos importantes

- O PostgreSQL deve estar instalado e em execução.
- A connection string deve estar configurada corretamente no `appsettings.json`. Exemplo:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=scoutingdb;Username=postgres;Password=123456"
}
```

- O banco `scoutingdb` será criado automaticamente se ainda não existir ao rodar `dotnet ef database update`.

---

Se tiver dúvidas ou quiser automatizar esses passos com um script, posso gerar um `.bat` ou `.sh` personalizado.
