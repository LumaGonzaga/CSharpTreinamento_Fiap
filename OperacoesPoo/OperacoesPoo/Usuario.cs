using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacoesPoo
{
    public class Usuario
    {   
        //Atributos
        public string nome { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        //Construtor
        //Métoodo executado quando um objeto é instanciado(criado).

        public Usuario()
        {
            this.nome = "";
            this.email = "";
            this.login = "";
            this.senha = "";
        }
        public void provarExistencia()
        {
            MessageBox.Show($"Bem vindo {this.nome}");
        }
    }
}
