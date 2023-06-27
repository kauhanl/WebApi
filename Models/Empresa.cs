namespace WebApi.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
        // Propriedades adicionais da empresa...
        
    }
}