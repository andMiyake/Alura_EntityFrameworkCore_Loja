using System;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Descricao { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime Datatermino { get; internal set; }
        public IList<PromocaoProduto> Produtos { get; internal set; }

        public Promocao()
        {
            this.Produtos = new List<PromocaoProduto>();
        }

        public void IncluirProduto(Produto produto)
        {
            this.Produtos.Add(new PromocaoProduto() { Produto = produto });
        }
    }
}

//Relacionamento N:N com Produto
//Foi necessário criar uma nova classe que representa a tabela resultante -> PromocaoProdutos
