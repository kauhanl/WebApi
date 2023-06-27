using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    public class RemoverTarefaUseCase
{
    private readonly ITarefaRepository _tarefaRepository;

    public RemoverTarefaUseCase(ITarefaRepository tarefaRepository)
    {
        _tarefaRepository = tarefaRepository;
    }

    public void Executar(Tarefa tarefa)
    {
        // Realizar validações e regras de negócio

        _tarefaRepository.Remover(tarefa);
    }
}
}