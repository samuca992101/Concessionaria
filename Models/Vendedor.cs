namespace Loja_Carros2.Models
{
    public class Vendedor
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Matricula { get; set; }
        public float Salario { get; set; }
        public ICollection<Nota> notas { get; set; } = new List<Nota>();
    }
}
