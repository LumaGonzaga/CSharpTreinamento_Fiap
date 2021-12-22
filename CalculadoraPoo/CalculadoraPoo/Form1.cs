namespace CalculadoraPoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.n1 = Convert.ToDouble(txtNum1.Text);
            calc.n2 = Convert.ToDouble(txtNum2.Text);
            calc.somar();
            lblResp.Text = calc.resp.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.n1 = Convert.ToDouble(txtNum1.Text);
            calc.n2 = Convert.ToDouble(txtNum2.Text);
            calc.subtrair();
            lblResp.Text= calc.resp.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {   
            Calculadora calc = new Calculadora();
            calc.n1 = Convert.ToDouble(txtNum1.Text);
            calc.n2 = Convert.ToDouble(txtNum2.Text);
            calc.multiplicar();
            lblResp.Text=(calc.resp.ToString());
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.n1= Convert.ToDouble(txtNum1.Text);
            calc.n2= Convert.ToDouble(txtNum2.Text);
            calc.dividir();
            lblResp.Text = (calc.resp.ToString());

        }
    }
}