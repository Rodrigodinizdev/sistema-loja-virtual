using loja_virtual.Interfaces.Repositories;
using loja_virtual.Models;

namespace loja_virtual.Repository;

public class PedidoRepository : IPedidoRepository
{
    private readonly List<Pedido> _pedidos = [];
    public void AdicionarPedido(Pedido pedido) => _pedidos.Add(pedido);
   
    public Pedido BuscarPedidoPorID(int id) => _pedidos.FirstOrDefault(p => p.Id == id);
    
    public List<Pedido> ListarPedidos() => _pedidos;
    
}
