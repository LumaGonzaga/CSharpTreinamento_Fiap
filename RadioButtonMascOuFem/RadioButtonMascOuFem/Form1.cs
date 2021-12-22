namespace RadioButtonMascOuFem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(rbdFem.Checked == true)
            {
                MessageBox.Show("Você selecionou o sexo feminino", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);  
            }
            else
            {
                MessageBox.Show("Você selecionou o sexo masculino", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}