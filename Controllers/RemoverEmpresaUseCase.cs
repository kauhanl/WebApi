using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    public class RemoverEmpresaUseCase
{
    private readonly IEmpresaRepository _empresaRepository;

    public RemoverEmpresaUseCase(IEmpresaRepository empresaRepository)
    {
        _empresaRepository = empresaRepository;
    }

    public void Executar(Empresa empresa)
    {
        // Realizar validações e regras de negócio

        _empresaRepository.Remover(empresa);
    }
}
}