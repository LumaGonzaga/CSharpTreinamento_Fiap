namespace MédiaNotasEAulas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, notaG, porcentagem;
            byte aulasG, aulasA;
            nota1 = double.Parse(txtNum1.Text);
            nota2 = double.Parse(txtNum2.Text);
            aulasG = byte.Parse(txtQG.Text);
            aulasA = byte.Parse(txtQA.Text);

            
            porcentagem = (aulasA*100)/aulasG;
            notaG = (nota1 + nota2) / 2;
            if((notaG >= 7) && (porcentagem>=75))
            {
                MessageBox.Show($"Média: {notaG.ToString("0.00")}   Frequência: {porcentagem}%    Aprovado!!");
            }
            else
            {
                MessageBox.Show($"Média: {notaG.ToString("0.00")}   Frequência: {porcentagem}%    Reprovado!!");
            }
        }
    }
}