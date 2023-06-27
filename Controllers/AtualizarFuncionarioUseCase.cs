using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    public class AtualizarFuncionarioUseCase
{
    private readonly IFuncionarioRepository _funcionarioRepository;

    public AtualizarFuncionarioUseCase(IFuncionarioRepository funcionarioRepository)
    {
        _funcionarioRepository = funcionarioRepository;
    }

    public void Executar(Funcionario funcionario)
    {
        // Realizar validações e regras de negócio

        _funcionarioRepository.Atualizar(funcionario);
    }
}

}