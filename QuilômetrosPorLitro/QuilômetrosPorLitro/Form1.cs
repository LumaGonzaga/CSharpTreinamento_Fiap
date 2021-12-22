namespace QuilômetrosPorLitro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, res;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            num3 = Convert.ToDouble(txtNum3.Text);
            res = num2 - num1;
            res = res / num3;
            lblRes.Text = res.ToString() + " kM/L";

        }
    }
}