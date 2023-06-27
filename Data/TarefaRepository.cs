using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class TarefaRepository : ITarefaRepository
{
    private readonly DbContext _context;

    public TarefaRepository(DbContext context)
    {
        _context = context;
    }

    public Tarefa ObterPorId(int id)
    {
        return _context.Tarefas.Find(id);
    }

    public IEnumerable<Tarefa> ObterTodas()
    {
        return _context.Tarefas.ToList();
    }

    public void Adicionar(Tarefa tarefa)
    {
        _context.Tarefas.Add(tarefa);
        _context.SaveChanges();
    }

    public void Atualizar(Tarefa tarefa)
    {
        _context.Tarefas.Update(tarefa);
        _context.SaveChanges();
    }

    public void Remover(Tarefa tarefa)
    {
        _context.Tarefas.Remove(tarefa);
        _context.SaveChanges();
    }
}
}