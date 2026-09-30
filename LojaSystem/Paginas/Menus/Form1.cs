using LojaSystem.Paginas.cadastro_produto;

namespace LojaSystem
{
    public partial class FundoPrincipal : Form
    {

        public FundoPrincipal()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();

            cadastroProduto.Dock = DockStyle.Fill;
    
            Controls.Add(cadastroProduto);
            cadastroProduto.BringToFront();

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }


        private void cuiButton1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void cuiButton5_Click(object sender, EventArgs e)
        {

        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {

        }

        private void FlowConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiLabel2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
