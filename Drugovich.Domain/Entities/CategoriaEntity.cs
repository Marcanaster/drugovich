using Drugovich.Domain.Entities.Base;

namespace Drugovich.Domain.Entities
{
    public  class CategoriaEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
