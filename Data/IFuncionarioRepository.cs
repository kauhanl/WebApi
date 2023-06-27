using WebApi.Models;

namespace WebApi.Data
{
    public interface  IFuncionarioRepository
    {
        Funcionario ObterPorId(int id);
    IEnumerable<Funcionario> ObterTodos();
    void Adicionar(Funcionario funcionario);
    void Atualizar(Funcionario funcionario);
    void Remover(Funcionario funcionario);
    }
}