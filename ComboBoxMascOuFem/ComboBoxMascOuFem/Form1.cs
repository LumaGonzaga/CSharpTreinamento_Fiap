namespace ComboBoxMascOuFem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecione_Click(object sender, EventArgs e)
        {
            double num;
            num = cmbSexo.SelectedIndex;

            switch (num)
            {
                case 0:
                    MessageBox.Show("Voc� selecionou o sexo feminino", "Aten��o", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;

                case 1:
                    MessageBox.Show("Voc� selecionou o sexo masculino", "Aten��o", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break ;
            }
        }
    }
}