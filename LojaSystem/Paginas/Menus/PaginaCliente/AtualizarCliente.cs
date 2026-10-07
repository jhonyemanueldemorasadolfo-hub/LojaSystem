using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LojaSystem.Models;
using LojaSystem.Paginas.Menus.PaginaCliente;
using Supabase;
using Supabase.Postgrest.Attributes;


namespace LojaSystem.Paginas.Menus.PaginaCliente
{
    public partial class AtualizarCliente : UserControl
    {
        private Supabase.Client _supabase;

        public AtualizarCliente()
        {
            InitializeComponent();
            InicializarSupa();
        }

        public async Task InicializarSupa()
        {
            var (url, key) = ConfigService.ObterCredenciaisSupabase();

            _supabase = new Supabase.Client(url, key);
            await _supabase.InitializeAsync();
        }


        private void txtPreco_ContentChanged(object sender, EventArgs e)
        {

        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idProcura.Text) || string.IsNullOrWhiteSpace(TxtNome.Text) || string.IsNullOrWhiteSpace(txtCPF.Text) || string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(idProcura.Text, out int id))
            {
                MessageBox.Show("ID inválido. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(txtCPF.Text, out long cpf) || txtCPF.Text.Length != 11)
            {
                MessageBox.Show("CPF inválido. Por favor, insira um CPF válido com 11 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(txtTelefone.Text, out long telefone) || txtTelefone.Text.Length < 10 || txtTelefone.Text.Length > 11)
            {
                MessageBox.Show("Telefone inválido. Por favor, insira um telefone válido com 10 ou 11 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                Cliente cliente = new Cliente
                {
                    id = int.Parse(idProcura.Text),
                    Nome = TxtNome.Text,
                    CPF = txtCPF.Text,
                    Telefone = txtTelefone.Text
                };

                await _supabase.From<Cliente>().Update(cliente);

                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Deseja realmente voltar? As alterações não salvas serão perdidas.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
