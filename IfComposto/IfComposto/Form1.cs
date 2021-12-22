namespace IfComposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvestimento_Click(object sender, EventArgs e)
        {
            double doacao, investimento;
            doacao = Convert.ToDouble(txtDoacao.Text);
            if (doacao <= 1000)
            {
                investimento = doacao * 0.05;
                MessageBox.Show("R$ " + investimento.ToString("0.00"));
            }
            else
            {
                investimento = doacao * 0.15;
                MessageBox.Show("R$ " + investimento.ToString("0.00"), "Doação - ONG", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }
    }
}