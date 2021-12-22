namespace IfSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            byte idade;
            idade = Convert.ToByte(txtIdade.Text); // idade = byte.Parse(txtIdade.Text);
            if (idade >= 12)
            {
                MessageBox.Show("Você pode jogar!!! :D", "Jogo - Drogas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}