namespace Drugovich.Domain.Dtos
{
    public class ClienteDto
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string CNPJ { get; set; }
        public int GrupoRef { get; set; }
        public DateTime DataFundacao { get; set; }
    }
}
