namespace SomatorioFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            int num1, num2, soma = 0;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text); 
            for(int i = num1+1; i < num2; i++)
            {
                soma += i;
            }
            lblRes.Text = soma.ToString();
        }
    }
}