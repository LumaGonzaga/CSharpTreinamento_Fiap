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
                MessageBox.Show($"Digite um número válido!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtElogio.Clear();
                lblElogio.Text = "";
                return;
            }

            switch (num)
            {
                case 1:
                    mensagem = "Você escolheu a opção ELOGIO PROFISSIONAL";
                    break;

                case 2:
                    mensagem = "Você escolheu a opção ELOGIO FÍSICO";
                    break ;

                case 3:
                    mensagem = "Você escolheu a opção ELOGIO PESSOAL";
                    break;

                default:
                    mensagem = "Opção inválida";
                    break;

            }
            MessageBox.Show(mensagem, "Elogios", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
    }
}