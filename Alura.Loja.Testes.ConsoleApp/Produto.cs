using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnitario { get; internal set; }
        public string Unidade { get; set; }
        public IList<PromocaoProduto> Promocoes { get; set; }
        public IList<Compra> Compras { get; set; }

        public override string ToString()
        {
            return $"Produto: {this.Id}, {this.Nome}, {this.Categoria}, {this.PrecoUnitario}";
        }
    }
}

//Relacionamento N:N com Promocao       -       Relacionamento 1:N com Compra
//Foi necessário criar uma nova classe que representa a tabela resultante -> PromocaoProdutos