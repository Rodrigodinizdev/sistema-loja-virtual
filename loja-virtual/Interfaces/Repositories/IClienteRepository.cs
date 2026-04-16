using loja_virtual.Models;

namespace loja_virtual.Interfaces.Repositories;

public interface IClienteRepository
{
    void CadastrarCliente(Cliente cliente);
    List<Cliente> ListarCliente();
    Cliente BuscarPorId(int id);
    Cliente BuscarPorEmail(string email);
    Cliente BuscarPorCPF(string cpf);
    void RemoverCliente(Cliente cliente);
}
