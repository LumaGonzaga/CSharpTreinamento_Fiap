using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaHerança
{
    public class DVD : Produto
    {
        string diretor { get; set; }
        int duracao { get; set; }
        int sensura { get; set; }

        public DVD(string diretor, int duracao, int sensura, string descricao, string genero,
           int estoqueDisponivel, double precoCusto) : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.diretor = diretor;
            this.duracao = duracao;
            this.sensura = sensura;
        }
        public DVD()
        {
            string diretor = "";
            int duracao = 0;
            int sensura = 0;
            string descricao = "";
            string genero = "";
            int estoqueDisponivel = 0;
            double precoCusto = 0;
        }
        public void listarProduto()
        {
            MessageBox.Show(
                $"Dados do livro cadastrado \n" +
                $"Descrição: {this.descricao}\n" +
                $"Gênero: {this.genero}\n" +
                $"Estoque: {this.estoqueDisponivel.ToString()}\n" +
                $"Preço: {this.precoCusto:f2}\n" +
                $"Autor: {this.diretor}\n" +
                $"Editora: {this.estoqueDisponivel}\n" +
                $"Edição: {this.sensura}");
        }

















    }
}
