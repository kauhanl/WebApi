using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    public class AdicionarDepartamentoUseCase
{
    private readonly IDepartamentoRepository _departamentoRepository;

    public AdicionarDepartamentoUseCase(IDepartamentoRepository departamentoRepository)
    {
        _departamentoRepository = departamentoRepository;
    }

    public void Executar(Departamento departamento)
    {
        // Realizar validações e regras de negócio

        _departamentoRepository.Adicionar(departamento);
    }
}
}