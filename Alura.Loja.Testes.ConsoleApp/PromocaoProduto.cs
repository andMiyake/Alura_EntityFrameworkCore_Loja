namespace Alura.Loja.Testes.ConsoleApp
{
    public class PromocaoProduto
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int PromocaoId { get; set; }
        public Promocao Promocao { get; set; }
    }
}

//Resultado do relacionamento N:N de Promocao e Produto