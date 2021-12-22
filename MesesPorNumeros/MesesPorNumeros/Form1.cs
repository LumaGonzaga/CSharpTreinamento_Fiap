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
                MessageBox.Show($"Digite um n�mero v�lido!", "Aten��o", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtMes.Clear();
                txtMes.Focus();
                return;
            }
            switch (Mes)
            {
                case 1:
                    MessageBox.Show($"Janeiro", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 2:
                    MessageBox.Show($"Fevereiro", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 3:
                    MessageBox.Show($"Mar�o", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 4:
                    MessageBox.Show($"Abril", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 5:
                    MessageBox.Show($"Maio", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 6:
                    MessageBox.Show($"Junho", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 7:
                    MessageBox.Show($"Julho", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 8:
                    MessageBox.Show($"Agosto", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 9:
                    MessageBox.Show($"Setembro", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 10:
                    MessageBox.Show($"Outubro", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 11:
                    MessageBox.Show($"Novembro", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                case 12:
                    MessageBox.Show($"Dezembro", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;

                default:
                    MessageBox.Show($"M�s Inv�lido", "M�s", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    break;

            }

        }
    }
}