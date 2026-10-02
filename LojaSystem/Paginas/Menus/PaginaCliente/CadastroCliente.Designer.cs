namespace LojaSystem.Paginas.Menus.PaginaCliente
{
    partial class CadastroCliente
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
            txtNome = new HartUI.Controls.cuiTextBox();
            cuiPanel3 = new HartUI.Controls.cuiPanel();
            cuiButton1 = new HartUI.Controls.cuiButton();
            cliButton1 = new HartUI.Controls.cuiButton();
            cuiPanel2 = new HartUI.Controls.cuiPanel();
            cuiLabel1 = new HartUI.Controls.cuiLabel();
            cuiPanel1 = new HartUI.Controls.cuiPanel();
            cuiLabel2 = new HartUI.Controls.cuiLabel();
            txtTelefone = new HartUI.Controls.cuiTextBox();
            txtCPF = new HartUI.Controls.cuiTextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackgroundColor = Color.White;
            txtNome.Content = "";
            txtNome.FocusBackgroundColor = Color.White;
            txtNome.FocusImageTint = Color.White;
            txtNome.FocusOutlineColor = Color.FromArgb(61, 24, 226);
            txtNome.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.Gray;
            txtNome.Image = null;
            txtNome.ImageExpand = new Point(0, 0);
            txtNome.ImageOffset = new Point(0, 0);
            txtNome.ImageTextSpacing = 8;
            txtNome.Location = new Point(432, 168);
            txtNome.Margin = new Padding(4);
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.NormalImageTint = Color.White;
            txtNome.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtNome.Padding = new Padding(16, 4, 16, 0);
            txtNome.PasswordChar = false;
            txtNome.PlaceholderColor = Color.Black;
            txtNome.PlaceholderText = "Digite o nome do cliente";
            txtNome.Rounding = new Padding(8);
            txtNome.Size = new Size(280, 24);
            txtNome.TabIndex = 19;
            txtNome.TextOffset = new Size(0, 0);
            txtNome.UnderlinedStyle = true;
            txtNome.ContentChanged += txtNome_ContentChanged;
            // 
            // cuiPanel3
            // 
            cuiPanel3.AutoScroll = true;
            cuiPanel3.BackColor = Color.FromArgb(30, 41, 59);
            cuiPanel3.Location = new Point(384, 112);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.FromArgb(15, 23, 42);
            cuiPanel3.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel3.Rounding = new Padding(16);
            cuiPanel3.Size = new Size(368, 392);
            cuiPanel3.TabIndex = 18;
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
            cuiButton1.Location = new Point(8, 448);
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
            cuiButton1.TabIndex = 17;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextPadding = 12;
            cuiButton1.TextSpacing = 2;
            cuiButton1.Click += cuiButton1_Click;
            // 
            // cliButton1
            // 
            cliButton1.BackColor = Color.FromArgb(30, 41, 59);
            cliButton1.CheckButton = false;
            cliButton1.Checked = false;
            cliButton1.CheckedBackground = Color.FromArgb(61, 24, 226);
            cliButton1.CheckedForeColor = Color.White;
            cliButton1.CheckedImageTint = Color.White;
            cliButton1.CheckedOutline = Color.FromArgb(61, 24, 226);
            cliButton1.Content = "Cadastrar!";
            cliButton1.DialogResult = DialogResult.None;
            cliButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cliButton1.ForeColor = Color.White;
            cliButton1.HoverBackground = Color.FromArgb(128, 255, 128);
            cliButton1.HoverForeColor = Color.White;
            cliButton1.HoverImageTint = Color.DimGray;
            cliButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cliButton1.Image = null;
            cliButton1.ImageExpand = new Point(0, 0);
            cliButton1.Location = new Point(8, 392);
            cliButton1.Name = "cliButton1";
            cliButton1.NormalBackground = Color.FromArgb(0, 192, 0);
            cliButton1.NormalForeColor = Color.White;
            cliButton1.NormalImageTint = Color.Black;
            cliButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cliButton1.OutlineThickness = 1F;
            cliButton1.Padding = new Padding(12);
            cliButton1.PressedBackground = Color.Green;
            cliButton1.PressedForeColor = Color.White;
            cliButton1.PressedImageTint = Color.FromArgb(32, 32, 32);
            cliButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cliButton1.Rounding = new Padding(16);
            cliButton1.Size = new Size(153, 45);
            cliButton1.TabIndex = 16;
            cliButton1.TextAlignment = StringAlignment.Center;
            cliButton1.TextPadding = 12;
            cliButton1.TextSpacing = 2;
            cliButton1.Click += cliButton1_Click;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Location = new Point(232, 16);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(30, 41, 59);
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(8);
            cuiPanel2.Size = new Size(700, 500);
            cuiPanel2.TabIndex = 15;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.FromArgb(30, 41, 59);
            cuiLabel1.Content = "Loja System";
            cuiLabel1.Font = new Font("Arial", 12F, FontStyle.Bold);
            cuiLabel1.ForeColor = Color.White;
            cuiLabel1.Location = new Point(16, 16);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(143, 63);
            cuiLabel1.TabIndex = 14;
            cuiLabel1.TabStop = false;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.FromArgb(15, 23, 42);
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(30, 41, 59);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(30);
            cuiPanel1.Size = new Size(170, 536);
            cuiPanel1.TabIndex = 13;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.FromArgb(30, 41, 59);
            cuiLabel2.Content = "Cadastro de Cliente";
            cuiLabel2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.White;
            cuiLabel2.Location = new Point(432, 40);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(261, 40);
            cuiLabel2.TabIndex = 23;
            cuiLabel2.TabStop = false;
            // 
            // txtTelefone
            // 
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
            txtTelefone.Location = new Point(432, 240);
            txtTelefone.Margin = new Padding(4);
            txtTelefone.Multiline = false;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.NormalImageTint = Color.White;
            txtTelefone.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtTelefone.Padding = new Padding(16, 4, 16, 0);
            txtTelefone.PasswordChar = false;
            txtTelefone.PlaceholderColor = Color.Black;
            txtTelefone.PlaceholderText = "Digite o Telefone do Cliente (xx) xxxxx-xxxx";
            txtTelefone.Rounding = new Padding(8);
            txtTelefone.Size = new Size(280, 24);
            txtTelefone.TabIndex = 26;
            txtTelefone.TextOffset = new Size(0, 0);
            txtTelefone.UnderlinedStyle = true;
            // 
            // txtCPF
            // 
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
            txtCPF.Location = new Point(432, 320);
            txtCPF.Margin = new Padding(4);
            txtCPF.Multiline = false;
            txtCPF.Name = "txtCPF";
            txtCPF.NormalImageTint = Color.White;
            txtCPF.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtCPF.Padding = new Padding(16, 4, 16, 0);
            txtCPF.PasswordChar = false;
            txtCPF.PlaceholderColor = Color.Black;
            txtCPF.PlaceholderText = "Digite o CPF do cliente xxx.xxx.xxx-xx";
            txtCPF.Rounding = new Padding(8);
            txtCPF.Size = new Size(280, 24);
            txtCPF.TabIndex = 27;
            txtCPF.TextOffset = new Size(0, 0);
            txtCPF.UnderlinedStyle = true;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            Controls.Add(txtCPF);
            Controls.Add(txtTelefone);
            Controls.Add(cuiLabel2);
            Controls.Add(txtNome);
            Controls.Add(cuiPanel3);
            Controls.Add(cuiButton1);
            Controls.Add(cliButton1);
            Controls.Add(cuiPanel2);
            Controls.Add(cuiLabel1);
            Controls.Add(cuiPanel1);
            Name = "CadastroCliente";
            Size = new Size(985, 535);
            ResumeLayout(false);
        }

        #endregion

        private HartUI.Controls.cuiTextBox txtPreco;
        private HartUI.Controls.cuiTextBox txtNome;
        private HartUI.Controls.cuiPanel cuiPanel3;
        private HartUI.Controls.cuiButton cuiButton1;
        private HartUI.Controls.cuiButton cliButton1;
        private HartUI.Controls.cuiPanel cuiPanel2;
        private HartUI.Controls.cuiLabel cuiLabel1;
        private HartUI.Controls.cuiPanel cuiPanel1;
        private HartUI.Controls.cuiLabel cuiLabel2;
        private HartUI.Controls.cuiTextBox txtTelefone;
        private HartUI.Controls.cuiTextBox txtCPF;
    }
}
