# API RESTful de Tarefas (To-Do) em C#

> Este projeto representa minha primeira imersão no desenvolvimento backend com C# e o ecossistema .NET. É uma API RESTful completa para gerenciamento de tarefas (To-Do), construída com foco em boas práticas e nos conceitos mais modernos da plataforma.

## 🚀 Sobre o Projeto

O objetivo principal foi criar uma API funcional e bem estruturada, aplicando os princípios REST para manipulação de recursos. Além de ser um projeto prático, serviu como uma poderosa ferramenta de aprendizado para solidificar conceitos fundamentais de desenvolvimento de software.

## 🛠️ Tecnologias Utilizadas

* **C#** e **.NET 8**
* **ASP.NET Core** com **Minimal APIs**
* **Entity Framework Core** para o acesso a dados (ORM)
* Banco de dados **SQLite**
* **Postman** para testes dos endpoints

## ✨ Features

* ✅ **Criar** uma nova tarefa.
* ✅ **Listar** todas as tarefas.
* ✅ **Atualizar** uma tarefa existente (suporte completo a `PUT` e `PATCH`).
* ✅ **Deletar** uma tarefa.
* ✅ Gerenciamento de **status** da tarefa (Não Iniciada, Em Andamento, Concluída, Cancelada).

## 📚 Endpoints da API

| Verbo  | Endpoint          | Descrição                                         |
| :----- | :---------------- | :------------------------------------------------ |
| `POST` | `/todo`           | Cria uma nova tarefa.                             |
| `GET`  | `/todo`           | Retorna a lista de todas as tarefas.              |
| `PUT`  | `/todo/{id}`      | Substitui completamente uma tarefa existente.     |
| `PATCH`| `/todo/{id}`      | Atualiza parcialmente uma ou mais propriedades.   |
| `DELETE`| `/todo/{id}`      | Deleta uma tarefa específica.                     |

## 🏁 Como Rodar o Projeto

Siga os passos abaixo para executar o projeto localmente.

```bash
# 1. Clone o repositório
git clone [COLE A URL HTTPS DO SEU REPOSITÓRIO AQUI]

# 2. Navegue até a pasta do projeto
cd [NOME-DA-PASTA-DO-PROJETO]

# 3. Restaure as dependências do .NET
dotnet restore

# 4. Aplique as migrations para criar o banco de dados SQLite
dotnet ef database update

# 5. Execute a aplicação
dotnet run
```
A API estará rodando em `http://localhost:5122` (ou a porta informada no seu terminal). 
Use uma ferramenta como o **Postman** para testar os endpoints.

## 🧠 Principais Aprendizados

Como minha primeira experiência com C#, este projeto foi uma curva de aprendizado íngreme e gratificante. Os principais conceitos que pude absorver e aplicar foram:

* **Design de APIs RESTful:** Estruturação correta de rotas e uso semântico dos verbos HTTP.
* **Minimal APIs:** Uma abordagem moderna e enxuta para a criação de APIs em .NET.
* **Injeção de Dependência:** Configuração profissional do `DbContext`.
* **Programação Assíncrona:** Uso de `async/await` para operações de I/O eficientes.
* **Mapeamento Objeto-Relacional com EF Core:** Abstração da camada de dados e uso de `Migrations` para gerenciar o schema do banco.
* **Segurança de Tipos:** A grande vantagem de usar `Enums` para o campo de status em vez de strings.
* **Controle de Versão:** O ciclo completo de trabalho com Git e GitHub.
