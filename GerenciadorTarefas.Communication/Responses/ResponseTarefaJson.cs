using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Responses;

public class ResponseTarefaJson
{
    public Guid Id { get; init; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public PrioridadeTypes Prioridade { get; set; }
    public DateTime DataLimite { get; set; }
    public StatusTypes Status { get; set; }
}
