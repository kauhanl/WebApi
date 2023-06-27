namespace WebApi.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
    }
}