namespace MesesPorNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            byte Mes;
            if(byte.TryParse(txtMes.Text, out Mes) == false)
            {
                MessageBox.Show($"Digite um número válido!", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtMes.Clear();
                txtMes.Focus();
                return;
            }
            switch (Mes)
            {
                case 1:
                    MessageBox.Show($"Janeiro", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 2:
                    MessageBox.Show($"Fevereiro", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 3:
                    MessageBox.Show($"Março", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 4:
                    MessageBox.Show($"Abril", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 5:
                    MessageBox.Show($"Maio", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 6:
                    MessageBox.Show($"Junho", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 7:
                    MessageBox.Show($"Julho", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 8:
                    MessageBox.Show($"Agosto", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 9:
                    MessageBox.Show($"Setembro", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 10:
                    MessageBox.Show($"Outubro", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 11:
                    MessageBox.Show($"Novembro", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 12:
                    MessageBox.Show($"Dezembro", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                default:
                    MessageBox.Show($"Mês Inválido", "Mês", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    break;

            }

        }
    }
}