using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    public class RemoverDepartamentoUseCase
{
    private readonly IDepartamentoRepository _departamentoRepository;

    public RemoverDepartamentoUseCase(IDepartamentoRepository departamentoRepository)
    {
        _departamentoRepository = departamentoRepository;
    }

    public void Executar(Departamento departamento)
    {
        // Realizar validações e regras de negócio

        _departamentoRepository.Remover(departamento);
    }
}
}