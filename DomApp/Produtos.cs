using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace DomApp
{
    public partial class Produtos : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["DomApp"].ConnectionString;

        public Produtos()
        {
            InitializeComponent();
            //InicializarTextBoxMonetario(txtValorCompraMedio);
            //InicializarTextBoxMonetario(txtValorVendaMedio);
        }

        public Produtos(string loginParametro, string senhaParametro)//Construtor que passa parâmetro do login
        {
            InitializeComponent();
            lblLogin.Text = $"Bem Vindo {loginParametro}";
        }

        private void CadProdutos() //Cadastro de produtos no BD
        {

            using (MySqlConnection conexaoObj = new MySqlConnection(conexao))
            {
                if (txtNomePdt.Text != string.Empty && txtValorCompraMedio.Text != string.Empty
                        && txtValorVendaMedio.Text != string.Empty && txtQuantidade.Text != string.Empty && cmbTipo.Text != string.Empty)
                {
                    try
                    {

                        //Variavel que armazena a query de inserção de dados.
                        string query = "Insert Into produtos (nome, valorCompra, valorVenda, quantidade, tipo)" +
                                        " Values (@nomePdt, @valorCompraMedio, @valorVendaMedio, @quantidade, @tipo)";

                        MySqlCommand cmd = new MySqlCommand(query, conexaoObj); //Instância objeto MySqlCommand, passando a query e a conexão como parâmetros.

                        conexaoObj.Open(); //Abre conexão com o banco de dados.

                        //Põe valores que o usuário digitou nos parâmetros da query.
                        cmd.Parameters.AddWithValue("@nomePdt", txtNomePdt.Text);
                        cmd.Parameters.AddWithValue("@valorCompraMedio", Convert.ToDecimal(txtValorCompraMedio.Text));
                        cmd.Parameters.AddWithValue("@valorVendaMedio", Convert.ToDecimal(txtValorVendaMedio.Text));
                        cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQuantidade.Text));
                        cmd.Parameters.AddWithValue("@tipo", cmbTipo.Text);

                        cmd.ExecuteNonQuery(); //Executa a query.
                        MessageBox.Show("Cadastro Feito com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao cadastrar produto: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos para cadastrar um produto.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e) //Chama CadProdutos().
        {
            CadProdutos();
        }

        private void VisualizarProdutos()
        {

            if (pnlVisualizarPdt.Visible == true)
            {
                btnVisualizarPdt.Text = "Visualizar Produtos";
                pnlVisualizarPdt.Visible = false;
            }

            else
            {

                using (MySqlConnection conexaoObj = new MySqlConnection(conexao))
                {
                    conexaoObj.Open(); //Abre a conexão com o BD.

                    string query = "SELECT * FROM produtos"; //Armazena a query de seleção de dados.

                    //Instâcia objeto MySqlDataAdapter, passando a query e a conexão como parâmetros.
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexaoObj);

                    DataTable tabela = new DataTable(); //Cria tabela que vai armaenar os dados do banco de dados.

                    adapter.Fill(tabela); //Preenche as linhas da tabela com dados do BD.
                    dgvListaProdutos.DataSource = tabela;//DataGriView recebe os dados.
                }
                pnlDeletar.Visible = false;
                pnlCadProduto.Visible = false;
                pnlBuscarProdutos.Visible = false;
                pnlVisualizarPdt.Visible = true;
                pnlAlterar.Visible = false;
                btnVisualizarPdt.Text = "Esconder Produtos";

            }

        }

        private void btnVisualizarPdt_Click_2(object sender, EventArgs e) //Abre Pnl de Visualizar produtos e chama VisualizarProdutos().
        {
            VisualizarProdutos();
        }

        private void btnCadastrarProdutos_Click(object sender, EventArgs e) //Abre Pnl de cadastro de produtos.
        {

            if (pnlCadProduto.Visible == false)
            {
                pnlDeletar.Visible = false;
                pnlVisualizarPdt.Visible = false;
                pnlBuscarProdutos.Visible = false;
                pnlCadProduto.Visible = true;
                pnlAlterar.Visible = false;
            }

            else
            {
                pnlCadProduto.Visible = false;
            }
        }

        private void BuscarProdutos() //Método de buscar produtos no BD.
        {
            using (MySqlConnection conexaoBuscarProdutos = new MySqlConnection(conexao))
            {
                try
                {
                    if (txtBuscaId.Text != string.Empty)
                    {
                        conexaoBuscarProdutos.Open(); //Abre a conexão com o banco de dados.
                        string query = "Select * From produtos Where id = @id;";
                        MySqlCommand cmd = new MySqlCommand(query, conexaoBuscarProdutos);
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtBuscaId.Text));

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        DataTable tabela = new DataTable(); //Cria tabela que vai armaenar os dados do banco de dados.
                        adapter.Fill(tabela); //Preenche as linhas da tabela com dados do BD.
                        dgvBuscaDeProdutos.DataSource = tabela;//DataGridView recebe os dados.
                    }

                    else if (txtBuscaNome.Text != string.Empty)
                    {
                        conexaoBuscarProdutos.Open(); //Abre a conexão com o banco de dados.
                        string query = "Select * From produtos Where nome LIKE @nome;"; //Like compara textos
                        MySqlCommand cmd = new MySqlCommand(query, conexaoBuscarProdutos);
                        cmd.Parameters.AddWithValue("@nome", "%" + txtBuscaNome.Text + "%"); //Jeito de verificar textos.

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        DataTable tabela = new DataTable(); //Cria tabela que vai armaenar os dados do banco de dados.
                        adapter.Fill(tabela); //Preenche as linhas da tabela com dados do BD.
                        dgvBuscaDeProdutos.DataSource = tabela;//DataGridView recebe os dados.
                    }

                    else if (cmbBuscaTipo.Text != string.Empty)
                    {
                        conexaoBuscarProdutos.Open(); //Abre a conexão com o banco de dados.
                        string query = "Select * From produtos Where Tipo LIKE @tipo;"; //Like compara textos
                        MySqlCommand cmd = new MySqlCommand(query, conexaoBuscarProdutos);
                        cmd.Parameters.AddWithValue("@tipo", "%" + cmbBuscaTipo.Text + "%"); //Jeito de verificar textos.

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        DataTable tabela = new DataTable(); //Cria tabela que vai armaenar os dados do banco de dados.
                        adapter.Fill(tabela); //Preenche as linhas da tabela com dados do BD.
                        dgvBuscaDeProdutos.DataSource = tabela;//DataGridView recebe os dados.
                    }

                    else if (txtBuscaQtdMaiorQue.Text != string.Empty && txtBuscaQtdMenorQue.Text != string.Empty)
                    {

                        conexaoBuscarProdutos.Open(); //Abre a conexão com o banco de dados.
                        string query = "Select * From produtos WHERE Quantidade BETWEEN @quantidadeMaiorQue AND @quantidadeMenorQue;";
                        MySqlCommand cmd = new MySqlCommand(query, conexaoBuscarProdutos);
                        cmd.Parameters.AddWithValue("@quantidadeMaiorQue", Convert.ToInt32(txtBuscaQtdMaiorQue.Text));
                        cmd.Parameters.AddWithValue("@quantidadeMenorQue", Convert.ToInt32(txtBuscaQtdMenorQue.Text));

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        DataTable tabela = new DataTable(); //Cria tabela que vai armaenar os dados do banco de dados.
                        adapter.Fill(tabela); //Preenche as linhas da tabela com dados do BD.
                        dgvBuscaDeProdutos.DataSource = tabela;//DataGridView recebe os dados.

                    }

                    else if (txtBuscaQtdMaiorQue.Text != string.Empty)
                    {
                        conexaoBuscarProdutos.Open(); //Abre a conexão com o banco de dados.
                        string query = "Select * From produtos Where Quantidade >= @quantidadeMaiorQue;";
                        MySqlCommand cmd = new MySqlCommand(query, conexaoBuscarProdutos);
                        cmd.Parameters.AddWithValue("@quantidadeMaiorQue", Convert.ToInt32(txtBuscaQtdMaiorQue.Text));

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        DataTable tabela = new DataTable(); //Cria tabela que vai armaenar os dados do banco de dados.
                        adapter.Fill(tabela); //Preenche as linhas da tabela com dados do BD.
                        dgvBuscaDeProdutos.DataSource = tabela;//DataGridView recebe os dados.
                    }
                    else if (txtBuscaQtdMenorQue.Text != string.Empty)
                    {
                        conexaoBuscarProdutos.Open(); //Abre a conexão com o banco de dados.
                        string query = "Select * From produtos Where Quantidade <= @quantidadeMenorQue;";
                        MySqlCommand cmd = new MySqlCommand(query, conexaoBuscarProdutos);
                        cmd.Parameters.AddWithValue("@quantidadeMenorQue", Convert.ToInt32(txtBuscaQtdMenorQue.Text));

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        DataTable tabela = new DataTable(); //Cria tabela que vai armaenar os dados do banco de dados.
                        adapter.Fill(tabela); //Preenche as linhas da tabela com dados do BD.
                        dgvBuscaDeProdutos.DataSource = tabela;//DataGridView recebe os dados.
                    }

                    else
                    {
                        MessageBox.Show("Digite ao menos um parâmetro de busca.");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao buscar produtos: {ex.Message}");
                }


            }


        }

        private void btnBuscarProdutos_Click(object sender, EventArgs e)//Abre Pnl de Buscar Produtos
        {
            if (pnlBuscarProdutos.Visible == true)
            {
                pnlBuscarProdutos.Visible = false;
            }

            else
            {
                pnlDeletar.Visible = false;
                pnlBuscarProdutos.Visible = true;
                pnlCadProduto.Visible = false;
                pnlVisualizarPdt.Visible = false;
                pnlAlterar.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)//Chama BuscarProdutos() 
        {
            if (cmbBuscaTipo.Text == "" && txtBuscaId.Text == "" && txtBuscaNome.Text == ""
                && txtBuscaQtdMaiorQue.Text == "" && txtBuscaQtdMenorQue.Text == "") // Não permite que todos os campos estejam vazios.
            {
                MessageBox.Show("Digite ao menos um parâmetro de busca.");
            }
            else
            {
                BuscarProdutos();
            }

        }

        private void btnPnlDeletar_Click(object sender, EventArgs e) //Abre Pnl de Deletar Produtos
        {
            if (pnlDeletar.Visible == true)
            {
                pnlDeletar.Visible = false;
            }
            else
            {
                pnlDeletar.Visible = true;
                pnlBuscarProdutos.Visible = false;
                pnlCadProduto.Visible = false;
                pnlVisualizarPdt.Visible = false;
                pnlAlterar.Visible = false;

            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)//Abre Pnl de Confirmar deleção, seja de Nome ou Id
        {
            if (txtDeletarId.Text == string.Empty && txtDeletarNome.Text == string.Empty)
            {
                MessageBox.Show("Digite o ID ou o nome do produto que deseja deletar.");
                return;
            }
            if (txtDeletarId.Text != string.Empty && txtDeletarNome.Text != string.Empty)
            {
                MessageBox.Show("Só é possível deletar pelo Nome OU pelo Id.");
                return;
            }
            if (txtDeletarId.Text == string.Empty)
            {
                pnlConfirmarNome.Visible = true;
            }
            else if (txtDeletarNome.Text == string.Empty)
            {
                pnlConfirmarId.Visible = true;
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)//Chama função de Remover pelo Id
        {
            RemoverId();
        }
        private void btnConfirmarNome_Click(object sender, EventArgs e)//Chama função de Remover pelo Nome
        {
            RemoverNome();
        }
        public void RemoverId()//Remover pelo Id
        {
            using (MySqlConnection conexaoRemoverId = new MySqlConnection(conexao))
            {
                if (txtDeletarId.Text == txtConfirmarId.Text)
                {
                    try
                    {
                        if (txtDeletarId.Text != string.Empty)
                        {
                            conexaoRemoverId.Open(); //Abre a conexão com o banco de dados.
                            string query = "DELETE FROM produtos WHERE id = @id;";
                            MySqlCommand cmd = new MySqlCommand(query, conexaoRemoverId);
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtDeletarId.Text));
                            int rowsAffected = cmd.ExecuteNonQuery(); //Executa a query e retorna o número de linhas afetadas.
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Produto deletado com sucesso.");
                            }
                            else
                            {
                                MessageBox.Show("Nenhum produto encontrado com o ID fornecido.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite o ID do produto que deseja deletar.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao deletar produto: {ex.Message}");
                    }
                }

                else
                {
                    MessageBox.Show("Id digitado em Confirmar Id foi diferente do escolhido!!");
                }
            }
            pnlConfirmarId.Visible = false;
        }
        public void RemoverNome()//Remover pelo Nome
        {
            using (MySqlConnection conexaoRemoverNome = new MySqlConnection(conexao))
            {

                if (txtConfirmarNome.Text == txtDeletarNome.Text)
                {
                    try
                    {
                        if (txtDeletarNome.Text != string.Empty)
                        {
                            conexaoRemoverNome.Open(); //Abre a conexão com o banco de dados.
                            string query = "DELETE FROM produtos WHERE nome = @nome;";
                            MySqlCommand cmd = new MySqlCommand(query, conexaoRemoverNome);
                            cmd.Parameters.AddWithValue("@nome", txtDeletarNome.Text);
                            int rowsAffected = cmd.ExecuteNonQuery(); //Executa a query e retorna o número de linhas afetadas.
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Produto deletado com sucesso.");
                            }
                            else
                            {
                                MessageBox.Show("Nenhum produto encontrado com o nome fornecido.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite o nome do produto que deseja deletar.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao deletar produto: {ex.Message}");
                    }
                }

                else
                {
                    MessageBox.Show("Nome digitado em Confirmar Nome foi diferente do escolhido!!");
                }
            }
            pnlConfirmarNome.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login fl = new Login();
            this.Hide();
            fl.Show();
        }

        private void btnSairConfirmarNome_Click(object sender, EventArgs e)
        {
            pnlConfirmarNome.Visible = false;
        }

        private void btnSairConfirmarId_Click(object sender, EventArgs e)
        {
            pnlConfirmarId.Visible = false;
        }
        private void btnPnlAlterar_Click(object sender, EventArgs e)
        {
            if (pnlAlterar.Visible == false)
            {
                pnlDeletar.Visible = false;
                pnlBuscarProdutos.Visible = false;
                pnlCadProduto.Visible = false;
                pnlVisualizarPdt.Visible = false;
                pnlAlterar.Visible = true;
            }
            else
            {
                pnlAlterar.Visible = false;
            }
        }
        private void btnConfirmarAlteracao_Click(object sender, EventArgs e)
        {
            if (txtConfirmarIdAlterar.Text != string.Empty)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(conexao)) //Cria variavel para abrir conexão com o BD
                    {
                        conn.Open(); // Abre a conexão com o banco de dados
                        string queryId = "SELECT * FROM produtos WHERE id = @id"; //Armazena a query, só para passar o @id como parâmetro

                        using (MySqlCommand cmdAlterar = new MySqlCommand(queryId, conn))
                        {
                            cmdAlterar.Parameters.AddWithValue("@id", Convert.ToInt32(txtConfirmarIdAlterar.Text)); //parâmetro recebe oque foi digitado.
                            object resultado = cmdAlterar.ExecuteScalar(); //Se existir no BD, retorna o valor do Id, se não existir, retorna null.

                            if (resultado != null) //poderia ser resultado == txtConfirmarIdAlterar.Text
                            {
                                panel6.Visible = true;
                                pnlConfirmarAlterar.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Id digitado para alteração não existe no banco de dados.");
                            }

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao confirmar Id ou para alterar o Id" + ex.Message);
                }

            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void Alterar()
        {
            using (MySqlConnection conexaoAlterar = new MySqlConnection(conexao))
            {
                try
                {
                    conexaoAlterar.Open(); //Abre a conexão com o banco de dados.

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao abrir conexão com o banco de dados: {ex.Message}");
                }
            }
        }

        private void btnEnviarAlterar_Click(object sender, EventArgs e)
        {
            pnlAtributosAlterar.Visible = true;
            foreach (var item in clbAlterarProdutos.CheckedItems) //item recebe o valor de cada check selecionado
            {
                switch (item.ToString())
                {
                    case "Nome":
                        txtAlterarNome.Visible = true;
                        label24.Visible = true;
                        break;
                    case "Valor de Compra":
                        txtAlterarValorCompra.Visible = true;
                        label23.Visible = true;
                        break;
                    case "Valor de Venda":
                        label22.Visible = true;
                        txtAlterarValorVenda.Visible = true;
                        break;
                    case "Quantidade em Estoque":
                        label20.Visible = true;
                        txtAlterarQtd.Visible = true;
                        break;
                    case "Tipo":
                        cmbAlterarTipo.Visible = true;
                        label21.Visible = true;
                        break;
                    default:
                        break;
                }
            }

            if (!clbAlterarProdutos.GetItemChecked(0))
            {
                txtAlterarNome.Visible = false;
                label24.Visible = false;
            }
            else if (!clbAlterarProdutos.GetItemChecked(1))
            {                
                label20.Visible = false;
                txtAlterarQtd.Visible = false;
            }
            else if (!clbAlterarProdutos.GetItemChecked(2))
            {
                cmbAlterarTipo.Visible = false;
                label21.Visible = false;
            }
            else if (!clbAlterarProdutos.GetItemChecked(3))
            {
                txtAlterarValorCompra.Visible = false;
                label23.Visible = false;
            }
            else if (!clbAlterarProdutos.GetItemChecked(4))
            {
                label22.Visible = false;
                txtAlterarValorVenda.Visible = false;
            }
   
        }
    }
}

