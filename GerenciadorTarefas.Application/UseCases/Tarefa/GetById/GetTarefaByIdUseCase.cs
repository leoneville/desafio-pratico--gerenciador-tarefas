using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.GetById;

public class GetTarefaByIdUseCase
{
    public ResponseTarefaJson? Execute(Guid id, List<ResponseTarefaJson> tarefas)
    {
        var tarefa = tarefas.FirstOrDefault(tarefa => tarefa.Id == id);

        return tarefa;
    }
}
