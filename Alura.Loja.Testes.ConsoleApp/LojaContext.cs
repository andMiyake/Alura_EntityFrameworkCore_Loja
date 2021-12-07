using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class LojaContext : DbContext
    {
        //Quais as classe que vão ser persistidas pelo EF. Produtos, Compras, Promocoes e Clientes são nomes de tabela criadas
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        //Não adicionamos a tabela de 

        public LojaContext()
        {

        }

        public LojaContext(DbContextOptions<LojaContext> options) : base(options)
        {

        }

        //método para ajustar detalhes das Migrations que não conseguimos alterar através das classes
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Setando as PK's da tabela "PromocaoProduto" como PromocaoId e ProdutoId
            modelBuilder
                .Entity<PromocaoProduto>()
                .HasKey(pp => new { pp.PromocaoId, pp.ProdutoId });

            //Alterando o nome da Tabela gerada pela migration,
            //como essa tabela não foi instanciada nessa classe("LojaContext")
            //o nome gerado estava vindo como Endereco
            modelBuilder
                .Entity<Endereco>()
                .ToTable("Enderecos");

            //Shadow Property
            modelBuilder
                .Entity<Endereco>()
                .Property<int>("ClienteId");

            //Setando a PK da tabela "Endereco" como ClienteId
            modelBuilder
                .Entity<Endereco>()
                .HasKey("ClienteId");
        }

        //Definir o banco de Dados e onde ele fica
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
            }
        }
    }
}