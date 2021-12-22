namespace LivrariaHerança
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnCadastrar_Click(object sender, EventArgs e)
        {
            autor = txtAutor.Text;


        }

        public void btnComprar_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtEstoque.Text);
            Livro.comprar(qtde);

        }
    }
}