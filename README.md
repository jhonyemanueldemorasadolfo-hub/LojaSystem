# 🛒 LojaSystem

> Sistema desktop para gerenciamento comercial e controle de estoque, desenvolvido em C# e integrado ao Supabase.

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://learn.microsoft.com/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/Framework-.NET%2010-purple.svg)](https://dotnet.microsoft.com/)
[![WinUI 3](https://img.shields.io/badge/UI-WinUI%203-informational.svg)](https://learn.microsoft.com/windows/apps/winui/)
[![Supabase](https://img.shields.io/badge/Backend-Supabase-green.svg)](https://supabase.com/)
[![PostgreSQL](https://img.shields.io/badge/Database-PostgreSQL-blue.svg)](https://www.postgresql.org/)
[![Status](https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow.svg)]()

---

## 📌 Sobre o Projeto

O **LojaSystem** é um sistema desktop para gerenciamento comercial e controle de estoque.

O projeto está sendo desenvolvido utilizando **C# e WinUI 3**, com o **Supabase** como plataforma de backend e banco de dados.

O principal objetivo é desenvolver uma aplicação completa, praticando conceitos de desenvolvimento de software, integração com serviços externos, manipulação de dados, organização de código e controle de versão.

---

## 🎯 Objetivos

- Desenvolver uma aplicação desktop funcional.
- Praticar desenvolvimento com C#.
- Trabalhar com interfaces utilizando XAML e WinUI 3.
- Integrar a aplicação com o Supabase.
- Implementar operações CRUD.
- Trabalhar com banco de dados.
- Praticar organização e manutenção de projetos.
- Utilizar Git e GitHub durante o desenvolvimento.

---

## 🛠️ Tecnologias Utilizadas

### 💻 Aplicação

- **C#**
- **.NET 10**
- **WinUI 3**
- **XAML**

### ☁️ Backend e Dados

- **Supabase**
- **PostgreSQL**
- **REST API**
- **JSON**

### 🔧 Ferramentas

- **Visual Studio**
- **Git**
- **GitHub**
- **Supabase Dashboard**

---

## 🏗️ Arquitetura

A aplicação utiliza o Supabase como camada de backend e persistência de dados.

```mermaid
graph TD
    A[🖥️ WinUI 3 / C#] -->|HTTP / JSON| B[☁️ Supabase]
    B --> C[🔐 Autenticação]
    B --> D[🌐 API]
    B --> E[(🗄️ PostgreSQL)]
