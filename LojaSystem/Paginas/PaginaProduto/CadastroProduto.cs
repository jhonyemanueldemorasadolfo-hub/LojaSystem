using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LojaSystem.Models;

namespace LojaSystem.Paginas.Cadastrar
{
    public partial class CadastrarProduto : UserControl
    {

        private Supabase.Client _supabase;

        public CadastrarProduto()
        {
            InitializeComponent();
            InicializarSupabase();
        }

        private async void InicializarSupabase()
        {

            var (url, key) = ConfigService.ObterCredenciaisSupabase();

            // Inicializa o cliente com os dados vindos do appsettings.json
            _supabase = new Supabase.Client(url, key);
            await _supabase.InitializeAsync();
        }

        private async void BotaoCadastrarProduto_Click(object sender, EventArgs e)
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

            if(txtNome.Text.Any(char.IsDigit))
            {
                MessageBox.Show("O nome não pode conter numero!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
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

            try
            {
                Produto produto = new Produto
                {
                    Nome = txtNome.Text,
                    Preco = Convert.ToDecimal(txtPreco.Text),
                    Categoria = txtCategoria.Text,
                       Estoque = Convert.ToInt32(txtQuantidadeEstoque.Text)
                };

                 await _supabase.From<Produto>().Insert(produto);
                MessageBox.Show("Produto Inserido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }catch(Exception ex)
            {
                MessageBox.Show($"Erro ao salvar no Supabase: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}