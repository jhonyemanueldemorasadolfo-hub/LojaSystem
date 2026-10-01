using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LojaSystem.Paginas.PaginaProduto;
using LojaSystem.Paginas.Cadastrar;
 

namespace LojaSystem.Paginas.cadastro_produto
{
    public partial class CadastroProduto : UserControl
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadastrarProduto = new CadastrarProduto();

            cadastrarProduto.Dock = DockStyle.Fill;
            Controls.Add(cadastrarProduto);
            cadastrarProduto.BringToFront();
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            ListagemProdutos listagem = new ListagemProdutos();

            listagem.Dock = DockStyle.Fill;
            Controls.Add(listagem);
            listagem.BringToFront();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void cuiButton1_Click_1(object sender, EventArgs e)
        {
            AtualizarProduto atualizarProduto = new AtualizarProduto();

            atualizarProduto.Dock = DockStyle.Fill;
            Controls.Add(atualizarProduto);
            atualizarProduto.BringToFront();
        }

        private void cuiButton4_Click(object sender, EventArgs e)
        {
            DeletarProduto deletar = new DeletarProduto();

            deletar.Dock = DockStyle.Fill;
            Controls.Add(deletar);
            deletar.BringToFront();
        }
    }
}
