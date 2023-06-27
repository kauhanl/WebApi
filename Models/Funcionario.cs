namespace WebApi.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
        public List<Tarefa> Tarefas { get; set; }
        
    }
}