namespace IfEncadeado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            byte idade;
            idade = Convert.ToByte(txtIdade.Text);
            if (idade <= 16)
            {
                MessageBox.Show("Não podem votar e nem embarcar!", "ONG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(idade >= 18){
                MessageBox.Show("Voto Obrigatório. Embarque permitido!", "ONG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Voto facultativo. Embarque permitido!", "ONG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}