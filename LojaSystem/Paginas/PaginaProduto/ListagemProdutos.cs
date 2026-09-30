using Supabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LojaSystem.Models;

namespace LojaSystem.Paginas.PaginaProduto
{
    public partial class ListagemProdutos : UserControl
    {
        private Supabase.Client _supabase;

        public ListagemProdutos()
        {
            InitializeComponent();
            InicializarSupabase();
            
        }

        private async void InicializarSupabase()
        {s

            var (key, url) = ConfigService.ObterCredenciaisSupabase();

            var supabase = new Supabase.Client(url, key);
        }

        private void ListagemProdutos_Load(object sender, EventArgs e)
        {

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void DGVListagemProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public async Task CarregarProd()
        {
           try
            {
            var resposta = await _supabase.From<Produto>().Get();
            List<Produto> produtos = resposta.Models;

                var listaFormatada = produtos.Select(p => new
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    Categoria = p.Categoria,
                    Preco = p.Preco,
                    Estoque = p.Estoque
                }).ToList();

                DGVListagemProdutos.AutoGenerateColumns = true;
                DGVListagemProdutos.DataSource = null;
                DGVListagemProdutos.DataSource = listaFormatada;


                 if (DGVListagemProdutos.Columns["Preco"] != null)
                {
                    DGVListagemProdutos.Columns["Preco"].HeaderText = "Preço Unitário";
                    DGVListagemProdutos.Columns["Preco"].DefaultCellStyle.Format = "C2";
                }

                if (DGVListagemProdutos.Columns["Id"] != null)
                {
                    DGVListagemProdutos.Columns["Id"].HeaderText = "Código";
                }

                if (DGVListagemProdutos.Columns["Nome"] != null)
                {
                    DGVListagemProdutos.Columns["Nome"].HeaderText = "Nome do Produto";
                }

                if (DGVListagemProdutos.Columns["Categoria"] != null)
                {
                    DGVListagemProdutos.Columns["Categoria"].HeaderText = "Categoria";
                }

                if (DGVListagemProdutos.Columns["Estoque"] != null)
                {
                    DGVListagemProdutos.Columns["Estoque"].HeaderText = "Qtd. Estoque";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Carregar dados! {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
