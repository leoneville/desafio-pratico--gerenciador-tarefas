namespace GerenciadorTarefas.Communication.Responses;

public class ResponseGetAllTarefasJson
{
    public List<ResponseShortTarefaJson> Tarefas { get; set; } = [];
}
