using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LojaSystem.Models;

namespace LojaSystem.Paginas.Menus.PaginaCliente
{
    public partial class ListarClientes : UserControl
    {
        private Supabase.Client _supabase;

        public async Task InicializarSupa()
        {
            var (url, key) = ConfigService.ObterCredenciaisSupabase();

            _supabase = new Supabase.Client(url, key);
            await _supabase.InitializeAsync();
        }


        public ListarClientes()
        {
            InitializeComponent();
            InicializarSupa();
            CarregarProdutos();
        }

        private void DGVListagemProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string FormatarCPF(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
                return cpf;

            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        private string FormatarTelefone(string telefone)
        {
            telefone = new string(telefone.Where(char.IsDigit).ToArray());

            if (telefone.Length == 11)
                return Convert.ToUInt64(telefone).ToString(@"\(00\) 00000\-0000");

            if (telefone.Length == 10)
                return Convert.ToUInt64(telefone).ToString(@"\(00\) 0000\-0000");

            return telefone;
        }


        public async Task CarregarProdutos()
        {
            try
            {
                var resposta = await _supabase.From<Cliente>().Get();
                List<Cliente> clientes = resposta.Models;

                var ListagemFormata = clientes.Select(c => new
                {
                    c.id,
                    c.Nome,
                    CPF = FormatarCPF(c.CPF),
                    Telefone = FormatarTelefone(c.Telefone)
                }).ToList();

                DGVListagemProdutos.AutoGenerateColumns = true;
                DGVListagemProdutos.DataSource = null;
                DGVListagemProdutos.DataSource = ListagemFormata;

                if (DGVListagemProdutos.Columns.Count > 0)
                {
                    DGVListagemProdutos.Columns[0].HeaderText = "ID";
                    DGVListagemProdutos.Columns[1].HeaderText = "Nome";
                    DGVListagemProdutos.Columns[2].HeaderText = "CPF";
                    DGVListagemProdutos.Columns[3].HeaderText = "Telefone";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cuiButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
