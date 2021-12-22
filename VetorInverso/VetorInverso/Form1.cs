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

namespace VetorInverso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbnIniciar_Click(object sender, EventArgs e)
        {
            double[] a = new double[15];
            double[] b = new double[15];
            int count = (a.Length) - 1;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = double.Parse(Interaction.InputBox("Digite um número: "));
                b[count] = a[i];
                count--;
            }
            for(int j = 0; j < b.Length; j++)
            {
                lstVetorB.Items.Add(b[j].ToString());
            }
            //for(int j = 0; j < b.Length; j++)
            //{
            //    saida += b[i].ToString() + "\n";
            //}
            //MessageBox.Show(saida);
            //ou
            //label.Text = saida + "\n";

        }
    }
}
