using EmailValidation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;

namespace DomApp
{
    public partial class Login : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["DomApp"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            logar();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   

        private void logar()//Login com BD
        {
            
            string loginParametro, senhaParametro;

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open(); // Abre a conexão com o banco de dados
                    string query = "SELECT * FROM usuarios WHERE login = @username AND senha = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtLogin.Text); //Passa valor de forma indireta, para proteger o dado
                    cmd.Parameters.AddWithValue("@password", txtSenha.Text); // Passa valor de forma indireta, para proteger o dado
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows) 
                    {
                        loginParametro = txtLogin.Text;
                        senhaParametro = txtSenha.Text;
                        Produtos clientes = new Produtos(loginParametro,senhaParametro);
                        this.Hide();
                        clientes.Show();

                    }
                    else
                    {
                        // Login falhou
                        MessageBox.Show("Usuário ou senha incorretos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }

            }
        }
    }
}
