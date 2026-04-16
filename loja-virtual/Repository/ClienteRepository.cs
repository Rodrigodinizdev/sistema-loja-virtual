using loja_virtual.Interfaces.Repositories;
using loja_virtual.Models;

namespace loja_virtual.Repository;

public class ClienteRepository : IClienteRepository
{
    private readonly List<Cliente> _clientes = [];

    public Cliente BuscarPorCPF(string cpf) => _clientes.FirstOrDefault(c => c.CPF == cpf);

    public Cliente BuscarPorEmail(string email) => _clientes.FirstOrDefault(c => c.Email == email);
     public Cliente BuscarPorId(int id) => _clientes.FirstOrDefault(c => c.Id == id);
    
    public void CadastrarCliente(Cliente cliente) => _clientes.Add(cliente);
    public List<Cliente> ListarCliente() => _clientes;
    public void RemoverCliente(Cliente cliente) => _clientes.Remove(cliente);
    
}
