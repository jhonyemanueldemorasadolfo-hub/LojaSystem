using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LojaSystem.Models;
using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace LojaSystem.Paginas.Menus.PaginaCliente
{
    public partial class CadastroCliente : UserControl
    {
        private Supabase.Client _supabase;
        public CadastroCliente()
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

        private async void cliButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtTelefone.Text) || string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNome.Text.Any(char.IsDigit))
            {
                MessageBox.Show("O nome não pode conter numero!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if(txtCPF.Text.Length != 11 || !txtCPF.Text.All(char.IsDigit))
            {
                MessageBox.Show("O CPF deve conter exatamente 11 dígitos numéricos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
                return;
            }

            if(txtTelefone.Text.Length != 11 || !txtTelefone.Text.All(char.IsDigit))
            {
                MessageBox.Show("O telefone deve conter exatamente 11 dígitos numéricos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefone.Focus();
                return;
            }

            try
            {
                Cliente novoCliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Telefone = txtTelefone.Text,
                    CPF = txtCPF.Text
                };

                await _supabase.From<Cliente>().Insert(novoCliente);

                MessageBox.Show("Cliente cadastrado com sucesso", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar o cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente cancelar o cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void txtNome_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
