namespace ExemplosComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            switch (cmbEscolha.SelectedIndex)
            {
                case 0:
                    MessageBox.Show($"Você selecionou a Equipe {cmbEscolha.SelectedIndex.ToString()}");
                    break;
                case 1:
                    MessageBox.Show($"Você selecionou a Equipe {cmbEscolha.SelectedIndex.ToString()}");
                    break;

                case 3:
                    MessageBox.Show($"Você selecionou a Equipe {cmbEscolha.SelectedIndex.ToString()}");
                    break;

                default:
                    MessageBox.Show("Selecione uma equipe:");
                    break;
            }
        }
    }
}