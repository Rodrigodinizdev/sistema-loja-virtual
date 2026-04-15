using loja_virtual.Models;

namespace loja_virtual.Interfaces.Repositories;

    public interface IPedidoRepository
    {
        void AdicionarPedido(Pedido pedido);
        List<Pedido> ListarPedidos();
        Pedido BuscarPedidoPorID(int id);
    }
