using loja_virtual.DTOs;
using loja_virtual.Models;
namespace loja_virtual.Interfaces.Services;

    public interface ICategoriaService
    {
        void CriarCategoria(CategoriaDTO dto);
        List<Categoria> ListarCategorias();

    }
