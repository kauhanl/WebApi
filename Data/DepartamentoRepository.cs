using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class DepartamentoRepository : IDepartamentoRepository
{
    private readonly DbContext _context;

    public DepartamentoRepository(DbContext context)
    {
        _context = context;
    }

    public Departamento ObterPorId(int id)
    {
        return _context.Departamentos.Find(id);
    }

    public IEnumerable<Departamento> ObterTodos()
    {
        return _context.Departamentos.ToList();
    }

    public void Adicionar(Departamento departamento)
    {
        _context.Departamentos.Add(departamento);
        _context.SaveChanges();
    }

    public void Atualizar(Departamento departamento)
    {
        _context.Departamentos.Update(departamento);
        _context.SaveChanges();
    }

    public void Remover(Departamento departamento)
    {
        _context.Departamentos.Remove(departamento);
        _context.SaveChanges();
    }
}
}