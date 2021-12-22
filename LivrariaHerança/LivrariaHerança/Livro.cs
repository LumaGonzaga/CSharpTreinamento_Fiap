﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LivrariaHerança
{
    public class Livro : Produto

    {   //Atributos
        public string autor { get; set; }
        public string editora { get; set; }
        public string edicao { get; set; }

        //Construtores
        public Livro(string autor, string editora, string edicao, string descricao, string genero,
            int estoqueDisponivel, double precoCusto) : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.autor = autor;
            this.descricao = descricao;
            this.edicao = edicao;
        }
        public Livro()
        {
            this.descricao = "";
            this.genero = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;
            this.autor = "";
            this.editora = "";
            this.edicao = "";
        }
        public void listarProduto()
        {
            MessageBox.Show(
                $"Dados do livro cadastrado \n" +
                $"Descrição: {this.descricao}\n" +
                $"Gênero: {this.genero}\n" +
                $"Estoque: {this.estoqueDisponivel.ToString()}\n" +
                $"Preço: {this.precoCusto:f2}\n" +
                $"Autor: {this.autor}\n" +
                $"Editora: {this.editora}\n" +
                $"Edição: {this.edicao}");
        }
    }
}
