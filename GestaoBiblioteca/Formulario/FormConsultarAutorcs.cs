using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoBiblioteca.Context;
using GestaoBiblioteca.mod;
using GestaoBiblioteca.Models;

namespace GestaoBiblioteca.Formulario
{
    public partial class FormConsultarAutorcs : Form
    {

        public FormConsultarAutorcs()
        {
            InitializeComponent();
            if (Context.Context.listaAutores.Any())
            {
                cbSelecao.DataSource = Context.Context.listaAutores.ToList();
            }
            else
            {
                MessageBox.Show("Não há autores cadastrados.");
            }
        }

        private void txtNacionalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbSelecao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e) //Botão Consultar
        {
            int autorSelecionado = cbSelecao.SelectedIndex;
            if (autorSelecionado > -1)
            {
                Autor autor = Context.Context.listaAutores[autorSelecionado];
                txtNome.Text = autor._nome;
                txtNacionalidade.Text = autor._nacionalidade;
                txtCpf.Text = autor._cpf;
                dtNascimento.MaxDate = autor._data_nasc;
                txtEmail.Text = autor._email;
                txtTelefone.Text = autor._telefone;

                txtNome.Text = autor._nome.ToString();

                //dtTabela.DataSource =
                //Context.Context.listaAutores.ToList();

            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNacionalidade.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
        }
    }
}
