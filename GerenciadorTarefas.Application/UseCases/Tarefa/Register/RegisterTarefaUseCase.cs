using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.Register;

public class RegisterTarefaUseCase
{
    public ResponseTarefaJson Execute(List<ResponseTarefaJson> tarefas, RequestTarefaJson request)
    {
        var tarefa = new ResponseTarefaJson
        {
            Id = Guid.NewGuid(),
            Nome = request.Nome,
            Descricao = request.Descricao,
            Prioridade = request.Prioridade,
            DataLimite = request.DataLimite,
            Status = request.Status
        };

        tarefas.Add(tarefa);

        return tarefa;
    }
}
