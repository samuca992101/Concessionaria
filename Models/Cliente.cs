namespace Loja_Carros2.Models
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string CPF { get; set; }
        public ICollection<Carro> CarrosComprados { get; set; } = new List<Carro>();
    }
}
