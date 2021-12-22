using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPoo
{
    internal class Calculadora
    {
        public double n1 { get; set; }
        public double n2 { get; set; }
        public double resp { get; set; }

        public void somar()
        {
            resp = n1 + n2;
        }
        public void subtrair()
        {
            resp = n1 - n2;
        }
        public void multiplicar()
        {
            resp = n1 * n2;
        }
        public void dividir()
        {
            resp = n1 / n2;
        }

    }
}
