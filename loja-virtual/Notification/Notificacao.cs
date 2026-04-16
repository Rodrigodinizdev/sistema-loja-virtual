using loja_virtual.Enums;
using loja_virtual.Interfaces.Notification;

namespace loja_virtual.Notification;

public class Notificacao : INotification
{
    internal class Mensagem
    {
        public Mensagem(string texto, TipoNotificacaoEnum tipo)
        {
            Texto = texto;
            Tipo = tipo;
        }
        public string Texto { get; private set; }
        public TipoNotificacaoEnum Tipo { get; private set; }

        public override string ToString() => $"{Tipo}: {Texto}";   
    }

    private List<Mensagem> _notificacoes = [];

    public void AdicionarErro(string mensagem) => _notificacoes.Add(new Mensagem(mensagem, TipoNotificacaoEnum.Erro));
    public void AdicionarSucesso(string mensagem) => _notificacoes.Add(new Mensagem(mensagem, TipoNotificacaoEnum.Sucesso));
    public bool TemNotificacao() => _notificacoes.Any();
    public void Limpar() => _notificacoes.Clear();
    public IReadOnlyCollection<object> ExibirNotificacao() => _notificacoes;
    
}
