using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Responses;

public class ResponseShortTarefaJson
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao {  get; set; } = string.Empty;
    public StatusTypes Status { get; set; }
}
