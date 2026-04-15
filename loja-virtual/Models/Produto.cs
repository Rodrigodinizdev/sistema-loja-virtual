using loja_virtual.Enums;

namespace loja_virtual.Models;

public class Produto
{
    public Produto(string nome, decimal preco, int estoque, Categoria categoria)
    {
        Id = ++_idContador;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
        Categoria = categoria;
    }
    private static int _idContador = 0;
    public int Id { get; }
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public int Estoque { get; private set; }
    public Categoria Categoria { get; }
    public EstadoProdutoEnum Estado = EstadoProdutoEnum.Ativo;

    public void AlterarNomeProduto(string nome) => Nome = nome;
   
    public void AlterarPrecoProduto(decimal preco) => Preco = preco;
   
    public void AlterarEstoqueProduto(int estoque) => Estoque = estoque;
   
    public override string ToString() => $"Id: [{Id}] | Nome: {Nome} | Categoria: {Categoria} | Preço: {Preco:C} | Estoque: {Estoque} unidades | Status: {Estado}";
    
}
