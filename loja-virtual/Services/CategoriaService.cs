using loja_virtual.DTOs;
using loja_virtual.Enums;
using loja_virtual.Interfaces.Repositories;
using loja_virtual.Interfaces.Services;
using loja_virtual.Models;
using loja_virtual.Notification;

namespace loja_virtual.Services;

public class CategoriaService(ICategoriaRepository categoriaRepository, Notificacao notification) : ICategoriaService 
{
    private readonly ICategoriaRepository _categoriaRepository = categoriaRepository;
    private readonly Notificacao _notificacao = notification;

    public void CriarCategoria(CategoriaDTO dto)
    {
        _notificacao.Limpar();

        var categoria = _categoriaRepository.BuscarCategoriaPeloNome(dto.Nome);

        if(categoria != null)
        {
            _notificacao.AdicionarErro("Já Existe uma categoria com esse nome");
            _notificacao.ExibirNotificacao();
            return; 
        }

         categoria = new Categoria(dto.Nome);
        _categoriaRepository.AdicionarCategoria(categoria);
        _notificacao.AdicionarSucesso($"{categoria}");
        _notificacao.ExibirNotificacao();
    }

    public List<Categoria> ListarCategorias()
    {
        _notificacao.Limpar();

        var categorias = _categoriaRepository.ListarCategoriasAtivas();

        if (categorias.Count == 0)
        {
            _notificacao.AdicionarErro("Não existem categorias adicionadas");
            _notificacao.ExibirNotificacao();
            return [];
        }

        Console.WriteLine("=== CATEGORIAS ===");
        foreach (var categoria in categorias)
        {
            _notificacao.AdicionarSucesso($"{categoria}");
            _notificacao.ExibirNotificacao();
        }
        
        return categorias;
    }
}
