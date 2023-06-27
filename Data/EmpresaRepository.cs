using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly DbContext _context;

    public EmpresaRepository(DbContext context)
    {
        _context = context;
    }

    public Empresa ObterPorId(int id)
    {
        return _context.Empresas.Find(id);
    }

    public IEnumerable<Empresa> ObterTodas()
    {
        return _context.Empresas.ToList();
    }

    public void Adicionar(Empresa empresa)
    {
        _context.Empresas.Add(empresa);
        _context.SaveChanges();
    }

    public void Atualizar(Empresa empresa)
    {
        _context.Empresas.Update(empresa);
        _context.SaveChanges();
    }

    public void Remover(Empresa empresa)
    {
        _context.Empresas.Remove(empresa);
        _context.SaveChanges();
    }
    }
}