using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DomApp
{
    partial class Produtos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlNav = new Panel();
            pnlOpcoes = new Panel();
            btnBuscarProdutos = new System.Windows.Forms.Button();
            btnCadastrarProdutos = new System.Windows.Forms.Button();
            btnVisualizarPdt = new System.Windows.Forms.Button();
            label1 = new Label();
            lblLogin = new Label();
            pnlCadProduto = new Panel();
            cmbTipo = new System.Windows.Forms.ComboBox();
            btnCadastrar = new System.Windows.Forms.Button();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtQuantidade = new System.Windows.Forms.TextBox();
            txtValorVendaMedio = new System.Windows.Forms.TextBox();
            txtValorCompraMedio = new System.Windows.Forms.TextBox();
            txtNomePdt = new System.Windows.Forms.TextBox();
            pnlVisualizarPdt = new Panel();
            pnlDGVVisualizarPdt = new Panel();
            dgvListaProdutos = new DataGridView();
            pnlTitulo = new Panel();
            label7 = new Label();
            pnlBuscarProdutos = new Panel();
            panel1 = new Panel();
            dgvBuscaDeProdutos = new DataGridView();
            panel2 = new Panel();
            cmbBuscaTipo = new System.Windows.Forms.ComboBox();
            label9 = new Label();
            txtBuscaNome = new System.Windows.Forms.TextBox();
            label13 = new Label();
            txtBuscaId = new System.Windows.Forms.TextBox();
            label12 = new Label();
            txtBuscaQtdMaiorQue = new System.Windows.Forms.TextBox();
            label11 = new Label();
            txtBuscaQtdMenorQue = new System.Windows.Forms.TextBox();
            label10 = new Label();
            btnBuscar = new System.Windows.Forms.Button();
            pnlNav.SuspendLayout();
            pnlOpcoes.SuspendLayout();
            pnlCadProduto.SuspendLayout();
            pnlVisualizarPdt.SuspendLayout();
            pnlDGVVisualizarPdt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProdutos).BeginInit();
            pnlTitulo.SuspendLayout();
            pnlBuscarProdutos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuscaDeProdutos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Lime;
            pnlNav.Controls.Add(pnlOpcoes);
            pnlNav.Controls.Add(label1);
            pnlNav.Controls.Add(lblLogin);
            pnlNav.Dock = DockStyle.Top;
            pnlNav.ForeColor = Color.White;
            pnlNav.Location = new Point(0, 0);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(1519, 100);
            pnlNav.TabIndex = 0;
            // 
            // pnlOpcoes
            // 
            pnlOpcoes.BackColor = Color.Transparent;
            pnlOpcoes.Controls.Add(btnBuscarProdutos);
            pnlOpcoes.Controls.Add(btnCadastrarProdutos);
            pnlOpcoes.Controls.Add(btnVisualizarPdt);
            pnlOpcoes.Location = new Point(19, 12);
            pnlOpcoes.Name = "pnlOpcoes";
            pnlOpcoes.Size = new Size(284, 77);
            pnlOpcoes.TabIndex = 3;
            // 
            // btnBuscarProdutos
            // 
            btnBuscarProdutos.ForeColor = Color.Black;
            btnBuscarProdutos.Location = new Point(200, 17);
            btnBuscarProdutos.Name = "btnBuscarProdutos";
            btnBuscarProdutos.Size = new Size(80, 41);
            btnBuscarProdutos.TabIndex = 2;
            btnBuscarProdutos.Text = "Buscar Produtos";
            btnBuscarProdutos.UseVisualStyleBackColor = true;
            btnBuscarProdutos.Click += btnBuscarProdutos_Click;
            // 
            // btnCadastrarProdutos
            // 
            btnCadastrarProdutos.ForeColor = Color.Black;
            btnCadastrarProdutos.Location = new Point(99, 17);
            btnCadastrarProdutos.Name = "btnCadastrarProdutos";
            btnCadastrarProdutos.Size = new Size(80, 41);
            btnCadastrarProdutos.TabIndex = 2;
            btnCadastrarProdutos.Text = "Cadastrar Produtos";
            btnCadastrarProdutos.UseVisualStyleBackColor = true;
            btnCadastrarProdutos.Click += btnCadastrarProdutos_Click;
            // 
            // btnVisualizarPdt
            // 
            btnVisualizarPdt.ForeColor = Color.Black;
            btnVisualizarPdt.Location = new Point(3, 17);
            btnVisualizarPdt.Name = "btnVisualizarPdt";
            btnVisualizarPdt.Size = new Size(80, 41);
            btnVisualizarPdt.TabIndex = 2;
            btnVisualizarPdt.Text = "Visualizar Produtos";
            btnVisualizarPdt.UseVisualStyleBackColor = true;
            btnVisualizarPdt.Click += btnVisualizarPdt_Click_2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(617, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 37);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Produtos";
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(714, 55);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 21);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "TEST";
            // 
            // pnlCadProduto
            // 
            pnlCadProduto.BackColor = SystemColors.ControlDark;
            pnlCadProduto.Controls.Add(cmbTipo);
            pnlCadProduto.Controls.Add(btnCadastrar);
            pnlCadProduto.Controls.Add(label5);
            pnlCadProduto.Controls.Add(label6);
            pnlCadProduto.Controls.Add(label4);
            pnlCadProduto.Controls.Add(label3);
            pnlCadProduto.Controls.Add(label2);
            pnlCadProduto.Controls.Add(txtQuantidade);
            pnlCadProduto.Controls.Add(txtValorVendaMedio);
            pnlCadProduto.Controls.Add(txtValorCompraMedio);
            pnlCadProduto.Controls.Add(txtNomePdt);
            pnlCadProduto.Dock = DockStyle.Fill;
            pnlCadProduto.Location = new Point(0, 100);
            pnlCadProduto.Name = "pnlCadProduto";
            pnlCadProduto.Size = new Size(1519, 631);
            pnlCadProduto.TabIndex = 1;
            pnlCadProduto.Visible = false;
            // 
            // cmbTipo
            // 
            cmbTipo.AutoCompleteCustomSource.AddRange(new string[] { "Cereal", "Laticíneos", "Test", "Test1" });
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Cereal", "Laticínios", "Test", "Test1" });
            cmbTipo.Location = new Point(556, 66);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(502, 202);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 134);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 3;
            label5.Text = "Quantidade em estoque";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(556, 36);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 3;
            label6.Text = "Tipo de Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 36);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 3;
            label4.Text = "Valor de Venda Médio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 119);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 3;
            label3.Text = "Valor de Compra Médio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 36);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome do Produto";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(324, 170);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 0;
            // 
            // txtValorVendaMedio
            // 
            txtValorVendaMedio.Location = new Point(324, 66);
            txtValorVendaMedio.Name = "txtValorVendaMedio";
            txtValorVendaMedio.Size = new Size(100, 23);
            txtValorVendaMedio.TabIndex = 0;
            // 
            // txtValorCompraMedio
            // 
            txtValorCompraMedio.Location = new Point(85, 170);
            txtValorCompraMedio.Name = "txtValorCompraMedio";
            txtValorCompraMedio.Size = new Size(100, 23);
            txtValorCompraMedio.TabIndex = 0;
            // 
            // txtNomePdt
            // 
            txtNomePdt.Location = new Point(85, 66);
            txtNomePdt.Name = "txtNomePdt";
            txtNomePdt.Size = new Size(100, 23);
            txtNomePdt.TabIndex = 0;
            // 
            // pnlVisualizarPdt
            // 
            pnlVisualizarPdt.BackColor = Color.OrangeRed;
            pnlVisualizarPdt.BackgroundImageLayout = ImageLayout.Zoom;
            pnlVisualizarPdt.Controls.Add(pnlDGVVisualizarPdt);
            pnlVisualizarPdt.Controls.Add(pnlTitulo);
            pnlVisualizarPdt.Dock = DockStyle.Fill;
            pnlVisualizarPdt.ForeColor = SystemColors.ActiveCaptionText;
            pnlVisualizarPdt.Location = new Point(0, 100);
            pnlVisualizarPdt.Name = "pnlVisualizarPdt";
            pnlVisualizarPdt.Size = new Size(1519, 631);
            pnlVisualizarPdt.TabIndex = 2;
            pnlVisualizarPdt.Visible = false;
            // 
            // pnlDGVVisualizarPdt
            // 
            pnlDGVVisualizarPdt.BackColor = Color.Snow;
            pnlDGVVisualizarPdt.Controls.Add(dgvListaProdutos);
            pnlDGVVisualizarPdt.Dock = DockStyle.Fill;
            pnlDGVVisualizarPdt.Location = new Point(0, 117);
            pnlDGVVisualizarPdt.Name = "pnlDGVVisualizarPdt";
            pnlDGVVisualizarPdt.Padding = new Padding(5);
            pnlDGVVisualizarPdt.Size = new Size(1519, 514);
            pnlDGVVisualizarPdt.TabIndex = 5;
            // 
            // dgvListaProdutos
            // 
            dgvListaProdutos.BackgroundColor = Color.Snow;
            dgvListaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProdutos.Dock = DockStyle.Fill;
            dgvListaProdutos.GridColor = Color.SandyBrown;
            dgvListaProdutos.Location = new Point(5, 5);
            dgvListaProdutos.Name = "dgvListaProdutos";
            dgvListaProdutos.Size = new Size(1509, 504);
            dgvListaProdutos.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.DarkRed;
            pnlTitulo.Controls.Add(label7);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1519, 117);
            pnlTitulo.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(553, 44);
            label7.Name = "label7";
            label7.Size = new Size(382, 47);
            label7.TabIndex = 3;
            label7.Text = "Produtos Cadastrados";
            // 
            // pnlBuscarProdutos
            // 
            pnlBuscarProdutos.BackColor = Color.Cyan;
            pnlBuscarProdutos.Controls.Add(panel1);
            pnlBuscarProdutos.Controls.Add(panel2);
            pnlBuscarProdutos.Dock = DockStyle.Fill;
            pnlBuscarProdutos.ForeColor = SystemColors.ActiveCaptionText;
            pnlBuscarProdutos.Location = new Point(0, 100);
            pnlBuscarProdutos.Name = "pnlBuscarProdutos";
            pnlBuscarProdutos.Size = new Size(1519, 631);
            pnlBuscarProdutos.TabIndex = 3;
            pnlBuscarProdutos.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvBuscaDeProdutos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(1519, 485);
            panel1.TabIndex = 13;
            // 
            // dgvBuscaDeProdutos
            // 
            dgvBuscaDeProdutos.BackgroundColor = SystemColors.ActiveBorder;
            dgvBuscaDeProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscaDeProdutos.Dock = DockStyle.Fill;
            dgvBuscaDeProdutos.Location = new Point(0, 0);
            dgvBuscaDeProdutos.Name = "dgvBuscaDeProdutos";
            dgvBuscaDeProdutos.Size = new Size(1519, 485);
            dgvBuscaDeProdutos.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSpringGreen;
            panel2.Controls.Add(cmbBuscaTipo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtBuscaNome);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtBuscaId);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtBuscaQtdMaiorQue);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtBuscaQtdMenorQue);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(btnBuscar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1519, 146);
            panel2.TabIndex = 12;
            // 
            // cmbBuscaTipo
            // 
            cmbBuscaTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscaTipo.FormattingEnabled = true;
            cmbBuscaTipo.Items.AddRange(new object[] { "", "Cereal", "Laticínios", "Test", "Test1" });
            cmbBuscaTipo.Location = new Point(479, 44);
            cmbBuscaTipo.Name = "cmbBuscaTipo";
            cmbBuscaTipo.Size = new Size(136, 23);
            cmbBuscaTipo.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 10);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 6;
            label9.Text = "Buscar por Id";
            // 
            // txtBuscaNome
            // 
            txtBuscaNome.Location = new Point(255, 44);
            txtBuscaNome.Name = "txtBuscaNome";
            txtBuscaNome.Size = new Size(136, 23);
            txtBuscaNome.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(687, 3);
            label13.Name = "label13";
            label13.Size = new Size(128, 30);
            label13.TabIndex = 10;
            label13.Text = "Buscar por Quantidade\nMaior ou igual a";
            // 
            // txtBuscaId
            // 
            txtBuscaId.Location = new Point(17, 44);
            txtBuscaId.Name = "txtBuscaId";
            txtBuscaId.Size = new Size(136, 23);
            txtBuscaId.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(891, 0);
            label12.Name = "label12";
            label12.Size = new Size(121, 30);
            label12.TabIndex = 9;
            label12.Text = "Buscar por Quantiade\nMenor ou igual a";
            // 
            // txtBuscaQtdMaiorQue
            // 
            txtBuscaQtdMaiorQue.Location = new Point(687, 44);
            txtBuscaQtdMaiorQue.Name = "txtBuscaQtdMaiorQue";
            txtBuscaQtdMaiorQue.Size = new Size(136, 23);
            txtBuscaQtdMaiorQue.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(479, 10);
            label11.Name = "label11";
            label11.Size = new Size(90, 15);
            label11.TabIndex = 8;
            label11.Text = "Buscar por Tipo";
            // 
            // txtBuscaQtdMenorQue
            // 
            txtBuscaQtdMenorQue.Location = new Point(891, 44);
            txtBuscaQtdMenorQue.Name = "txtBuscaQtdMenorQue";
            txtBuscaQtdMenorQue.Size = new Size(136, 23);
            txtBuscaQtdMenorQue.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(254, 10);
            label10.Name = "label10";
            label10.Size = new Size(99, 15);
            label10.TabIndex = 7;
            label10.Text = "Buscar por Nome";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1210, 45);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1519, 731);
            Controls.Add(pnlBuscarProdutos);
            Controls.Add(pnlVisualizarPdt);
            Controls.Add(pnlCadProduto);
            Controls.Add(pnlNav);
            Name = "Produtos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            pnlNav.ResumeLayout(false);
            pnlNav.PerformLayout();
            pnlOpcoes.ResumeLayout(false);
            pnlCadProduto.ResumeLayout(false);
            pnlCadProduto.PerformLayout();
            pnlVisualizarPdt.ResumeLayout(false);
            pnlDGVVisualizarPdt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaProdutos).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBuscarProdutos.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBuscaDeProdutos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNav;
        private Label lblLogin;
        private Label label1;
        private Panel pnlCadProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValorVendaMedio;
        private System.Windows.Forms.TextBox txtValorCompraMedio;
        private System.Windows.Forms.TextBox txtNomePdt;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel pnlVisualizarPdt;
        private DataGridView dgvListaProdutos;
        private Label label7;
        private System.Windows.Forms.Button btnVisualizarPdt;
        private System.Windows.Forms.Button btnCadastrar;
        private Panel pnlOpcoes;
        private System.Windows.Forms.Button btnCadastrarProdutos;
        private System.Windows.Forms.Button btnBuscarProdutos;
        private Panel pnlBuscarProdutos;
        private System.Windows.Forms.TextBox txtBuscaQtdMenorQue;
        private System.Windows.Forms.TextBox txtBuscaQtdMaiorQue;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnBuscar;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private DataGridView dgvBuscaDeProdutos;
        private Panel pnlTitulo;
        private Panel panel2;
        private Panel pnlDGVVisualizarPdt;
        private Panel panel1;
        private System.Windows.Forms.ComboBox txtBuscaTipo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbBuscaTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}