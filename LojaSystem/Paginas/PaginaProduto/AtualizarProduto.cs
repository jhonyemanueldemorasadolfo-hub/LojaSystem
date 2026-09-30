using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LojaSystem.Models;
using Microsoft.IdentityModel.Tokens;
using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace LojaSystem.Paginas.PaginaProduto
{
    public partial class AtualizarProduto : UserControl
    {
        private Supabase.Client _supabase;
        public AtualizarProduto()
        {
            InitializeComponent();
            InicializarSupabase();
        }

        public async void InicializarSupabase()
        {
            var (url, key) = ConfigService.ObterCredenciaisSupabase();

            // Inicializa o cliente com os dados vindos do appsettings.json
            var supabaseClient = new Supabase.Client(url, key);
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtEstoque_ContentChanged(object sender, EventArgs e)
        {

        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text) ||
                            string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                            string.IsNullOrWhiteSpace(txtPreco.Text) ||
                            string.IsNullOrWhiteSpace(txtEstoque.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // STOP! Impede que o código continue e dê erro no Parse
            }

            if (TxtNome.Text.Any(char.IsDigit))
            {
                MessageBox.Show("O nome não pode conter numero!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal precoConvertido))
            {
                MessageBox.Show("O campo Preço deve conter um valor numérico válido (ex: 19,90).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
                return;
            }

            if (!int.TryParse(txtEstoque.Text, out int estoqueConvertido))
            {
                MessageBox.Show("O campo Estoque deve conter apenas números inteiros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstoque.Focus();
                return;
            }


            try
            {

                Produto produto = new Produto()
                {
                    Id = Convert.ToInt32(idProcura.Text),
                    Nome = TxtNome.Text,
                    Categoria = txtCategoria.Text,
                    Preco = Convert.ToDecimal(txtPreco.Text),
                    Estoque = Convert.ToInt32(txtEstoque.Text)
                };

                await _supabase.From<Produto>().Update(produto);

                MessageBox.Show("O produto foi alterado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }catch(Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o Produto, ERRO: {ex.Message}");
            }

            
        }
    }
}
