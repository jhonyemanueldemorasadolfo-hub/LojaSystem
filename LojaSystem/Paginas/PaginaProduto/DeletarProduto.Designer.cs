namespace LojaSystem.Paginas.PaginaProduto
{
    partial class DeletarProduto
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
            cuiPanel1 = new HartUI.Controls.cuiPanel();
            cuiPanel3 = new HartUI.Controls.cuiPanel();
            cuiPanel2 = new HartUI.Controls.cuiPanel();
            txtId = new HartUI.Controls.cuiTextBox();
            cuiButton1 = new HartUI.Controls.cuiButton();
            cliButton1 = new HartUI.Controls.cuiButton();
            SuspendLayout();
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
            cuiLabel1.TabIndex = 5;
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
            cuiPanel1.TabIndex = 4;
            // 
            // cuiPanel3
            // 
            cuiPanel3.AutoScroll = true;
            cuiPanel3.BackColor = Color.FromArgb(30, 41, 59);
            cuiPanel3.Location = new Point(400, 104);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.FromArgb(15, 23, 42);
            cuiPanel3.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel3.Rounding = new Padding(16);
            cuiPanel3.Size = new Size(368, 392);
            cuiPanel3.TabIndex = 10;
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
            cuiPanel2.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.BackgroundColor = Color.White;
            txtId.Content = "";
            txtId.FocusBackgroundColor = Color.White;
            txtId.FocusImageTint = Color.White;
            txtId.FocusOutlineColor = Color.FromArgb(61, 24, 226);
            txtId.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.Gray;
            txtId.Image = null;
            txtId.ImageExpand = new Point(0, 0);
            txtId.ImageOffset = new Point(0, 0);
            txtId.ImageTextSpacing = 8;
            txtId.Location = new Point(448, 280);
            txtId.Margin = new Padding(4);
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.NormalImageTint = Color.White;
            txtId.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtId.Padding = new Padding(16, 14, 16, 0);
            txtId.PasswordChar = false;
            txtId.PlaceholderColor = Color.LightGray;
            txtId.PlaceholderText = "Digite o Id do produto";
            txtId.Rounding = new Padding(8);
            txtId.Size = new Size(266, 45);
            txtId.TabIndex = 11;
            txtId.TextOffset = new Size(0, 0);
            txtId.UnderlinedStyle = true;
            txtId.ContentChanged += cuiTextBox1_ContentChanged;
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
            cuiButton1.Location = new Point(8, 464);
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
            cuiButton1.TabIndex = 13;
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
            cliButton1.Content = "Apagar!";
            cliButton1.DialogResult = DialogResult.None;
            cliButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cliButton1.ForeColor = Color.White;
            cliButton1.HoverBackground = Color.FromArgb(128, 255, 128);
            cliButton1.HoverForeColor = Color.White;
            cliButton1.HoverImageTint = Color.DimGray;
            cliButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cliButton1.Image = null;
            cliButton1.ImageExpand = new Point(0, 0);
            cliButton1.Location = new Point(8, 400);
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
            cliButton1.TabIndex = 12;
            cliButton1.TextAlignment = StringAlignment.Center;
            cliButton1.TextPadding = 12;
            cliButton1.TextSpacing = 2;
            cliButton1.Click += cliButton1_Click;
            // 
            // DeletarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            Controls.Add(cuiButton1);
            Controls.Add(cliButton1);
            Controls.Add(txtId);
            Controls.Add(cuiPanel3);
            Controls.Add(cuiPanel2);
            Controls.Add(cuiLabel1);
            Controls.Add(cuiPanel1);
            Name = "DeletarProduto";
            Size = new Size(985, 535);
            ResumeLayout(false);
        }

        #endregion

        private HartUI.Controls.cuiLabel cuiLabel1;
        private HartUI.Controls.cuiPanel cuiPanel1;
        private HartUI.Controls.cuiPanel cuiPanel3;
        private HartUI.Controls.cuiPanel cuiPanel2;
        private HartUI.Controls.cuiTextBox txtId;
        private HartUI.Controls.cuiButton cuiButton1;
        private HartUI.Controls.cuiButton cliButton1;
    }
}
