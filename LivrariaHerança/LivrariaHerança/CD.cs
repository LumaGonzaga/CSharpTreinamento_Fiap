using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaHerança
{
    public class CD : Produto
    {
        string artista { get; set; }
        string gravadora { get; set; }
        string origem { get; set; }

        public CD(string artista, string gravadora, string origem, string descricao, string genero,
           int estoqueDisponivel, double precoCusto) : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.artista = artista;
            this.gravadora = gravadora;
            this.origem = origem;
        }
        public CD()
        {
            this.descricao = "";
            this.genero = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;
            this.artista = "";
            this.gravadora = "";
            this.origem = "";
        }
        public void listarProduto()
        {
            MessageBox.Show(
                $"Dados do livro cadastrado \n" +
                $"Descrição: {this.descricao}\n" +
                $"Gênero: {this.genero}\n" +
                $"Estoque: {this.estoqueDisponivel.ToString()}\n" +
                $"Preço: {this.precoCusto:f2}\n" +
                $"Autor: {this.artista}\n" +
                $"Editora: {this.gravadora}\n" +
                $"Edição: {this.origem}");
        }
    }

}
