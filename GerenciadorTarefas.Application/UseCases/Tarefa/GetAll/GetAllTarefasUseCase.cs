using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.GetAll;

public class GetAllTarefasUseCase
{
    public ResponseGetAllTarefasJson Execute(List<ResponseTarefaJson> tarefas)
    {
        var getAllTarefas = new ResponseGetAllTarefasJson
        {
            Tarefas = tarefas.Select(item => new ResponseShortTarefaJson
            {
                Id = item.Id,
                Nome = item.Nome,
                Descricao = item.Descricao,
                Status = item.Status,
            }).ToList()
        };

        return getAllTarefas;
    }
}
