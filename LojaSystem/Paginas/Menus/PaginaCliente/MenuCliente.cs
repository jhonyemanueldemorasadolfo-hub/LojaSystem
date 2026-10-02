using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LojaSystem.Paginas.Menus.PaginaCliente
{
    public partial class MenuCliente : UserControl
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {

        }

        private void ButtonVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BotaoCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();

            cadastroCliente.Dock = DockStyle.Fill;
            Controls.Add(cadastroCliente);
            cadastroCliente.BringToFront();
        }
    }
}
