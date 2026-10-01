# 🛒 LojaSystem

O **LojaSystem** é um sistema de gestão de produtos desenvolvido para garantir uma integração segura, estável e eficiente com base de dados na nuvem via **Supabase**.

---

## 🛠️ Tecnologias e Ferramentas Utilizadas

- **Linguagem & Framework:** C# / .NET (WinUI / Windows Forms / Uno Platform)
- **Backend & Database:** [Supabase](https://supabase.com/) (PostgreSQL/MySQL BaaS)
- **SDK:** `supabase-csharp`
- **Gestão de Configurações:** `Microsoft.Extensions.Configuration` (`appsettings.json`)
- **Controlo de Versão:** Git & GitHub

---

## 🔒 Segurança e Boas Práticas

- **Gestão de Credenciais:** As chaves de API (`Url` e `Anon Key`) do Supabase são mantidas isoladas no ficheiro local `appsettings.json`, prevenindo a exposição acidental de credenciais sensíveis.
- **Proteção do Histórico Git:** O ficheiro de configuração local está devidamente ignorado no `.gitignore`.
- **Tratamento de Dados:** Validações rigorosas com `TryParse`, `Trim` e substituição de separadores decimais para evitar falhas em tempo de execução durante operações de CRUD.

---

## 🚀 Funcionalidades Atuais

- [x] Conexão segura com a API do Supabase.
- [x] **Cadastro de Produtos:** Inserção de novos registos na base de dados.
- [x] **Listagem de Produtos:** Leitura e formatação assíncrona em grelha (`DataGridView`), com renomeação de colunas e formatação de moeda.
- [x] **Atualização de Produtos:** Modificação de dados existentes mapeados via chave primária.
- [x] **Remoção de Produtos:** Exclusão individual de registos com confirmação prévia de utilizador.

---

## 🔮 Futuras Atualizações e Roadmap

- [ ] **Aplicação Mobile (App):** Expansão do sistema para ecossistema mobile (Android/iOS) integrando com o mesmo backend do Supabase para sincronização de dados em tempo real.
- [ ] Implementação de autenticação de utilizadores e permissões por perfil (RLS).
- [ ] Relatórios de vendas e controlo avançado de stock.

---

## ⚙️ Como Configurar o Projeto Localmente

1. Clona o repositório para a tua máquina:
   ```bash
   git clone [https://github.com/teu-usuario/LojaSystem.git](https://github.com/teu-usuario/LojaSystem.git)
