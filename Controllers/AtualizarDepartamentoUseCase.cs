using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    public class AtualizarDepartamentoUseCase
{
    private readonly IDepartamentoRepository _departamentoRepository;

    public AtualizarDepartamentoUseCase(IDepartamentoRepository departamentoRepository)
    {
        _departamentoRepository = departamentoRepository;
    }

    public void Executar(Departamento departamento)
    {
        // Realizar validações e regras de negócio

        _departamentoRepository.Atualizar(departamento);
    }
}
}