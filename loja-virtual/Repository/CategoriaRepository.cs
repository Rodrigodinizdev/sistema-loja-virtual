using loja_virtual.Enums;
using loja_virtual.Interfaces.Repositories;
using loja_virtual.Models;

namespace loja_virtual.Repository;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly List<Categoria> _categorias = [];
    public void AdicionarCategoria(Categoria categoria) => _categorias.Add(categoria); 
   
    public Categoria BuscarCategoriaPeloNome(string nome) => _categorias.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
    
    public List<Categoria> ListarCategoriasAtivas() => _categorias.Where(c => c.EstadoCategoria == EstadoCategoriaEnum.Ativo).ToList();
    public List<Categoria> ListarCategorias() => _categorias;

    public Categoria BuscarCategoriaPeloId(int id) => _categorias.FirstOrDefault(c => c.Id == id);
   
}
