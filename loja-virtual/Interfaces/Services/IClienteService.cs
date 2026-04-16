using loja_virtual.DTOs;
using loja_virtual.Models;

namespace loja_virtual.Interfaces.Services;

public interface IClienteService
{
    void CadastrarCliente(ClienteDTO dto);
    Cliente BuscarPorId(int id);
    List<Cliente> ListarClientes();
    void RemoverCliente(int id);

}
