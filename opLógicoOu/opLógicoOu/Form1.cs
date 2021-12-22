namespace opLógicoOu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total, vTotal;
            string cupom;
            total = Convert.ToDouble(txtTotal.Text);
            cupom = txtCupom.Text.ToUpper();

            if (total > 1000 || cupom == "DESCONTO20")
            {
                vTotal = total - (total * 0.2);
            }
            else
            {
                vTotal = total;
            }
            MessageBox.Show("Valor final da compra: R$" + vTotal.ToString("0.00"));
        }
    }
}