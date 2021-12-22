namespace TipoDeTriângulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, soma;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            num3 = Convert.ToDouble(txtNum3.Text);

            if((num1<(num2 + num3))&&(num2<(num1 + num3))&&(num3<(num1 + num2)))
            {
                if((num1 == num2)&&(num2 == num3))
                {
                    MessageBox.Show($"É um triângulo equilátero", "Triângulo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else if((num1 == num2)||(num2 == num3)||(num1 == num3))
                {
                    MessageBox.Show($"É um triângulo isósceles", "Triângulo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"É um triângulo escaleno", "Triângulo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show($"Os lados não formam um triângulo", "Triângulo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}