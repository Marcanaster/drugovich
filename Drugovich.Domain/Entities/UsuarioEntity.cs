using Drugovich.Domain.Entities.Base;

namespace Drugovich.Domain.Entities
{
    public class UsuarioEntity : BaseEntity
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public GerenteEntity Gerente { get; set; }
        public int GerenteRef { get; set; }
    }
}
