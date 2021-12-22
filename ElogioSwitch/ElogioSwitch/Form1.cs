namespace ElogioSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            byte num;
            string mensagem;
            if(byte.TryParse(txtElogio.Text, out num) == false)
            {
                MessageBox.Show($"Digite um n�mero v�lido!", "Aten��o",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtElogio.Clear();
                lblElogio.Text = "";
                return;
            }

            switch (num)
            {
                case 1:
                    mensagem = "Voc� escolheu a op��o ELOGIO PROFISSIONAL";
                    break;

                case 2:
                    mensagem = "Voc� escolheu a op��o ELOGIO F�SICO";
                    break ;

                case 3:
                    mensagem = "Voc� escolheu a op��o ELOGIO PESSOAL";
                    break;

                default:
                    mensagem = "Op��o inv�lida";
                    break;

            }
            MessageBox.Show(mensagem, "Elogios", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
    }
}