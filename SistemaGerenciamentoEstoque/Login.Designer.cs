namespace DomApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pnbLogin = new Panel();
            pictureBox1 = new PictureBox();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            lblLogin = new Label();
            lblSenha = new Label();
            btnEntrar = new Button();
            toolTip1 = new ToolTip(components);
            btnSair = new Button();
            pnbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnbLogin
            // 
            pnbLogin.BackColor = Color.LightGreen;
            pnbLogin.Controls.Add(pictureBox1);
            pnbLogin.Dock = DockStyle.Left;
            pnbLogin.Location = new Point(0, 0);
            pnbLogin.Name = "pnbLogin";
            pnbLogin.Size = new Size(550, 661);
            pnbLogin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Top;
            txtLogin.Font = new Font("Segoe UI", 11.25F);
            txtLogin.Location = new Point(765, 165);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Digite seu login";
            txtLogin.Size = new Size(200, 27);
            txtLogin.TabIndex = 0;
            toolTip1.SetToolTip(txtLogin, "Clique para sair");
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top;
            txtSenha.Font = new Font("Segoe UI", 11.25F);
            txtSenha.Location = new Point(765, 245);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Size = new Size(200, 27);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblLogin.Location = new Point(765, 145);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(43, 17);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Top;
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblSenha.Location = new Point(765, 225);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(45, 17);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Top;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(765, 352);
            btnEntrar.Margin = new Padding(0);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(200, 37);
            btnEntrar.TabIndex = 2;
            btnEntrar.Tag = "";
            btnEntrar.Text = "Entrar";
            btnEntrar.TextAlign = ContentAlignment.TopCenter;
            toolTip1.SetToolTip(btnEntrar, "Clique para entrar");
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.Location = new Point(1135, 9);
            btnSair.Margin = new Padding(0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(40, 39);
            btnSair.TabIndex = 4;
            btnSair.Tag = "";
            btnSair.TextAlign = ContentAlignment.TopCenter;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1184, 661);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(pnbLogin);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnbLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnbLogin;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label lblLogin;
        private Label lblSenha;
        private Button btnEntrar;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Button btnSair;
    }
}
