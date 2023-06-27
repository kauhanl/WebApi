using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
    private readonly DbContext _context;

    public FuncionarioRepository(DbContext context)
    {
        _context = context;
    }

    public Funcionario ObterPorId(int id)
    {
        return _context.Funcionarios.Find(id);
    }

    public IEnumerable<Funcionario> ObterTodos()
    {
        return _context.Funcionarios.ToList();
    }

    public void Adicionar(Funcionario funcionario)
    {
        _context.Funcionarios.Add(funcionario);
        _context.SaveChanges();
    }

    public void Atualizar(Funcionario funcionario)
    {
        _context.Funcionarios.Update(funcionario);
        _context.SaveChanges();
    }

    public void Remover(Funcionario funcionario)
    {
        _context.Funcionarios.Remove(funcionario);
        _context.SaveChanges();
    }

    }
}