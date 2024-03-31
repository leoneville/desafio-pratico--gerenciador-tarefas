using GerenciadorTarefas.Application.UseCases.Tarefa.Delete;
using GerenciadorTarefas.Application.UseCases.Tarefa.GetAll;
using GerenciadorTarefas.Application.UseCases.Tarefa.GetById;
using GerenciadorTarefas.Application.UseCases.Tarefa.Register;
using GerenciadorTarefas.Application.UseCases.Tarefa.Update;
using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TarefaController : ControllerBase
{
    private static List<ResponseTarefaJson> Tarefas = [];

    [HttpPost]
    [ProducesResponseType(typeof(List<ResponseTarefaJson>), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestTarefaJson request)
    {
        var useCase = new RegisterTarefaUseCase();

        var response = useCase.Execute(Tarefas, request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseGetAllTarefasJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTarefasUseCase();

        var response = useCase.Execute(Tarefas);

        if (response.Tarefas.Count == 0)
            return NoContent();

        return Ok(response);
    }

    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(ResponseTarefaJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var useCase = new GetTarefaByIdUseCase();

        var response = useCase.Execute(id, Tarefas);

        if (response == null) return NoContent();

        return Ok(response);
    }

    [HttpPut]
    [Route("{id:Guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] Guid id, [FromBody] RequestTarefaJson request)
    {
        var useCase = new UpdateTarefaUseCase();

        useCase.Execute(id, request, Tarefas);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] Guid id)
    {
        var useCase = new DeleteTarefaUseCase();

        useCase.Execute(id, Tarefas);

        return NoContent();
    }
}
