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

namespace MédiaVetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            double[] notas = new double[10];
            double media, soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = double.Parse(Interaction.InputBox($"Digite a nota do aluno " +
                    $"{(i + 1).ToString()}:"));  
                soma += notas[i]; ;
            }
             media = soma/notas.Length;
            MessageBox.Show($"A média dos alunos é: {media.ToString("0.00")}");
        }
    }
}
