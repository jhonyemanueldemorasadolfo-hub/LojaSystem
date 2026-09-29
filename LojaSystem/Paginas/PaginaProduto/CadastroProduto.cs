using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LojaSystem.API.Repositories;
using LojaSystem.API.Models;

namespace LojaSystem.Paginas.Cadastrar
{
    public partial class CadastrarProduto : UserControl
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void BotaoCadastrarProduto_Click(object sender, EventArgs e)
        {
            // 1. Valida se há campos vazios
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtPreco.Text) ||
                string.IsNullOrWhiteSpace(txtQuantidadeEstoque.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // STOP! Impede que o código continue e dê erro no Parse
            }

            // 2. Valida se Preço e Estoque são números válidos
            if (!decimal.TryParse(txtPreco.Text, out decimal precoConvertido))
            {
                MessageBox.Show("O campo Preço deve conter um valor numérico válido (ex: 19,90).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
                return;
            }

            if (!int.TryParse(txtQuantidadeEstoque.Text, out int estoqueConvertido))
            {
                MessageBox.Show("O campo Estoque deve conter apenas números inteiros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidadeEstoque.Focus();
                return;
            }

            // 3. Monta o objeto Produto com os valores já convertidos
            Produto produto = new Produto
            {
                nome = txtNome.Text.Trim(),
                categoria = txtCategoria.Text.Trim(),
                preco = precoConvertido,
                estoque = estoqueConvertido
            };

            // 4. Executa o cadastro na DAO
            ProdutoDAO produtoDAO = new ProdutoDAO();
            bool sucesso = produtoDAO.Cadastrar(produto);

            if (sucesso)
            {
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos após cadastrar
                /*txtNome.Clear();
                txtCategoria.Clear();
                txtPreco.Clear();
                txtQuantidadeEstoque.Clear();*/
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o produto no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Tem certeza que deseja cancelar?", "Cancelar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Remove este UserControl do container pai
                this.Parent?.Controls.Remove(this);
                this.Dispose();
            }
        }
    }
}