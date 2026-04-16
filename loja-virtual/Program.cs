
using loja_virtual.Models;
using loja_virtual.Notification;
using loja_virtual.Repository;
using loja_virtual.Services;
using loja_virtual.UI;

var Notificacao = new Notificacao();

var ICategoriaRepository = new CategoriaRepository();

var categoriaService = new CategoriaService(ICategoriaRepository, Notificacao);

var ui = new LojaVirtual(categoriaService, Notificacao);

ui.Menu();