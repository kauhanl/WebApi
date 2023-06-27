using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    public class AdicionarTarefaUseCase
{
    private readonly ITarefaRepository _tarefaRepository;

    public AdicionarTarefaUseCase(ITarefaRepository tarefaRepository)
    {
        _tarefaRepository = tarefaRepository;
    }

    public void Executar(Tarefa tarefa)
    {
        // Realizar validações e regras de negócio

        _tarefaRepository.Adicionar(tarefa);
    }
}

}