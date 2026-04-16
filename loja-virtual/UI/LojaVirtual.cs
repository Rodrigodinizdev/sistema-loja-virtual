using loja_virtual.DTOs;
using loja_virtual.Interfaces.Notification;
using loja_virtual.Interfaces.Services;
using loja_virtual.Models;

namespace loja_virtual.UI;

public class LojaVirtual(ICategoriaService categoriaService, INotification notification)
{
    private readonly ICategoriaService _categoriaService = categoriaService;
    private readonly INotification _notification = notification;
    public void Menu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== LOJA VIRTUAL ===");
            Console.WriteLine("1 - Cadastrar Categoria");
            Console.WriteLine("2 - Cadastrar Produtos");
            Console.WriteLine("3 - Cadastrar Clientes");
            Console.WriteLine("4 - Realizar Compra");
            Console.WriteLine("5 - Excluir Categoria");
            Console.WriteLine("6 - Excluir Cliente");
            Console.WriteLine("7 - Excluir Produto");
            Console.WriteLine("0 - Sair");

            Console.Write("\nEscolha a opção: ");
            string opcao = Console.ReadLine();

            Console.Clear();

            switch (opcao)
            {
                case "1":
                    CadastrarCategoria();
                    break;

                case "2":
                    CadastrarProdutos();
                    break;

                case "3":
                    CadastrarClientes();
                    break;

                case "4":
                    RealizarCompra();
                    break;

                case "0":
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida...");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla...");
            Console.ReadKey();
        }
    }

    private void CadastrarCategoria()
    {
        Console.Clear();
        Console.WriteLine("=== CADASTRO DE CATEGORIA ===");

        Console.Write("\nDigite o nome da categoria: ");
        string nomeCategoria = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(nomeCategoria) || nomeCategoria.Length <= 2 || nomeCategoria.Length >= 60)
        {
            Console.WriteLine("ERRO: Nome não pode ser vazio e deve ter entre 2 e 60 caracteres");
            nomeCategoria = Console.ReadLine();
        }

        Console.WriteLine($"Categoria criada com sucesso");
        _categoriaService.CriarCategoria(new CategoriaDTO(nomeCategoria));

    }

    private void CadastrarProdutos()
    {
        Console.Clear();
        Console.WriteLine("=== CADASTRO DE PRODUTO ===");
        Console.Write("\nDigite o nome do produto: ");
        string nomeProduto = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(nomeProduto) || nomeProduto.Length <= 3 || nomeProduto.Length >= 100)
        {
            Console.WriteLine("ERRO: Nome não pode ser vazio e deve ter entre 3 e 100 caracteres");
            nomeProduto = Console.ReadLine();
        }

        Console.Write("\nDigite o Preço do produto: ");
        decimal precoProduto;
        while(!decimal.TryParse(Console.ReadLine(), out precoProduto) || precoProduto <= 0)
            Console.WriteLine("ERRO: Preço é obrigatório e deve ser maior que zero");

        Console.Write("\nDigite a quantidade em estoque: ");
        decimal quantidadeProduto;
        while(!decimal.TryParse(Console.ReadLine(), out quantidadeProduto) || quantidadeProduto <= 0)
            Console.WriteLine("ERRO: Quantidade é obrigatório e deve ser maior que zero");
            
    }

    private void CadastrarClientes()
    {

    }

    private void RealizarCompra()
    {

    }
}
