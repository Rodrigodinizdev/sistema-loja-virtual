using loja_virtual.Enums;

namespace loja_virtual.Models;

public class Categoria
{
    public Categoria(string nome)
    {
        Id = ++_idContador;
        Nome = nome;
    }

    private static int _idContador = 0;
    public int Id { get; }
    public string Nome { get; private set; }
    public EstadoCategoriaEnum EstadoCategoria {get; private set; } = EstadoCategoriaEnum.Ativo;

    public void AlterarNomeCategoria(string nome) => Nome = nome;
    public void Ativar() => EstadoCategoria = EstadoCategoriaEnum.Ativo;
    public void Desativar() => EstadoCategoria = EstadoCategoriaEnum.Inativo;
    
    public override string ToString() => $"Id: [{Id}] | Categoria: {Nome} | Estado: {EstadoCategoria}";
   
}
