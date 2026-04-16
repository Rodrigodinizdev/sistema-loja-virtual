namespace loja_virtual.Interfaces.Notification;

public interface INotification
{
    void AdicionarErro(string mensagem);
    void AdicionarSucesso(string mensagem);
    bool TemNotificacao();
    void Limpar();
    IReadOnlyCollection<object> ExibirNotificacao();
}
