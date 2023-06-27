using WebApi.Models;

namespace WebApi.Data
{
    public interface  ITarefaRepository
    {
        Tarefa ObterPorId(int id);
    IEnumerable<Tarefa> ObterTodas();
    void Adicionar(Tarefa tarefa);
    void Atualizar(Tarefa tarefa);
    void Remover(Tarefa tarefa);

    }
}