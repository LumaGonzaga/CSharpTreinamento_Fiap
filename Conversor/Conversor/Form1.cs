namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double num1, num2, res;
            num1 = Convert.ToDouble(txtNum1.Text.Replace(".", ","));
            num2 = Convert.ToDouble(txtNum2.Text.Replace(".", ","));
            res = num1 * num2;
            lblRes.Text = "R$= " + res.ToString("0.00");
            
        }
    }
}