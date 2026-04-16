using loja_virtual.DTOs;
using loja_virtual.Models;
namespace loja_virtual.Interfaces.Services;

    public interface IPedidoService
    {
        void CriarPedido(PedidoDTO dto);
        List<Pedido> ListarPedidos();
        Pedido BuscarPedidoPorID(int id);
    }
