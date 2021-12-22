namespace MédiaAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, media;
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);
            media = (nota1 + nota2 + nota3) / 3;
            if (media >= 7)
            {
                MessageBox.Show("Média: " + media + " (Aprovado)", "Média", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(media < 4)
            {
                MessageBox.Show("Média: " + media + " (Reprovado)", "Média", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Média: { media.ToString("0.00")} \n (Em prova final)", "Média", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}