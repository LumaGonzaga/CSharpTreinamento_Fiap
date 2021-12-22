namespace LaçosRepetição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();//limpa a listbox toda vez que rodar
            int num, res, count = 1;
            num = int.Parse(txtNum.Text);
            while (count < 11)
            {
                res = num * count;
                count++;
                lstTabuada.Items.Add(res);//adiciona os resultados na listBox
            }
            
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();//limpa a listbox toda vez que rodar
            int num, res, count = 1;
            num = int.Parse(txtNum.Text);
            do 
            {   
                res = num * count;
                count++;
                lstTabuada.Items.Add(res);//adiciona os resultados na listBox
            } while (count < 11);

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();//limpa a listbox toda vez que rodar
            int num, res;
            num = int.Parse(txtNum.Text);

            for(int i = 1; i <= 10; i++)
            {
                res = num * i;
                lstTabuada.Items.Add(res);//adiciona os resultados na listBox
            }
        }

    }
}
