using loja_virtual.Enums;

namespace loja_virtual.Models;

public class Pedido
{
    public Pedido(Cliente cliente)
    {
        Id = ++_idContador;
        Cliente = cliente;
    }
    private static int _idContador = 0;
    public int Id { get; }
    public Cliente Cliente { get; }
    public DateTime DataVenda = DateTime.Now;
    public StatusPedidoEnum Status = StatusPedidoEnum.Aguardando;
    public decimal ValorTotal = 0;

    private List<ItemPedido> _itens = [];

    public void AdicionarItem(ItemPedido item)
    {
         _itens.Add(item);
         ValorTotal += item.Quantidade * item.PrecoUnitario;
    }

    public override string ToString()
    {
       return $"Id: [{Id}] | Cliente: {Cliente.Nome} | Data: {DataVenda:dd/MM/yyyy} | Valor Total: {ValorTotal:C}";
    }
                                          
}
