namespace ValorCrédito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerCredito_Click(object sender, EventArgs e)
        {
            double saldoMedio, valorCredito;
            saldoMedio = Convert.ToDouble(txtSaldoMedio.Text);
            if (saldoMedio <= 200)
            {
                valorCredito = 0;
            }
            else if (saldoMedio <= 400)
            {
                valorCredito = 0.02 * saldoMedio;
            }
            else if (saldoMedio < 600)
            {
                valorCredito = saldoMedio * 0.03;
            }
            else
            {
                valorCredito = saldoMedio * 0.04;
            }
            lblRes.Text = $"Seu crédito: R${valorCredito.ToString("0.00")}";
        }
    }
}