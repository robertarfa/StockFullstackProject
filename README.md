## WIP

## Sistema de Gerenciamento de Pedidos

Este projeto implementa um sistema de gerenciamento de Pedidos utilizando uma arquitetura Fullstack com foco em boas práticas de desenvolvimento, como Domain-Driven Design (DDD), Repository Pattern e Use Cases.

### Tecnologias Utilizadas:

**Frontend:**

- **TypeScript:** Linguagem principal para o desenvolvimento do Frontend, proporcionando tipagem estática e melhor organização do código.
- **[React]:** Framework/Biblioteca escolhido para estruturar a aplicação Frontend e gerenciar componentes da interface.
- **[Biblioteca de gerenciamento de estado]:** Redux.
- **[Biblioteca de estilos]:** SASS.
- **[Ferramenta de build]:** Vite.
- **Vitest:** Framework de testes unitários rápido e conciso para projetos que utilizam Vite.

**Backend:**

- **C#:** Linguagem principal para o desenvolvimento do Backend, aproveitando sua performance e robustez.
- **.NET Core:** Framework utilizado para criar APIs RESTful que servirão os dados para o Frontend.
- **Entity Framework Core:** ORM utilizado para interagir com o banco de dados.
- **[Banco de Dados (PostgreSQL)]:** Sistema de gerenciamento de banco de dados escolhido para armazenar os dados da aplicação.
- **xUnit:** Framework de testes unitários para .NET, utilizado para testar a lógica do Backend.

**Arquitetura:**

- **Domain-Driven Design (DDD):** A aplicação é estruturada em torno do domínio do problema, com entidades, Value Objects e Agregados representando os conceitos chave do negócio.
- **Repository Pattern:** Repositórios são utilizados para abstrair o acesso a dados, permitindo que a lógica de negócio opere independentemente da implementação específica do banco de dados.
- **Use Cases:** Casos de uso são implementados para definir as operações que o sistema pode realizar, encapsulando a lógica de negócio e orquestrando a interação com os repositórios.
- Data Transfer Objects (DTOs): DTOs são utilizados para transferir dados entre as camadas da aplicação, desacoplando o domínio da apresentação e da persistência.

### Como executar o projeto:

1. Clone o repositório: `git clone https://github.com/robertarfa/PizzariaFullstack.git`
2. Navegue até a pasta backend: `cd Server`
3. Configure o banco de dados e a string de conexão no arquivo `appsettings.json`.
4. Execute o projeto backend: `dotnet run`.
5. Abra um novo terminal e navegue até a pasta frontend: `cd Client`.
6. Instale as dependências: `npm install`.
7. Execute o projeto frontend: `npm start`.

### Como executar os testes:

**Frontend (Vitest):**

1. Navegue até a pasta frontend: `cd Client`
2. Execute os testes: `npm run test`

**Backend (xUnit):**

1. Navegue até a pasta backend/tests: `cd Server`
2. Execute os testes: `dotnet test`

## Próximos Passos:

- Implementar a autenticação de usuários.
- Criar testes de integração para garantir a qualidade do código.
- Implementar logging para facilitar a identificação e resolução de problemas.
- Configurar um servidor web para hospedar a aplicação em produção.

## Contribuindo:

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests.

## Licença:

Este projeto está licenciado sob a licença [Nome da Licença].
