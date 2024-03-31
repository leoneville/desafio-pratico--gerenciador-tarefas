using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.Delete;

public class DeleteTarefaUseCase
{
    public void Execute(Guid id, List<ResponseTarefaJson> tarefas)
    {
        var tarefa = tarefas.SingleOrDefault(tarefa => tarefa.Id == id);
        if (tarefa == null) return;

        tarefas.Remove(tarefa);
    }
}
