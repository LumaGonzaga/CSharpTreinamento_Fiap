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

namespace MatrizPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int[,] valores = new int[3, 2];
            int pares = 0;
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    valores[linha, coluna] = int.Parse(Interaction.InputBox($"Digite um elemento " +
                        $"na posição [{linha.ToString()} , {coluna.ToString()}]"));
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (valores[i, j] % 2 == 0)
                    {
                        pares++;
                    }
                }
            }
            MessageBox.Show($"O número de valores pares é: {pares.ToString()}");
        }
    }
}
