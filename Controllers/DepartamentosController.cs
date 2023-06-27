using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/departamentos")]
public class DepartamentosController : ControllerBase
{
    private readonly AdicionarDepartamentoUseCase _adicionarDepartamentoUseCase;
    private readonly AtualizarDepartamentoUseCase _atualizarDepartamentoUseCase;
    private readonly RemoverDepartamentoUseCase _removerDepartamentoUseCase;

    public DepartamentosController(
        AdicionarDepartamentoUseCase adicionarDepartamentoUseCase,
        AtualizarDepartamentoUseCase atualizarDepartamentoUseCase,
        RemoverDepartamentoUseCase removerDepartamentoUseCase)
    {
        _adicionarDepartamentoUseCase = adicionarDepartamentoUseCase;
        _atualizarDepartamentoUseCase = atualizarDepartamentoUseCase;
        _removerDepartamentoUseCase = removerDepartamentoUseCase;
    }

    [HttpGet]
    public IActionResult ObterTodos()
    {
        // Obter todos os departamentos

        return Ok();
    }

    [HttpPost]
    public IActionResult AdicionarDepartamento(Departamento departamento)
    {
        // Adicionar um novo departamento

        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarDepartamento(int id, Departamento departamento)
    {
        // Atualizar um departamento existente

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult RemoverDepartamento(int id)
    {
        // Remover um departamento existente

        return Ok();
    }
}
}