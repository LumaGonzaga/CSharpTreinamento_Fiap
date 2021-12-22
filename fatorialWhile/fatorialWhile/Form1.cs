namespace fatorialWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            int num, fat = 1, count = 0;
            num = Convert.ToInt32(txtNum.Text);
            
            while(count<num){
                fat += num * fat;
                num--;
                count++;

            }
            lblRes.Text = fat.ToString();
           

        }
    }
}