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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            pnlNav = new Panel();
            btnLogout = new System.Windows.Forms.Button();
            pnlOpcoes = new Panel();
            btnPnlAlterar = new System.Windows.Forms.Button();
            btnPnlDeletar = new System.Windows.Forms.Button();
            btnBuscarProdutos = new System.Windows.Forms.Button();
            btnCadastrarProdutos = new System.Windows.Forms.Button();
            btnVisualizarPdt = new System.Windows.Forms.Button();
            label1 = new Label();
            lblLogin = new Label();
            pnlCadProduto = new Panel();
            panel4 = new Panel();
            label18 = new Label();
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
            pnlDeletar = new Panel();
            pnlConfirmarId = new Panel();
            btnSairConfirmarId = new System.Windows.Forms.Button();
            label16 = new Label();
            btnConfirmar = new System.Windows.Forms.Button();
            txtConfirmarId = new System.Windows.Forms.TextBox();
            pnlConfirmarNome = new Panel();
            btnSairConfirmarNome = new System.Windows.Forms.Button();
            label17 = new Label();
            btnConfirmarNome = new System.Windows.Forms.Button();
            txtConfirmarNome = new System.Windows.Forms.TextBox();
            btnDeletar = new System.Windows.Forms.Button();
            label15 = new Label();
            label14 = new Label();
            txtDeletarNome = new System.Windows.Forms.TextBox();
            txtDeletarId = new System.Windows.Forms.TextBox();
            panel3 = new Panel();
            label8 = new Label();
            pnlAlterar = new Panel();
            panel6 = new Panel();
            btnEnviarAlterar = new System.Windows.Forms.Button();
            label26 = new Label();
            clbAlterarProdutos = new CheckedListBox();
            pnlAtributosAlterar = new Panel();
            label24 = new Label();
            btnAlterar = new System.Windows.Forms.Button();
            txtAlterarNome = new System.Windows.Forms.TextBox();
            cmbAlterarTipo = new System.Windows.Forms.ComboBox();
            txtAlterarValorCompra = new System.Windows.Forms.TextBox();
            label20 = new Label();
            txtAlterarValorVenda = new System.Windows.Forms.TextBox();
            label21 = new Label();
            txtAlterarQtd = new System.Windows.Forms.TextBox();
            label22 = new Label();
            label23 = new Label();
            pnlConfirmarAlterar = new Panel();
            label19 = new Label();
            btnConfirmarAlteracao = new System.Windows.Forms.Button();
            txtConfirmarIdAlterar = new System.Windows.Forms.TextBox();
            panel5 = new Panel();
            label25 = new Label();
            pnlNav.SuspendLayout();
            pnlOpcoes.SuspendLayout();
            pnlCadProduto.SuspendLayout();
            panel4.SuspendLayout();
            pnlVisualizarPdt.SuspendLayout();
            pnlDGVVisualizarPdt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProdutos).BeginInit();
            pnlTitulo.SuspendLayout();
            pnlBuscarProdutos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuscaDeProdutos).BeginInit();
            panel2.SuspendLayout();
            pnlDeletar.SuspendLayout();
            pnlConfirmarId.SuspendLayout();
            pnlConfirmarNome.SuspendLayout();
            panel3.SuspendLayout();
            pnlAlterar.SuspendLayout();
            panel6.SuspendLayout();
            pnlAtributosAlterar.SuspendLayout();
            pnlConfirmarAlterar.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.OliveDrab;
            pnlNav.Controls.Add(btnLogout);
            pnlNav.Controls.Add(pnlOpcoes);
            pnlNav.Controls.Add(label1);
            pnlNav.Controls.Add(lblLogin);
            pnlNav.Dock = DockStyle.Top;
            pnlNav.ForeColor = Color.Black;
            pnlNav.Location = new Point(0, 0);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(1183, 100);
            pnlNav.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(1090, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(58, 47);
            btnLogout.TabIndex = 4;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlOpcoes
            // 
            pnlOpcoes.BackColor = Color.Transparent;
            pnlOpcoes.Controls.Add(btnPnlAlterar);
            pnlOpcoes.Controls.Add(btnPnlDeletar);
            pnlOpcoes.Controls.Add(btnBuscarProdutos);
            pnlOpcoes.Controls.Add(btnCadastrarProdutos);
            pnlOpcoes.Controls.Add(btnVisualizarPdt);
            pnlOpcoes.Location = new Point(19, 12);
            pnlOpcoes.Name = "pnlOpcoes";
            pnlOpcoes.Size = new Size(484, 77);
            pnlOpcoes.TabIndex = 3;
            // 
            // btnPnlAlterar
            // 
            btnPnlAlterar.ForeColor = Color.Black;
            btnPnlAlterar.Location = new Point(395, 17);
            btnPnlAlterar.Name = "btnPnlAlterar";
            btnPnlAlterar.Size = new Size(75, 44);
            btnPnlAlterar.TabIndex = 4;
            btnPnlAlterar.Text = "Alterar Produtos";
            btnPnlAlterar.UseVisualStyleBackColor = true;
            btnPnlAlterar.Click += btnPnlAlterar_Click;
            // 
            // btnPnlDeletar
            // 
            btnPnlDeletar.ForeColor = Color.Black;
            btnPnlDeletar.Location = new Point(296, 17);
            btnPnlDeletar.Name = "btnPnlDeletar";
            btnPnlDeletar.Size = new Size(76, 41);
            btnPnlDeletar.TabIndex = 3;
            btnPnlDeletar.Text = "Deletar Produtos";
            btnPnlDeletar.UseVisualStyleBackColor = true;
            btnPnlDeletar.Click += btnPnlDeletar_Click;
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
            label1.ForeColor = Color.BlanchedAlmond;
            label1.Location = new Point(516, 12);
            label1.Name = "label1";
            label1.Size = new Size(377, 37);
            label1.TabIndex = 1;
            label1.Text = "Gerenciamento de Produtos";
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.BlanchedAlmond;
            lblLogin.Location = new Point(615, 52);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 21);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "TEST";
            // 
            // pnlCadProduto
            // 
            pnlCadProduto.BackColor = SystemColors.ControlDark;
            pnlCadProduto.Controls.Add(panel4);
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
            pnlCadProduto.Size = new Size(1183, 507);
            pnlCadProduto.TabIndex = 1;
            pnlCadProduto.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Goldenrod;
            panel4.Controls.Add(label18);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1183, 100);
            panel4.TabIndex = 5;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(438, 25);
            label18.Name = "label18";
            label18.Size = new Size(377, 47);
            label18.TabIndex = 1;
            label18.Text = "Cadastro de Produtos";
            // 
            // cmbTipo
            // 
            cmbTipo.AutoCompleteCustomSource.AddRange(new string[] { "Cereal", "Laticíneos", "Test", "Test1" });
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 11.25F);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Cereal", "Laticínios", "Test", "Test1" });
            cmbTipo.Location = new Point(374, 316);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(150, 28);
            cmbTipo.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(652, 314);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(104, 28);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(374, 210);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 3;
            label5.Text = "Quantidade em estoque";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(374, 284);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 3;
            label6.Text = "Tipo de Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(635, 210);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 3;
            label4.Text = "Valor de Venda Médio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(635, 122);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 3;
            label3.Text = "Valor de Compra Médio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(374, 122);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 3;
            label2.Text = "Nome do Produto";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 11.25F);
            txtQuantidade.Location = new Point(374, 239);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PlaceholderText = "Ex.: 35";
            txtQuantidade.Size = new Size(150, 27);
            txtQuantidade.TabIndex = 0;
            // 
            // txtValorVendaMedio
            // 
            txtValorVendaMedio.Font = new Font("Segoe UI", 11.25F);
            txtValorVendaMedio.Location = new Point(635, 239);
            txtValorVendaMedio.Name = "txtValorVendaMedio";
            txtValorVendaMedio.Size = new Size(150, 27);
            txtValorVendaMedio.TabIndex = 0;
            txtValorVendaMedio.Text = "0,00";
            txtValorVendaMedio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtValorCompraMedio
            // 
            txtValorCompraMedio.Font = new Font("Segoe UI", 11.25F);
            txtValorCompraMedio.Location = new Point(635, 152);
            txtValorCompraMedio.Name = "txtValorCompraMedio";
            txtValorCompraMedio.Size = new Size(150, 27);
            txtValorCompraMedio.TabIndex = 0;
            txtValorCompraMedio.Text = "0,00";
            txtValorCompraMedio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNomePdt
            // 
            txtNomePdt.Font = new Font("Segoe UI", 11.25F);
            txtNomePdt.Location = new Point(374, 152);
            txtNomePdt.Name = "txtNomePdt";
            txtNomePdt.PlaceholderText = "Ex.: Feijão";
            txtNomePdt.Size = new Size(150, 27);
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
            pnlVisualizarPdt.Size = new Size(1183, 507);
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
            pnlDGVVisualizarPdt.Size = new Size(1183, 390);
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
            dgvListaProdutos.Size = new Size(1173, 380);
            dgvListaProdutos.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.Goldenrod;
            pnlTitulo.Controls.Add(label7);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1183, 117);
            pnlTitulo.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(421, 33);
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
            pnlBuscarProdutos.Size = new Size(1183, 507);
            pnlBuscarProdutos.TabIndex = 3;
            pnlBuscarProdutos.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvBuscaDeProdutos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 391);
            panel1.TabIndex = 13;
            // 
            // dgvBuscaDeProdutos
            // 
            dgvBuscaDeProdutos.BackgroundColor = SystemColors.ActiveBorder;
            dgvBuscaDeProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscaDeProdutos.Dock = DockStyle.Fill;
            dgvBuscaDeProdutos.Location = new Point(0, 0);
            dgvBuscaDeProdutos.Name = "dgvBuscaDeProdutos";
            dgvBuscaDeProdutos.Size = new Size(1183, 391);
            dgvBuscaDeProdutos.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
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
            panel2.Size = new Size(1183, 116);
            panel2.TabIndex = 12;
            // 
            // cmbBuscaTipo
            // 
            cmbBuscaTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscaTipo.Font = new Font("Segoe UI", 11.25F);
            cmbBuscaTipo.FormattingEnabled = true;
            cmbBuscaTipo.Items.AddRange(new object[] { "", "Cereal", "Laticínios", "Test", "Test1" });
            cmbBuscaTipo.Location = new Point(479, 44);
            cmbBuscaTipo.Name = "cmbBuscaTipo";
            cmbBuscaTipo.Size = new Size(136, 28);
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
            txtBuscaNome.Font = new Font("Segoe UI", 11.25F);
            txtBuscaNome.Location = new Point(255, 44);
            txtBuscaNome.Name = "txtBuscaNome";
            txtBuscaNome.PlaceholderText = "Digite o Nome";
            txtBuscaNome.Size = new Size(136, 27);
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
            txtBuscaId.Font = new Font("Segoe UI", 11.25F);
            txtBuscaId.Location = new Point(17, 44);
            txtBuscaId.Name = "txtBuscaId";
            txtBuscaId.PlaceholderText = "Digite o Id";
            txtBuscaId.Size = new Size(136, 27);
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
            txtBuscaQtdMaiorQue.Font = new Font("Segoe UI", 11.25F);
            txtBuscaQtdMaiorQue.Location = new Point(687, 44);
            txtBuscaQtdMaiorQue.Name = "txtBuscaQtdMaiorQue";
            txtBuscaQtdMaiorQue.PlaceholderText = "Ex: 10";
            txtBuscaQtdMaiorQue.Size = new Size(136, 27);
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
            txtBuscaQtdMenorQue.Font = new Font("Segoe UI", 11.25F);
            txtBuscaQtdMenorQue.Location = new Point(891, 44);
            txtBuscaQtdMenorQue.Name = "txtBuscaQtdMenorQue";
            txtBuscaQtdMenorQue.PlaceholderText = "Ex: 20";
            txtBuscaQtdMenorQue.Size = new Size(136, 27);
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
            btnBuscar.Font = new Font("Segoe UI", 11F);
            btnBuscar.Location = new Point(1073, 44);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 28);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pnlDeletar
            // 
            pnlDeletar.Controls.Add(pnlConfirmarId);
            pnlDeletar.Controls.Add(pnlConfirmarNome);
            pnlDeletar.Controls.Add(btnDeletar);
            pnlDeletar.Controls.Add(label15);
            pnlDeletar.Controls.Add(label14);
            pnlDeletar.Controls.Add(txtDeletarNome);
            pnlDeletar.Controls.Add(txtDeletarId);
            pnlDeletar.Controls.Add(panel3);
            pnlDeletar.Dock = DockStyle.Fill;
            pnlDeletar.Location = new Point(0, 100);
            pnlDeletar.Name = "pnlDeletar";
            pnlDeletar.Size = new Size(1183, 507);
            pnlDeletar.TabIndex = 12;
            // 
            // pnlConfirmarId
            // 
            pnlConfirmarId.Anchor = AnchorStyles.Top;
            pnlConfirmarId.BackColor = Color.SandyBrown;
            pnlConfirmarId.Controls.Add(btnSairConfirmarId);
            pnlConfirmarId.Controls.Add(label16);
            pnlConfirmarId.Controls.Add(btnConfirmar);
            pnlConfirmarId.Controls.Add(txtConfirmarId);
            pnlConfirmarId.Location = new Point(502, 139);
            pnlConfirmarId.Name = "pnlConfirmarId";
            pnlConfirmarId.Size = new Size(234, 194);
            pnlConfirmarId.TabIndex = 5;
            pnlConfirmarId.Visible = false;
            // 
            // btnSairConfirmarId
            // 
            btnSairConfirmarId.FlatAppearance.BorderSize = 0;
            btnSairConfirmarId.FlatStyle = FlatStyle.Flat;
            btnSairConfirmarId.Image = (Image)resources.GetObject("btnSairConfirmarId.Image");
            btnSairConfirmarId.Location = new Point(180, 157);
            btnSairConfirmarId.Name = "btnSairConfirmarId";
            btnSairConfirmarId.Size = new Size(37, 31);
            btnSairConfirmarId.TabIndex = 3;
            btnSairConfirmarId.UseVisualStyleBackColor = true;
            btnSairConfirmarId.Click += btnSairConfirmarId_Click;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(38, 21);
            label16.Name = "label16";
            label16.Size = new Size(154, 40);
            label16.TabIndex = 2;
            label16.Text = "Quer Mesmo Deletar?\r\nSe sim";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Top;
            btnConfirmar.Location = new Point(79, 112);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Deletar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtConfirmarId
            // 
            txtConfirmarId.Anchor = AnchorStyles.Top;
            txtConfirmarId.Font = new Font("Segoe UI", 11.25F);
            txtConfirmarId.Location = new Point(51, 64);
            txtConfirmarId.Name = "txtConfirmarId";
            txtConfirmarId.PlaceholderText = "Confirme o Id";
            txtConfirmarId.Size = new Size(128, 27);
            txtConfirmarId.TabIndex = 1;
            // 
            // pnlConfirmarNome
            // 
            pnlConfirmarNome.Anchor = AnchorStyles.Top;
            pnlConfirmarNome.BackColor = Color.SandyBrown;
            pnlConfirmarNome.Controls.Add(btnSairConfirmarNome);
            pnlConfirmarNome.Controls.Add(label17);
            pnlConfirmarNome.Controls.Add(btnConfirmarNome);
            pnlConfirmarNome.Controls.Add(txtConfirmarNome);
            pnlConfirmarNome.Location = new Point(502, 139);
            pnlConfirmarNome.Name = "pnlConfirmarNome";
            pnlConfirmarNome.Size = new Size(234, 194);
            pnlConfirmarNome.TabIndex = 6;
            pnlConfirmarNome.Visible = false;
            // 
            // btnSairConfirmarNome
            // 
            btnSairConfirmarNome.FlatAppearance.BorderSize = 0;
            btnSairConfirmarNome.FlatStyle = FlatStyle.Flat;
            btnSairConfirmarNome.Image = (Image)resources.GetObject("btnSairConfirmarNome.Image");
            btnSairConfirmarNome.Location = new Point(180, 155);
            btnSairConfirmarNome.Name = "btnSairConfirmarNome";
            btnSairConfirmarNome.Size = new Size(37, 33);
            btnSairConfirmarNome.TabIndex = 3;
            btnSairConfirmarNome.UseVisualStyleBackColor = true;
            btnSairConfirmarNome.Click += btnSairConfirmarNome_Click;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(38, 20);
            label17.Name = "label17";
            label17.Size = new Size(154, 40);
            label17.TabIndex = 2;
            label17.Text = "Quer Mesmo Deletar?\r\nSe sim";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirmarNome
            // 
            btnConfirmarNome.Anchor = AnchorStyles.Top;
            btnConfirmarNome.Location = new Point(74, 109);
            btnConfirmarNome.Name = "btnConfirmarNome";
            btnConfirmarNome.Size = new Size(75, 23);
            btnConfirmarNome.TabIndex = 1;
            btnConfirmarNome.Text = "Deletar";
            btnConfirmarNome.UseVisualStyleBackColor = true;
            btnConfirmarNome.Click += btnConfirmarNome_Click;
            // 
            // txtConfirmarNome
            // 
            txtConfirmarNome.Anchor = AnchorStyles.Top;
            txtConfirmarNome.Font = new Font("Segoe UI", 11.25F);
            txtConfirmarNome.Location = new Point(51, 64);
            txtConfirmarNome.Name = "txtConfirmarNome";
            txtConfirmarNome.PlaceholderText = "Confirme o Nome";
            txtConfirmarNome.Size = new Size(128, 27);
            txtConfirmarNome.TabIndex = 1;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = AnchorStyles.Top;
            btnDeletar.Location = new Point(543, 305);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 1;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F);
            label15.Location = new Point(516, 228);
            label15.Name = "label15";
            label15.Size = new Size(130, 20);
            label15.TabIndex = 4;
            label15.Text = "Deletar por Nome";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F);
            label14.Location = new Point(516, 146);
            label14.Name = "label14";
            label14.Size = new Size(102, 20);
            label14.TabIndex = 3;
            label14.Text = "Deletar por Id";
            // 
            // txtDeletarNome
            // 
            txtDeletarNome.Anchor = AnchorStyles.Top;
            txtDeletarNome.Font = new Font("Segoe UI", 11.25F);
            txtDeletarNome.Location = new Point(519, 251);
            txtDeletarNome.Name = "txtDeletarNome";
            txtDeletarNome.PlaceholderText = "Nome do Produto";
            txtDeletarNome.Size = new Size(128, 27);
            txtDeletarNome.TabIndex = 2;
            // 
            // txtDeletarId
            // 
            txtDeletarId.Anchor = AnchorStyles.Top;
            txtDeletarId.Font = new Font("Segoe UI", 11.25F);
            txtDeletarId.Location = new Point(519, 169);
            txtDeletarId.Name = "txtDeletarId";
            txtDeletarId.PlaceholderText = "Id do Produto";
            txtDeletarId.Size = new Size(128, 27);
            txtDeletarId.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Goldenrod;
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1183, 117);
            panel3.TabIndex = 0;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(449, 18);
            label8.Name = "label8";
            label8.Size = new Size(276, 45);
            label8.TabIndex = 0;
            label8.Text = "Deletar Produtos";
            // 
            // pnlAlterar
            // 
            pnlAlterar.BackColor = SystemColors.ControlDark;
            pnlAlterar.Controls.Add(panel6);
            pnlAlterar.Controls.Add(pnlAtributosAlterar);
            pnlAlterar.Controls.Add(pnlConfirmarAlterar);
            pnlAlterar.Controls.Add(panel5);
            pnlAlterar.Dock = DockStyle.Fill;
            pnlAlterar.Location = new Point(0, 100);
            pnlAlterar.Name = "pnlAlterar";
            pnlAlterar.Size = new Size(1183, 507);
            pnlAlterar.TabIndex = 6;
            pnlAlterar.Visible = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnEnviarAlterar);
            panel6.Controls.Add(label26);
            panel6.Controls.Add(clbAlterarProdutos);
            panel6.Location = new Point(167, 130);
            panel6.Name = "panel6";
            panel6.Size = new Size(282, 198);
            panel6.TabIndex = 19;
            panel6.Visible = false;
            // 
            // btnEnviarAlterar
            // 
            btnEnviarAlterar.Font = new Font("Segoe UI", 11F);
            btnEnviarAlterar.Location = new Point(200, 158);
            btnEnviarAlterar.Name = "btnEnviarAlterar";
            btnEnviarAlterar.Size = new Size(75, 31);
            btnEnviarAlterar.TabIndex = 20;
            btnEnviarAlterar.Text = "Enviar";
            btnEnviarAlterar.UseVisualStyleBackColor = true;
            btnEnviarAlterar.Click += btnEnviarAlterar_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            label26.Location = new Point(4, 14);
            label26.Name = "label26";
            label26.Size = new Size(274, 23);
            label26.TabIndex = 1;
            label26.Text = "Quais atributos você deseja alterar";
            // 
            // clbAlterarProdutos
            // 
            clbAlterarProdutos.Anchor = AnchorStyles.Top;
            clbAlterarProdutos.BackColor = SystemColors.ControlDark;
            clbAlterarProdutos.BorderStyle = BorderStyle.None;
            clbAlterarProdutos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbAlterarProdutos.FormattingEnabled = true;
            clbAlterarProdutos.Items.AddRange(new object[] { "Nome", "Quantidade em Estoque", "Tipo", "Valor de Compra", "Valor de Venda" });
            clbAlterarProdutos.Location = new Point(13, 52);
            clbAlterarProdutos.Margin = new Padding(0);
            clbAlterarProdutos.Name = "clbAlterarProdutos";
            clbAlterarProdutos.Size = new Size(193, 110);
            clbAlterarProdutos.TabIndex = 0;
            // 
            // pnlAtributosAlterar
            // 
            pnlAtributosAlterar.Anchor = AnchorStyles.Top;
            pnlAtributosAlterar.Controls.Add(label24);
            pnlAtributosAlterar.Controls.Add(btnAlterar);
            pnlAtributosAlterar.Controls.Add(txtAlterarNome);
            pnlAtributosAlterar.Controls.Add(cmbAlterarTipo);
            pnlAtributosAlterar.Controls.Add(txtAlterarValorCompra);
            pnlAtributosAlterar.Controls.Add(label20);
            pnlAtributosAlterar.Controls.Add(txtAlterarValorVenda);
            pnlAtributosAlterar.Controls.Add(label21);
            pnlAtributosAlterar.Controls.Add(txtAlterarQtd);
            pnlAtributosAlterar.Controls.Add(label22);
            pnlAtributosAlterar.Controls.Add(label23);
            pnlAtributosAlterar.Location = new Point(687, 123);
            pnlAtributosAlterar.Name = "pnlAtributosAlterar";
            pnlAtributosAlterar.Size = new Size(457, 294);
            pnlAtributosAlterar.TabIndex = 17;
            pnlAtributosAlterar.Visible = false;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top;
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 11F);
            label24.Location = new Point(12, 14);
            label24.Name = "label24";
            label24.Size = new Size(129, 20);
            label24.TabIndex = 14;
            label24.Text = "Nome do Produto";
            label24.Visible = false;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Top;
            btnAlterar.Font = new Font("Segoe UI", 11F);
            btnAlterar.Location = new Point(317, 200);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(86, 36);
            btnAlterar.TabIndex = 16;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // txtAlterarNome
            // 
            txtAlterarNome.Anchor = AnchorStyles.Top;
            txtAlterarNome.Font = new Font("Segoe UI", 11.25F);
            txtAlterarNome.Location = new Point(12, 44);
            txtAlterarNome.Name = "txtAlterarNome";
            txtAlterarNome.PlaceholderText = "Ex.: Feijão";
            txtAlterarNome.Size = new Size(150, 27);
            txtAlterarNome.TabIndex = 8;
            txtAlterarNome.Visible = false;
            // 
            // cmbAlterarTipo
            // 
            cmbAlterarTipo.Anchor = AnchorStyles.Top;
            cmbAlterarTipo.AutoCompleteCustomSource.AddRange(new string[] { "Cereal", "Laticíneos", "Test", "Test1" });
            cmbAlterarTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlterarTipo.Font = new Font("Segoe UI", 11.25F);
            cmbAlterarTipo.FormattingEnabled = true;
            cmbAlterarTipo.Items.AddRange(new object[] { "Cereal", "Laticínios", "Test", "Test1" });
            cmbAlterarTipo.Location = new Point(12, 208);
            cmbAlterarTipo.Name = "cmbAlterarTipo";
            cmbAlterarTipo.Size = new Size(150, 28);
            cmbAlterarTipo.TabIndex = 15;
            cmbAlterarTipo.Visible = false;
            // 
            // txtAlterarValorCompra
            // 
            txtAlterarValorCompra.Anchor = AnchorStyles.Top;
            txtAlterarValorCompra.Font = new Font("Segoe UI", 11.25F);
            txtAlterarValorCompra.Location = new Point(273, 44);
            txtAlterarValorCompra.Name = "txtAlterarValorCompra";
            txtAlterarValorCompra.Size = new Size(150, 27);
            txtAlterarValorCompra.TabIndex = 7;
            txtAlterarValorCompra.Text = "0,00";
            txtAlterarValorCompra.TextAlign = HorizontalAlignment.Right;
            txtAlterarValorCompra.Visible = false;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11F);
            label20.Location = new Point(12, 102);
            label20.Name = "label20";
            label20.Size = new Size(169, 20);
            label20.TabIndex = 10;
            label20.Text = "Quantidade em estoque";
            label20.Visible = false;
            // 
            // txtAlterarValorVenda
            // 
            txtAlterarValorVenda.Anchor = AnchorStyles.Top;
            txtAlterarValorVenda.Font = new Font("Segoe UI", 11.25F);
            txtAlterarValorVenda.Location = new Point(273, 131);
            txtAlterarValorVenda.Name = "txtAlterarValorVenda";
            txtAlterarValorVenda.Size = new Size(150, 27);
            txtAlterarValorVenda.TabIndex = 6;
            txtAlterarValorVenda.Text = "0,00";
            txtAlterarValorVenda.TextAlign = HorizontalAlignment.Right;
            txtAlterarValorVenda.Visible = false;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11F);
            label21.Location = new Point(12, 176);
            label21.Name = "label21";
            label21.Size = new Size(117, 20);
            label21.TabIndex = 11;
            label21.Text = "Tipo de Produto";
            label21.Visible = false;
            // 
            // txtAlterarQtd
            // 
            txtAlterarQtd.Anchor = AnchorStyles.Top;
            txtAlterarQtd.Font = new Font("Segoe UI", 11.25F);
            txtAlterarQtd.Location = new Point(12, 131);
            txtAlterarQtd.Name = "txtAlterarQtd";
            txtAlterarQtd.PlaceholderText = "Ex.: 35";
            txtAlterarQtd.Size = new Size(150, 27);
            txtAlterarQtd.TabIndex = 5;
            txtAlterarQtd.Visible = false;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11F);
            label22.Location = new Point(273, 102);
            label22.Name = "label22";
            label22.Size = new Size(156, 20);
            label22.TabIndex = 12;
            label22.Text = "Valor de Venda Médio";
            label22.Visible = false;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11F);
            label23.Location = new Point(273, 14);
            label23.Name = "label23";
            label23.Size = new Size(168, 20);
            label23.TabIndex = 13;
            label23.Text = "Valor de Compra Médio";
            label23.Visible = false;
            // 
            // pnlConfirmarAlterar
            // 
            pnlConfirmarAlterar.Anchor = AnchorStyles.Top;
            pnlConfirmarAlterar.Controls.Add(label19);
            pnlConfirmarAlterar.Controls.Add(btnConfirmarAlteracao);
            pnlConfirmarAlterar.Controls.Add(txtConfirmarIdAlterar);
            pnlConfirmarAlterar.Location = new Point(502, 136);
            pnlConfirmarAlterar.Name = "pnlConfirmarAlterar";
            pnlConfirmarAlterar.Size = new Size(200, 138);
            pnlConfirmarAlterar.TabIndex = 18;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11F);
            label19.Location = new Point(46, 13);
            label19.Name = "label19";
            label19.Size = new Size(106, 20);
            label19.TabIndex = 14;
            label19.Text = "Alterar Valores";
            // 
            // btnConfirmarAlteracao
            // 
            btnConfirmarAlteracao.Anchor = AnchorStyles.Top;
            btnConfirmarAlteracao.Font = new Font("Segoe UI", 11F);
            btnConfirmarAlteracao.Location = new Point(60, 97);
            btnConfirmarAlteracao.Name = "btnConfirmarAlteracao";
            btnConfirmarAlteracao.Size = new Size(86, 36);
            btnConfirmarAlteracao.TabIndex = 16;
            btnConfirmarAlteracao.Text = "Confirmar";
            btnConfirmarAlteracao.UseVisualStyleBackColor = true;
            btnConfirmarAlteracao.Click += btnConfirmarAlteracao_Click;
            // 
            // txtConfirmarIdAlterar
            // 
            txtConfirmarIdAlterar.Anchor = AnchorStyles.Top;
            txtConfirmarIdAlterar.Font = new Font("Segoe UI", 11.25F);
            txtConfirmarIdAlterar.Location = new Point(25, 50);
            txtConfirmarIdAlterar.Name = "txtConfirmarIdAlterar";
            txtConfirmarIdAlterar.PlaceholderText = "Id do Produto";
            txtConfirmarIdAlterar.Size = new Size(150, 27);
            txtConfirmarIdAlterar.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Goldenrod;
            panel5.Controls.Add(label25);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1183, 100);
            panel5.TabIndex = 0;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top;
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(502, 24);
            label25.Name = "label25";
            label25.Size = new Size(232, 37);
            label25.TabIndex = 0;
            label25.Text = "Alterar Produtos";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 607);
            ControlBox = false;
            Controls.Add(pnlAlterar);
            Controls.Add(pnlBuscarProdutos);
            Controls.Add(pnlCadProduto);
            Controls.Add(pnlDeletar);
            Controls.Add(pnlVisualizarPdt);
            Controls.Add(pnlNav);
            Name = "Produtos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            pnlNav.ResumeLayout(false);
            pnlNav.PerformLayout();
            pnlOpcoes.ResumeLayout(false);
            pnlCadProduto.ResumeLayout(false);
            pnlCadProduto.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
            pnlDeletar.ResumeLayout(false);
            pnlDeletar.PerformLayout();
            pnlConfirmarId.ResumeLayout(false);
            pnlConfirmarId.PerformLayout();
            pnlConfirmarNome.ResumeLayout(false);
            pnlConfirmarNome.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlAlterar.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pnlAtributosAlterar.ResumeLayout(false);
            pnlAtributosAlterar.PerformLayout();
            pnlConfirmarAlterar.ResumeLayout(false);
            pnlConfirmarAlterar.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbBuscaTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnPnlDeletar;
        private Panel pnlDeletar;
        private Label label14;
        private System.Windows.Forms.TextBox txtDeletarId;
        private Panel panel3;
        private Label label8;
        private Panel pnlConfirmarId;
        private System.Windows.Forms.TextBox txtConfirmarId;
        private System.Windows.Forms.Button btnDeletar;
        private Label label16;
        private System.Windows.Forms.Button btnConfirmar;
        private Label label15;
        private System.Windows.Forms.TextBox txtDeletarNome;
        private Panel pnlConfirmarNome;
        private Label label17;
        private System.Windows.Forms.Button btnConfirmarNome;
        private System.Windows.Forms.TextBox txtConfirmarNome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSairConfirmarNome;
        private System.Windows.Forms.Button btnSairConfirmarId;
        private Panel panel4;
        private Label label18;
        private Panel pnlAlterar;
        private System.Windows.Forms.ComboBox cmbAlterarTipo;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private System.Windows.Forms.TextBox txtAlterarQtd;
        private System.Windows.Forms.TextBox txtAlterarValorVenda;
        private System.Windows.Forms.TextBox txtAlterarValorCompra;
        private System.Windows.Forms.TextBox txtAlterarNome;
        private Panel panel5;
        private Panel pnlAtributosAlterar;
        private System.Windows.Forms.Button btnAlterar;
        private Panel pnlConfirmarAlterar;
        private Label label19;
        private System.Windows.Forms.Button btnConfirmarAlteracao;
        private System.Windows.Forms.TextBox txtConfirmarIdAlterar;
        private Label label25;
        private System.Windows.Forms.Button btnPnlAlterar;
        private Panel panel6;
        private CheckedListBox clbAlterarProdutos;
        private Label label26;
        private System.Windows.Forms.Button btnEnviarAlterar;
    }
}