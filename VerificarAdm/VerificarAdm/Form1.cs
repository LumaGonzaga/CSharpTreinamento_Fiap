namespace VerificarAdm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string usuario;
            usuario = txtUsuario.Text.ToUpper();
            if (!(usuario == "ADMINISTRADOR"))
            {
                MessageBox.Show("Sem poderes administrativos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("Olá administrador", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}