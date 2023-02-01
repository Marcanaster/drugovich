using Drugovich.Domain.Entities.Base;

namespace Drugovich.Domain.Entities
{
    public class GrupoEntity : BaseEntity
    {
        public GrupoEntity()
        {
            Clientes = new List<ClienteEntity>();
        }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public ICollection<ClienteEntity> Clientes { get; set; }
    }
}
