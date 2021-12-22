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

namespace OperaçõesComArrays
{
    public partial class Form1 : Form
    {

        string[] cores = { "amarelo", "branco", "verde", "preto", "laranja" };
        public Form1()
        {
            InitializeComponent();
        }

        private void bntTamanho_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu vetor tem capacidade para: {cores.Length.ToString()} elementos");
        }

        private void bntOrdenar_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear(); 
            Array.Sort(cores);
            for(int i = 0; i < cores.Length; i++)
            {
                lstResultado.Items.Add(cores[i].ToString());
            }
        }

        private void bntInverter_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            Array.Reverse(cores);
            for (int i = 0; i < cores.Length; i++)
            {
                lstResultado.Items.Add(cores[i].ToString());
            }
        }
    

        private void bntBuscaBinaria_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            object corEscolhida = "verde";
            int indice = Array.BinarySearch(cores, corEscolhida);
            if (indice >= 0)
            {
                MessageBox.Show($"Achei o elemento no índice {indice.ToString()}");
            }
            else
            {
                MessageBox.Show("Não encontrei o elemento");
            }
        }

        private void bntIndice_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            string busca = Interaction.InputBox("Digite uma cor: ");
            int resultado = Array.IndexOf(cores, busca) + 1;
            MessageBox.Show($"A cor {busca.ToString()} está na posição: {resultado.ToString()}");
        }
    }
    
}
