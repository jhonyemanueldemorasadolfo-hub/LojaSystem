using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LojaSystem.Models;
using Microsoft.IdentityModel.Tokens;

namespace LojaSystem.Paginas.PaginaProduto
{
    public partial class DeletarProduto : UserControl
    {
        private Supabase.Client _supabase;

        public DeletarProduto()
        {
            InitializeComponent();
            IncializarSupabae();
        }

        private async void IncializarSupabae()
        {
            var (url, key) = ConfigService.ObterCredenciaisSupabase();

            _supabase = new Supabase.Client(url, key);
            await _supabase.InitializeAsync();
        }

        private void cuiTextBox1_ContentChanged(object sender, EventArgs e)
        {

        }

        private async void cliButton1_Click(object sender, EventArgs e)
        {
            if (txtId.Text.IsNullOrEmpty() || txtId.Text.Any(char.IsLetter))
            {
                MessageBox.Show("O id não pode ser vazio nem ter letra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                Produto produto = new Produto()
                {
                    Id = Convert.ToInt32(txtId.Text)
                };

                await _supabase.From<Produto>().Delete(produto);

                MessageBox.Show("Produto Deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar, Erro:{ex.Message}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.None);

            if(result == DialogResult.Yes)
            {
                this.Parent?.Controls.Remove(this);
                this.Dispose();
            }
        }
    }
}
