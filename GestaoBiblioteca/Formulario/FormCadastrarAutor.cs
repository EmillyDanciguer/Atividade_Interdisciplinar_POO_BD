using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoBiblioteca.Data;
using GestaoBiblioteca.Models;
using GestaoBiblioteca.Context;
namespace GestaoBiblioteca.Formulario
{
    public partial class FormCadastrarAutor : Form
    {
        

        public FormCadastrarAutor()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNacionalidade.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Autor novoAutor = new Autor()
            {
                _nome = txtNome.Text,
                _data_nasc = dtNascimento.Value,
                _nacionalidade = txtNacionalidade.Text,
                _cpf = txtCpf.Text,
                _email = txtEmail.Text,
                _telefone = txtTelefone.Text
            };

            Context.Context.listaAutores.Add(novoAutor);
            using (MySqlConnection conexao = Conexao.Conectar())

            {
                string sql = "INSERT INTO Autor (nome, data_nasc, nacionalidade, cpf, email, telefone) VALUES (@nome, @data_nasc, @nacionalidade, @cpf, @email, @telefone)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@data_nasc", dtNascimento.Value);
                    cmd.Parameters.AddWithValue("@nacionalidade", txtNacionalidade.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Autor cadastrado com sucesso!");
                }
            }
        }
    }
}
