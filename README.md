<h1 align="center">🛒 AwesomeShop 🛍️</h1>

<h4 align="center">
  ♻️ Refatorações 🚀 🚧
</h4>

## 💻 Sobre o projeto
O AwesomeShop é uma API para implementar as funcionalidades necessárias para um sistema de e-commerce utilizando arquitetura de microsserviços e arquitetura limpa com CQRS e padrão Mediator com diversas funcionalidades como cadastro de cliente, compra de produtos, pagamento, notificação por e-mail entre outras. 
Primeiramente passando pela API Gateway com Ocelot e redirecionando para o serviço adequado que são cinco microserviços desacoplados e independentes com seu próprio banco de dados NoSQL MongoDb que interajam entre si pelo Service 
Discovery utilizando Consul, envio de e-mail com Twilio(SendGrid), Event-Driven Architecture com RabbitMQ para pagamentos e cache distribuído com Redis. 

---

 **Composto por:**
 - Customers
 - Products
 - Order
 - Payment
 - Notification
 - API Gateway

---

**Abaixo temos o diagrama com a arquitetura do projeto** ⬇️

![Diagrama](https://user-images.githubusercontent.com/37554746/154096116-173f327d-b5b1-4e4c-a8c0-d796a564d3df.png)

---

## 🛠 Tecnologias e Práticas utilizadas

- API desenvolvida com .NET 7
- Microsserviços
- Arquitetura Limpa
- Domain-Driven Design
- Injeção de Dependência
- CQRS
- MidiatR
- Entity Framework
- MongoDB
- Event-Driven Architeture com RabbitMQ
- Service Discovery com Consul
- Autenticação e Autorização com JWT
- API Gateway com Ocelot
- Cache Distribuído com Redis

## Arquitetura Limpa

Também conhecida como **Onion Architecture**, ou Arquitetura Cebola.
Tem como foco o **domínio** do sistema, tendo em sua essência o DDD - Domain Driven Design, sendo dividida em 4 camadas principais:

- Core, Infrastructure, Application e API
![image](https://user-images.githubusercontent.com/76961685/128607691-bbeeb09f-aeaf-4baa-8019-fcd73942ca5a.png)

---

## Entity Framework Core

É a ORM mais utilizada para desenvolvimento em .NET, sendo multiplataforma, open-source e mantida pela Microsoft. É madura, tendo sido evoluída junto ao .NET Core, com performance e funcionalidades sendo melhoradas a cada versão.
Os pacotes a serem utilizados são:

~~~ csharp
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

using Microsoft.EntityFrameworkCore;
~~~
![image](https://user-images.githubusercontent.com/76961685/128608246-d12db8a9-384f-4768-baba-f33989824431.png)

---

## CQRS

~~~ csharp
Command-Query Responsability Segregation
~~~
Padrão de desenvolvimento que separa as consultas (**Queries**) das ações que alteram o estado do sistema (**Commands**).

Melhora a legibilidade da aplicação, além de permitir maior separação de responsabilidades e estimula separação de modelos.
![image](https://user-images.githubusercontent.com/76961685/128608304-837169e1-c5de-4d4e-b518-d18860fc2429.png)

---

## MediatR

Uma espécie de *mensageria interna em memória*
Tem suporte a **Commands** e **Queries**, delegando eles para serem processados pelos seus respectivos **Handlers**
Pacote *MediatR*
~~~ csharp
MediatR.Extensions.Microsoft.DependencyInjection
~~~
![image](https://user-images.githubusercontent.com/76961685/128608476-44424e3c-f0bc-49a5-999a-5e9867fbdd35.png)

---

## MongoDB
O MongoDB é um banco de dados NoSQL multiplataforma, open-source, mantido pela MongoDB Inc., conhecido por sua flexibilidade e escalabilidade. 
Ele armazena dados em formato BSON e suporta operações avançadas de agregação, 
indexação, replicação e sharding. Para integrá-lo em projetos .NET, utilize os pacotes: **MongoDB.Driver, MongoDB.Bson e MongoDB.Driver.Core**.
![Image](https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Mongodb.png/1200px-Mongodb.png)

---

## RabbitMQ
O RabbitMQ é um broker de mensagens usado para intermediar a comunicação entre sistemas, 
facilitando a troca de mensagens de forma eficiente e segura. Suporta diversos protocolos de mensagem e é amplamente utilizado em
sistemas distribuídos para melhorar a **escalabilidade e a resiliência**. Para integrá-lo em projetos .NET, utilize os pacotes: **RabbitMQ.Client, EasyNetQ e MassTransit**.
![rabbitmq](https://github.com/Thiagooffice/AwesomeShop/assets/84478212/eb187ffc-2516-40ab-8db6-b61a9dba632b)

---

## Consul
O Consul é uma ferramenta de descoberta de serviços que permite que serviços dentro de uma rede encontrem e se comuniquem automaticamente entre si.
Ele fornece registro centralizado, verificação de saúde e resolução de endereços de serviços, 
facilitando a **gestão e orquestração** em arquiteturas de microsserviços. Para integrar o Consul em projetos .NET, utilize os seguintes pacotes: 
**Consul.Client, Winton.Extensions.Configuration.Consul e Ductus.FluentDocker**
![1_UO-kA9mO5rLuXWN9ZTb_aw](https://github.com/Thiagooffice/AwesomeShop/assets/84478212/6b3441cc-078a-41d9-9f8f-6ac66bdd8b1a)

---

## Ocelot
O Ocelot é uma biblioteca para .NET que facilita a construção de gateways de API em microserviços.
Ele funciona como um ponto de entrada único para solicitações de clientes, oferecendo funcionalidades como **roteamento, 
balanceamento de carga, cache e autenticação**, simplificando a **comunicação** entre serviços em arquiteturas distribuídas. 
Para integrar o Ocelot em projetos .NET, você precisa utilizar o seguinte pacote: **Ocelot**.
![1_6PIvXjt_3phsOun3ieHh8g](https://github.com/Thiagooffice/AwesomeShop/assets/84478212/3f3bb492-0d33-4f5b-9ed7-c358f147465a)

---

## Redis
O Redis é um banco de dados em memória, conhecido por sua velocidade e versatilidade no armazenamento e manipulação de estruturas de dados. 
Ele é amplamente utilizado para caching, gerenciamento de sessões, filas de mensagens e outras aplicações que exigem acesso rápido aos dados. Oferecendo performace, versatilidade e confiabilidade. 
Para integrar o Redis em projetos .NET, você deve utilizar o seguinte pacote: **StackExchange.Redis**
![banner-1544x500](https://github.com/Thiagooffice/AwesomeShop/assets/84478212/6fb1b7b1-70c7-4652-aee3-e4f7628554de)

---

## 🤝 Colaboradores

<table>
  <tr>
    <td align="center">
      <a href="https://github.com/Thiagooffice">
        <img src="https://avatars.githubusercontent.com/u/84478212?s=400&u=b003ad011d6337bf4a03b4aadde3d905bca5c9b8&v=4" width="160px;" alt="Photo by Thiago Leal on GitHub"/><br>
        <sub>
          <b>Thiago Leal de Souza</b>
        </sub>
      </a>
    </all>
  </tr>
</table>

---

<a href="#top">Voltar ao topo</a> ⬆️
