namespace OperacoesPoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Instanciar um objeto da classe Usuario
            Usuario user = new Usuario();

            //Inserir os dados do atributo
            user.nome = txtNome.Text;
            user.email = txtEmail.Text;
            user.login = txtLogin.Text;
            user.senha = txtSenha.Text;
            //Executar oo método
            user.provarExistencia();

        }
    }
}