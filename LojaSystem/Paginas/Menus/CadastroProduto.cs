using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LojaSystem.Paginas.PaginaProduto;
 

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
            CadastroProduto cadastroProduto = new CadastroProduto();

            cadastroProduto.Dock = DockStyle.Fill;
            Controls.Add(cadastroProduto);
            cadastroProduto.BringToFront();
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
    }
}
