namespace ParesDoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            int num1, num2, quant = 0;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            int count = num1 + 1;
            do
            {
                if(count%2 == 0)
                {
                    quant++;
                }
                count++;
            }while(count < num2);
            lblRes.Text = quant.ToString();
        }
    }
}