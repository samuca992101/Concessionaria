namespace Loja_Carros2.Models
{
    public class Nota
    {
        public string Id { get; set; }
        public string Numero { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Garantia { get; set; }
        public float ValorVenda { get; set; }
        public Carro CarroVendido { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        
    }
}
