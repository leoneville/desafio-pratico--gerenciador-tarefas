using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Requests;

public class RequestTarefaJson
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao {  get; set; } = string.Empty;
    public PrioridadeTypes Prioridade { get; set; }
    public DateTime DataLimite { get; set; }
    public StatusTypes Status { get; set; }
}
