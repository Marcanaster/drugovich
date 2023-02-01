using Drugovich.Domain.Entities.Base;

namespace Drugovich.Domain.Entities
{
    public class ClienteEntity: BaseEntity
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataFundacao { get; set; }
        public int GrupoRef { get; set; }
        public GrupoEntity Grupo { get; set; }

    }
}
