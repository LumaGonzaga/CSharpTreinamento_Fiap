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
                MessageBox.Show("Voc� selecionou o sexo feminino", "Aten��o", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);  
            }
            else
            {
                MessageBox.Show("Voc� selecionou o sexo masculino", "Aten��o", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}