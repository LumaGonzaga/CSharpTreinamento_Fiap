using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace SomaElementosMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            double[,] vs = new double[2,2];
            double soma = 0, somaAnt;
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    vs[i, j] = double.Parse(Interaction.InputBox($"Digite o valor da posição [{i},{j}]"));
                    somaAnt = soma;
                    soma += vs[i, j];
                    lstSoma.Items.Add($"{somaAnt.ToString()} + {vs[i, j]}= {soma.ToString()}");
                }
            }
        }
        
    }
}
