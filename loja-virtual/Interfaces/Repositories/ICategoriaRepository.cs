using loja_virtual.Models;

namespace loja_virtual.Interfaces.Repositories;

    public interface ICategoriaRepository
    {
        void AdicionarCategoria(Categoria categoria);
        List<Categoria> ListarCategoriasAtivas();
        Categoria BuscarCategoriaPeloNome(string nome);
        Categoria BuscarCategoriaPeloId(int id)
;        List<Categoria> ListarCategorias();
    }
