using WebApi.Models;

namespace WebApi.Data
{
    public interface  IDepartamentoRepository
    {
        Departamento ObterPorId(int id);
    IEnumerable<Departamento> ObterTodos();
    void Adicionar(Departamento departamento);
    void Atualizar(Departamento departamento);
    void Remover(Departamento departamento);
    }
}