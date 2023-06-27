using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    public class AtualizarTarefaUseCase
{
    private readonly ITarefaRepository _tarefaRepository;

    public AtualizarTarefaUseCase(ITarefaRepository tarefaRepository)
    {
        _tarefaRepository = tarefaRepository;
    }

    public void Executar(Tarefa tarefa)
    {
        // Realizar validações e regras de negócio

        _tarefaRepository.Atualizar(tarefa);
    }
}
}