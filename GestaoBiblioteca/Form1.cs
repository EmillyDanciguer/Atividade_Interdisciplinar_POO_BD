using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoBiblioteca.Formulario;
using MySql.Data.MySqlClient;

namespace GestaoBiblioteca
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrarAutor frm = new FormCadastrarAutor();
            frm.ShowDialog();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            FormAtualizarAutor frm = new FormAtualizarAutor();
            frm.ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FormConsultarAutorcs frm = new FormConsultarAutorcs();
            frm.ShowDialog();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            FormExcluirAutor frm = new FormExcluirAutor();
            frm.ShowDialog();
        }
    }
}
