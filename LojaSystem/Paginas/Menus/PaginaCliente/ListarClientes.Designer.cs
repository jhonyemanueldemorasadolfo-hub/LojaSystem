namespace LojaSystem.Paginas.Menus.PaginaCliente
{
    partial class ListarClientes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            cuiLabel1 = new HartUI.Controls.cuiLabel();
            cuiButton1 = new HartUI.Controls.cuiButton();
            cuiPanel1 = new HartUI.Controls.cuiPanel();
            DGVListagemProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVListagemProdutos).BeginInit();
            SuspendLayout();
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.FromArgb(30, 41, 59);
            cuiLabel1.Content = "Loja System";
            cuiLabel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.White;
            cuiLabel1.Location = new Point(16, 16);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(143, 63);
            cuiLabel1.TabIndex = 6;
            cuiLabel1.TabStop = false;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.FromArgb(30, 41, 59);
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(61, 24, 226);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(61, 24, 226);
            cuiButton1.Content = "Voltar";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.White;
            cuiButton1.HoverBackground = Color.FromArgb(96, 165, 250);
            cuiButton1.HoverForeColor = Color.White;
            cuiButton1.HoverImageTint = Color.DimGray;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.Location = new Point(16, 464);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.FromArgb(59, 130, 246);
            cuiButton1.NormalForeColor = Color.White;
            cuiButton1.NormalImageTint = Color.Black;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.Padding = new Padding(12);
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(16);
            cuiButton1.Size = new Size(144, 45);
            cuiButton1.TabIndex = 5;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextPadding = 12;
            cuiButton1.TextSpacing = 2;
            cuiButton1.Click += cuiButton1_Click_1;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Margin = new Padding(0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(30, 41, 59);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(30);
            cuiPanel1.Size = new Size(170, 536);
            cuiPanel1.TabIndex = 4;
            // 
            // DGVListagemProdutos
            // 
            DGVListagemProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVListagemProdutos.BackgroundColor = Color.FromArgb(30, 41, 59);
            DGVListagemProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVListagemProdutos.Location = new Point(176, 16);
            DGVListagemProdutos.Name = "DGVListagemProdutos";
            DGVListagemProdutos.Size = new Size(800, 500);
            DGVListagemProdutos.TabIndex = 7;
            DGVListagemProdutos.CellContentClick += DGVListagemProdutos_CellContentClick;
            // 
            // ListarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            Controls.Add(DGVListagemProdutos);
            Controls.Add(cuiLabel1);
            Controls.Add(cuiButton1);
            Controls.Add(cuiPanel1);
            Name = "ListarClientes";
            Size = new Size(985, 535);
            ((System.ComponentModel.ISupportInitialize)DGVListagemProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private HartUI.Controls.cuiLabel cuiLabel1;
        private HartUI.Controls.cuiButton cuiButton1;
        private HartUI.Controls.cuiPanel cuiPanel1;
        private DataGridView DGVListagemProdutos;
    }
}
