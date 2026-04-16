using loja_virtual.DTOs;
using loja_virtual.Interfaces.Repositories;
using loja_virtual.Interfaces.Services;
using loja_virtual.Models;
using loja_virtual.Notification;

namespace loja_virtual.Services;

public class ClienteService(IClienteRepository clienteRepository, Notificacao notificacao) : IClienteService
{
    private readonly IClienteRepository _clienteRepository = clienteRepository;
    private readonly Notificacao _notificacao = notificacao;

    public Cliente BuscarPorId(int id)
    {
        _notificacao.Limpar();

        Console.Clear();
        var cliente = _clienteRepository.BuscarPorId(id);

        if(cliente == null)
        {
            _notificacao.AdicionarErro("Cliente não encontrado");
            _notificacao.ExibirNotificacao();  
        }
        return cliente;
    }

    public void CadastrarCliente(ClienteDTO dto)
    {
        _notificacao.Limpar();

        Console.Clear();
        var cliente = _clienteRepository.BuscarPorCPF(dto.CPF);

        if(cliente != null)
        {
            _notificacao.AdicionarErro("CPF já cadastrado");
            _notificacao.ExibirNotificacao();
            return; 
        }

        cliente = _clienteRepository.BuscarPorEmail(dto.Email);

        if(cliente != null)
        {
            _notificacao.AdicionarErro("Email já cadastrado");
            _notificacao.ExibirNotificacao();
            return; 
        }

        cliente = new Cliente(dto.Nome, dto.CPF, dto.Email);
        _clienteRepository.CadastrarCliente(cliente);
        _notificacao.AdicionarSucesso($"{cliente} cadastrado");   
    }

    public List<Cliente> ListarClientes()
    {
        throw new NotImplementedException();
    }

    public void RemoverCliente(int id)
    {
        throw new NotImplementedException();
    }
}
