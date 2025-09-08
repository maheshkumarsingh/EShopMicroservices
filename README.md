# 🛒 eShop Microservices

A reference implementation of an **e-commerce application** built using **.NET 9, Microservices architecture, Docker, and modern DevOps practices**.  
This project demonstrates **DDD (Domain-Driven Design), CQRS, Event-Driven Communication, and API Gateway** patterns.

---

## 🚀 Features

- **Microservices-based architecture**
  - Catalog Service (Products, Categories, Pricing)
  - Basket Service (Shopping Cart, Discounts)
  - Ordering Service (Orders, Payments, Checkout)
  - Identity Service (Authentication & Authorization)
- **API Gateway with Ocelot/YARP**
- **Asynchronous messaging with RabbitMQ/Kafka**
- **Entity Framework Core & SQL Server/PostgreSQL**
- **gRPC communication between services**
- **Docker & Kubernetes support**
- **Centralized logging & monitoring with Serilog + ELK/Grafana**
- **CI/CD ready with GitHub Actions / Azure DevOps**

---

## 🏗️ Architecture

```text
                        ┌──────────────────┐
                        │   API Gateway    │
                        └───────┬──────────┘
                                │
       ┌───────────────┬────────┼────────┬───────────────┐
       │               │        │        │               │
┌──────────────┐ ┌───────────┐ ┌───────────┐ ┌────────────────┐
│ Catalog Svc  │ │ Basket Svc│ │ Order Svc │ │ Identity Svc   │
│ (.NET 9 API) │ │ (.NET 9)  │ │ (.NET 9)  │ │ (Auth + JWT)   │
└───────┬──────┘ └──────┬────┘ └──────┬────┘ └───────┬────────┘
        │               │              │              │
        │               │              │              │
    ┌────────┐     ┌────────┐     ┌────────┐     ┌───────────┐
    │ SQL DB │     │ Redis  │     │ SQL DB │     │ SQL Server│
    └────────┘     └────────┘     └────────┘     └───────────┘

              ┌───────────────────────────┐
              │   Message Broker (Rabbit) │
              └───────────────────────────┘
