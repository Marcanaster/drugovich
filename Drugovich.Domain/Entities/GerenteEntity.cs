using Drugovich.Domain.Entities.Base;
using Drugovich.Domain.Enums;

namespace Drugovich.Domain.Entities
{
    public class GerenteEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Email { get; set; }
        public NivelGerenteEnum Nivel { get; set; }
        public UsuarioEntity Usuario{ get; set; }
    }
}
