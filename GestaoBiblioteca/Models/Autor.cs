using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestaoBiblioteca.Models
{
    public class Autor
    { 
        public int _ID_autor { get; set; }
        public string _nome { get; set; }
        public DateTime _data_nasc { get; set; }
        public string _nacionalidade { get; set; }
        public string _cpf { get; set; }
        public string _email { get; set; }
        public string _telefone { get; set; }
    }
}
