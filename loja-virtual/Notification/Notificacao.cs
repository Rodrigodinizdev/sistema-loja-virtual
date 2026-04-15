using loja_virtual.Enums;

namespace loja_virtual.Notification;

public class Notificacao
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
    }

    private List<Mensagem> _mensagens = [];

    public void AdicionarErro(string mensagem) => _mensagens.Add(new Mensagem(mensagem, TipoNotificacaoEnum.Erro));
    public void AdicionarSucesso(string mensagem) => _mensagens.Add(new Mensagem(mensagem, TipoNotificacaoEnum.Sucesso));
    public bool TemErros() => _mensagens.Any(m => m.Tipo == TipoNotificacaoEnum.Erro);
    public void Limpar() => _mensagens.Clear();

    public string ExibirNotificacao()
    {
        var mensagem = _mensagens.FirstOrDefault();

        if (mensagem == null)
            return "Nenhuma notificação.";

        return mensagem.Tipo == TipoNotificacaoEnum.Erro
         ? $"ERRO: {mensagem.Texto}"
         : $"SUCESSO: {mensagem.Texto}";

    }
}
