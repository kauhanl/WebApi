namespace WebApi.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public List<Funcionario> Funcionarios { get; set; }

    }
}