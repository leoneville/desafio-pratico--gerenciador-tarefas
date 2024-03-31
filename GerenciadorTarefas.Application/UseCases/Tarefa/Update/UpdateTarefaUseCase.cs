using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.Update;

public class UpdateTarefaUseCase
{
    public void Execute(Guid id, RequestTarefaJson request, List<ResponseTarefaJson> tarefas)
    {
        var tarefa = tarefas.SingleOrDefault(tarefa => tarefa.Id == id);
        if (tarefa == null) return;

        tarefa.Nome = request.Nome;
        tarefa.Descricao = request.Descricao;
        tarefa.Prioridade = request.Prioridade;
        tarefa.DataLimite = request.DataLimite;
        tarefa.Status = request.Status;
    }
}
