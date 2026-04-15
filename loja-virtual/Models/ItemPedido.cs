namespace loja_virtual.Models;
public class ItemPedido
{
    public ItemPedido(Produto produto, int quantidade, decimal precoUnitario)
    {
        Id = ++_idContador;
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
    }
    private static int _idContador = 0;
    public int Id { get; }
    public Produto Produto { get; }
    public int Quantidade { get; private set; }
    public decimal PrecoUnitario { get; }
}
