using loja_virtual.Enums;

namespace loja_virtual.Models;

public class Cliente
{
    public Cliente(string nome, string cpf, string email)
    {
        Id = ++_idContador;
        Nome = nome;
        CPF = cpf;
        Email = email;
    }
    private static int _idContador = 0;
    public int Id { get; }
    public string Nome { get; private set; }
    public string CPF { get; }
    public string Email { get; private set; }
    public EstadoClienteEnum Estado = EstadoClienteEnum.Ativo;

    public void AlterarNomeCliente(string nome) => Nome = nome;
    
    public void AlterarEmailCliente(string email) => Email = email;

    public override string ToString() => $"Id: [{Id}] | Nome: {Nome} | CPF: {CPF} | Email: {Email} | Estado: {Estado}";
   
}
