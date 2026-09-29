# 🛒 LojaSystem

> Sistema desktop para gerenciamento comercial e controle de estoque integrado a uma API RESTful e banco de dados MySQL.

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/dotnet/csharp/)
[![.NET 10](https://img.shields.io/badge/Framework-.NET%2010-purple.svg)](https://dotnet.microsoft.com/)
[![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-informational.svg)]()
[![ASP.NET Core](https://img.shields.io/badge/Backend-ASP.NET%20Core%20Web%20API-green.svg)](https://asp.net/)
[![MySQL](https://img.shields.io/badge/Database-MySQL-orange.svg)](https://www.mysql.com/)
[![Status](https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow.svg)]()

---

## 📌 Sobre o Projeto

O **LojaSystem** é um sistema de gerenciamento de lojas desenvolvido com o objetivo de aplicar na prática conceitos fundamentais da arquitetura de software, desacoplamento entre camadas e integração de aplicações desktop com APIs RESTful.

O projeto foi concebido tanto como uma solução para automação comercial quanto como uma plataforma de estudo prático para consolidação de conhecimentos em **C#**, **.NET 10**, **Windows Forms**, **Web API** e persitência de dados com **MySQL**.

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#
- **Plataforma:** .NET 10
- **Interface Gráfica:** Windows Forms
- **Backend / API:** ASP.NET Core Web API
- **Banco de Dados:** MySQL
- **Driver de Conexão:** MySql.Data
- **Controle de Versão:** Git e GitHub

---

## 🏗️ Arquitetura do Sistema

O sistema adota uma arquitetura em camadas que separa a interface com o usuário, a API de comunicação e a lógica de acesso a dados.

```mermaid
graph TD
    A[Desktop UI - Windows Forms] -->|Requisições HTTP| B[ASP.NET Core Web API]
    B --> C[Controllers]
    C --> D[Models]
    C --> E[Repositories / DAO]
    E -->|MySql.Data| F[(Banco de Dados MySQL)]