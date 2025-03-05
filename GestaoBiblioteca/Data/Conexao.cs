using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca.Data
{
    public class Conexao
    {
        static MySqlConnection _conexao;
        static string strconexao = "server=localhost;port=3306;uid=root;pwd=danciguer16;database=trabalho_interdisciplinar";

        public static MySqlConnection Conectar()
        {
            try
            {
                _conexao = new MySqlConnection(strconexao);
                _conexao.Open();
                //Console.WriteLine("Conexão realizada com sucesso!");

                return _conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar com o Banco de Dados!" + ex.Message);
            }

        }
    }
}
