namespace TransaçãoBancáriaSwitch
{
    public partial class Form1 : Form
    {
        double saldoGeral = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void bntConfirmar_Click(object sender, EventArgs e)
        {

            double valor;
            valor = double.Parse(txtValor.Text);
            switch (cmbEscolha.SelectedIndex)
            {
                case 0:
                    saldoGeral += valor;
                    MessageBox.Show("Depósito realizado!");
                    break;

                case 1:
                    saldoGeral -= valor;
                    MessageBox.Show("Saque realizado!");
                    break;

                case 2:
                    MessageBox.Show("Saldo= " + saldoGeral);
                    break;

            }
        }
    }
}
