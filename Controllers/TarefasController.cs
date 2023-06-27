using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
[Route("api/tarefas")]
public class TarefasController : ControllerBase
{
    private readonly AdicionarTarefaUseCase _adicionarTarefaUseCase;
    private readonly AtualizarTarefaUseCase _atualizarTarefaUseCase;
    private readonly RemoverTarefaUseCase _removerTarefaUseCase;

    public TarefasController(
        AdicionarTarefaUseCase adicionarTarefaUseCase,
        AtualizarTarefaUseCase atualizarTarefaUseCase,
        RemoverTarefaUseCase removerTarefaUseCase)
    {
        _adicionarTarefaUseCase = adicionarTarefaUseCase;
        _atualizarTarefaUseCase = atualizarTarefaUseCase;
        _removerTarefaUseCase = removerTarefaUseCase;
    }

    [HttpGet]
    public IActionResult ObterTodas()
    {
        // Obter todas as tarefas

        return Ok();
    }

    [HttpPost]
    public IActionResult AdicionarTarefa(Tarefa tarefa)
    {
        // Adicionar uma nova tarefa

        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarTarefa(int id, Tarefa tarefa)
    {
        // Atualizar uma tarefa existente

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult RemoverTarefa(int id)
    {
        // Remover uma tarefa existente

        return Ok();
    }
}
}