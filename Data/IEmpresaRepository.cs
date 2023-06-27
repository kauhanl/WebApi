using WebApi.Models;

namespace WebApi.Data
{
    public interface  IEmpresaRepository
    {
    private Empresa ObterPorId(int id);
    IEnumerable<Empresa> ObterTodas();
    void Adicionar(Empresa empresa);
    void Atualizar(Empresa empresa);
    void Remover(Empresa empresa);
    }
}