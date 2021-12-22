namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            double num1, num2, resp;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 * num2;
            lblRes.Text = resp.ToString();  
        }
    }
}