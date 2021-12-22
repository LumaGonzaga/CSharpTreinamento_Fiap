using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperaçõesComMatriz4x4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int[,] Matriz = new int[4, 4];
            int soma = 0, mult = 0;
            double media = 0;
            string sMult = "";


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Matriz[i, j] = int.Parse(Interaction.InputBox($"Digite um valor para a posição [{i},{j}] da matriz"));
                    if (i == 0)
                    {
                        soma += Matriz[0, j];
                    }
                    if (i == 1)
                    {
                        media += Matriz[1, j];
                    }
                    if (i == 3)
                    {
                        mult = Matriz[2, j] * Matriz[3, j];
                        sMult += mult + " - ";

                    }
                }
            }
            media = media / 4;
            MessageBox.Show($"Soma da linha 0 {soma.ToString()}\n" + $"Média da linha 1 : {media.ToString()}\n" +
                $"Multiplicação linhas 2 e 3: {sMult}");
        }
    }
}
