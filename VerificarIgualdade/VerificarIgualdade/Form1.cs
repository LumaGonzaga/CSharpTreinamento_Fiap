namespace VerificarIgualdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = Convert.ToString(txtUsuario.Text);
            senha = Convert.ToString(txtSenha.Text);

            if ((usuario == "ADMINISTRADOR") && (senha == "123"))
            {
                MessageBox.Show("Bem vindo administrador");
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha inválidos");
            }
        }
    }
}