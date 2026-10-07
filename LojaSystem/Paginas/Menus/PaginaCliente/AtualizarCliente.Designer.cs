namespace LojaSystem.Paginas.Menus.PaginaCliente
{
    partial class AtualizarCliente
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
            idProcura = new HartUI.Controls.cuiTextBox();
            cuiButton1 = new HartUI.Controls.cuiButton();
            btnAtualizar = new HartUI.Controls.cuiButton();
            txtCPF = new HartUI.Controls.cuiTextBox();
            txtTelefone = new HartUI.Controls.cuiTextBox();
            TxtNome = new HartUI.Controls.cuiTextBox();
            cuiLabel1 = new HartUI.Controls.cuiLabel();
            cuiPanel1 = new HartUI.Controls.cuiPanel();
            cuiPanel3 = new HartUI.Controls.cuiPanel();
            cuiPanel2 = new HartUI.Controls.cuiPanel();
            SuspendLayout();
            // 
            // idProcura
            // 
            idProcura.BackColor = Color.FromArgb(30, 41, 59);
            idProcura.BackgroundColor = Color.White;
            idProcura.Content = "";
            idProcura.FocusBackgroundColor = Color.White;
            idProcura.FocusImageTint = Color.White;
            idProcura.FocusOutlineColor = Color.FromArgb(61, 24, 226);
            idProcura.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idProcura.ForeColor = Color.Gray;
            idProcura.Image = null;
            idProcura.ImageExpand = new Point(0, 0);
            idProcura.ImageOffset = new Point(0, 0);
            idProcura.ImageTextSpacing = 8;
            idProcura.Location = new Point(464, 64);
            idProcura.Margin = new Padding(4);
            idProcura.Multiline = false;
            idProcura.Name = "idProcura";
            idProcura.NormalImageTint = Color.White;
            idProcura.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            idProcura.Padding = new Padding(16, 14, 16, 0);
            idProcura.PasswordChar = false;
            idProcura.PlaceholderColor = Color.LightGray;
            idProcura.PlaceholderText = "Digite o Id do cliente pra alterar";
            idProcura.Rounding = new Padding(8);
            idProcura.Size = new Size(266, 45);
            idProcura.TabIndex = 27;
            idProcura.TextOffset = new Size(0, 0);
            idProcura.UnderlinedStyle = true;
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
            cuiButton1.Content = "Cancelar!";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.White;
            cuiButton1.HoverBackground = Color.FromArgb(255, 128, 128);
            cuiButton1.HoverForeColor = Color.White;
            cuiButton1.HoverImageTint = Color.DimGray;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.Location = new Point(8, 472);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.Red;
            cuiButton1.NormalForeColor = Color.White;
            cuiButton1.NormalImageTint = Color.Black;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.Padding = new Padding(12);
            cuiButton1.PressedBackground = Color.FromArgb(192, 0, 0);
            cuiButton1.PressedForeColor = Color.White;
            cuiButton1.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(16);
            cuiButton1.Size = new Size(153, 45);
            cuiButton1.TabIndex = 25;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextPadding = 12;
            cuiButton1.TextSpacing = 2;
            cuiButton1.Click += cuiButton1_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(30, 41, 59);
            btnAtualizar.CheckButton = false;
            btnAtualizar.Checked = false;
            btnAtualizar.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnAtualizar.CheckedForeColor = Color.White;
            btnAtualizar.CheckedImageTint = Color.White;
            btnAtualizar.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnAtualizar.Content = "Atualizar";
            btnAtualizar.DialogResult = DialogResult.None;
            btnAtualizar.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.HoverBackground = Color.FromArgb(128, 255, 128);
            btnAtualizar.HoverForeColor = Color.White;
            btnAtualizar.HoverImageTint = Color.DimGray;
            btnAtualizar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnAtualizar.Image = null;
            btnAtualizar.ImageExpand = new Point(0, 0);
            btnAtualizar.Location = new Point(8, 400);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.NormalBackground = Color.Lime;
            btnAtualizar.NormalForeColor = Color.White;
            btnAtualizar.NormalImageTint = Color.Black;
            btnAtualizar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnAtualizar.OutlineThickness = 1F;
            btnAtualizar.Padding = new Padding(12);
            btnAtualizar.PressedBackground = Color.FromArgb(0, 192, 0);
            btnAtualizar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnAtualizar.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnAtualizar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnAtualizar.Rounding = new Padding(16);
            btnAtualizar.Size = new Size(152, 45);
            btnAtualizar.TabIndex = 24;
            btnAtualizar.TextAlignment = StringAlignment.Center;
            btnAtualizar.TextPadding = 12;
            btnAtualizar.TextSpacing = 2;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtCPF
            // 
            txtCPF.BackColor = Color.FromArgb(30, 41, 59);
            txtCPF.BackgroundColor = Color.White;
            txtCPF.Content = "";
            txtCPF.FocusBackgroundColor = Color.White;
            txtCPF.FocusImageTint = Color.White;
            txtCPF.FocusOutlineColor = Color.FromArgb(61, 24, 226);
            txtCPF.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCPF.ForeColor = Color.Gray;
            txtCPF.Image = null;
            txtCPF.ImageExpand = new Point(0, 0);
            txtCPF.ImageOffset = new Point(0, 0);
            txtCPF.ImageTextSpacing = 8;
            txtCPF.Location = new Point(464, 336);
            txtCPF.Margin = new Padding(4);
            txtCPF.Multiline = false;
            txtCPF.Name = "txtCPF";
            txtCPF.NormalImageTint = Color.White;
            txtCPF.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtCPF.Padding = new Padding(16, 14, 16, 0);
            txtCPF.PasswordChar = false;
            txtCPF.PlaceholderColor = Color.LightGray;
            txtCPF.PlaceholderText = "Digite o novo CPF";
            txtCPF.Rounding = new Padding(8);
            txtCPF.Size = new Size(266, 45);
            txtCPF.TabIndex = 23;
            txtCPF.TextOffset = new Size(0, 0);
            txtCPF.UnderlinedStyle = true;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.FromArgb(30, 41, 59);
            txtTelefone.BackgroundColor = Color.White;
            txtTelefone.Content = "";
            txtTelefone.FocusBackgroundColor = Color.White;
            txtTelefone.FocusImageTint = Color.White;
            txtTelefone.FocusOutlineColor = Color.FromArgb(61, 24, 226);
            txtTelefone.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.ForeColor = Color.Gray;
            txtTelefone.Image = null;
            txtTelefone.ImageExpand = new Point(0, 0);
            txtTelefone.ImageOffset = new Point(0, 0);
            txtTelefone.ImageTextSpacing = 8;
            txtTelefone.Location = new Point(464, 264);
            txtTelefone.Margin = new Padding(4);
            txtTelefone.Multiline = false;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.NormalImageTint = Color.White;
            txtTelefone.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtTelefone.Padding = new Padding(16, 14, 16, 0);
            txtTelefone.PasswordChar = false;
            txtTelefone.PlaceholderColor = Color.LightGray;
            txtTelefone.PlaceholderText = "Digite o novo Telefone";
            txtTelefone.Rounding = new Padding(8);
            txtTelefone.Size = new Size(266, 45);
            txtTelefone.TabIndex = 22;
            txtTelefone.TextOffset = new Size(0, 0);
            txtTelefone.UnderlinedStyle = true;
            txtTelefone.ContentChanged += txtPreco_ContentChanged;
            // 
            // TxtNome
            // 
            TxtNome.BackColor = Color.FromArgb(30, 41, 59);
            TxtNome.BackgroundColor = Color.White;
            TxtNome.Content = "";
            TxtNome.FocusBackgroundColor = Color.White;
            TxtNome.FocusImageTint = Color.White;
            TxtNome.FocusOutlineColor = Color.FromArgb(61, 24, 226);
            TxtNome.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNome.ForeColor = Color.Gray;
            TxtNome.Image = null;
            TxtNome.ImageExpand = new Point(0, 0);
            TxtNome.ImageOffset = new Point(0, 0);
            TxtNome.ImageTextSpacing = 8;
            TxtNome.Location = new Point(464, 192);
            TxtNome.Margin = new Padding(4);
            TxtNome.Multiline = false;
            TxtNome.Name = "TxtNome";
            TxtNome.NormalImageTint = Color.White;
            TxtNome.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            TxtNome.Padding = new Padding(16, 14, 16, 0);
            TxtNome.PasswordChar = false;
            TxtNome.PlaceholderColor = Color.LightGray;
            TxtNome.PlaceholderText = "Digite o novo nome";
            TxtNome.Rounding = new Padding(8);
            TxtNome.Size = new Size(266, 45);
            TxtNome.TabIndex = 20;
            TxtNome.TextOffset = new Size(0, 0);
            TxtNome.UnderlinedStyle = true;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.FromArgb(30, 41, 59);
            cuiLabel1.Content = "Loja System";
            cuiLabel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.White;
            cuiLabel1.Location = new Point(16, 24);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(143, 63);
            cuiLabel1.TabIndex = 18;
            cuiLabel1.TabStop = false;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
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
            cuiPanel1.TabIndex = 17;
            // 
            // cuiPanel3
            // 
            cuiPanel3.AutoScroll = true;
            cuiPanel3.BackColor = Color.FromArgb(30, 41, 59);
            cuiPanel3.Location = new Point(416, 32);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.FromArgb(15, 23, 42);
            cuiPanel3.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel3.Rounding = new Padding(16);
            cuiPanel3.Size = new Size(368, 464);
            cuiPanel3.TabIndex = 26;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Location = new Point(240, 16);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(30, 41, 59);
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(16);
            cuiPanel2.Size = new Size(700, 500);
            cuiPanel2.TabIndex = 19;
            // 
            // AtualizarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            Controls.Add(idProcura);
            Controls.Add(cuiButton1);
            Controls.Add(btnAtualizar);
            Controls.Add(txtCPF);
            Controls.Add(txtTelefone);
            Controls.Add(TxtNome);
            Controls.Add(cuiLabel1);
            Controls.Add(cuiPanel1);
            Controls.Add(cuiPanel3);
            Controls.Add(cuiPanel2);
            Name = "AtualizarCliente";
            Size = new Size(985, 535);
            ResumeLayout(false);
        }

        #endregion

        private HartUI.Controls.cuiTextBox idProcura;
        private HartUI.Controls.cuiButton cuiButton1;
        private HartUI.Controls.cuiButton btnAtualizar;
        private HartUI.Controls.cuiTextBox txtCPF;
        private HartUI.Controls.cuiTextBox txtTelefone;
        private HartUI.Controls.cuiTextBox TxtNome;
        private HartUI.Controls.cuiLabel cuiLabel1;
        private HartUI.Controls.cuiPanel cuiPanel1;
        private HartUI.Controls.cuiPanel cuiPanel3;
        private HartUI.Controls.cuiPanel cuiPanel2;
    }
}
