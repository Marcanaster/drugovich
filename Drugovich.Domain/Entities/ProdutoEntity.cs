using Drugovich.Domain.Entities.Base;

namespace Drugovich.Domain.Entities
{
    public class ProdutoEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set;}
        public string Codigo { get; set; }
        public CategoriaEntity Categoria { get; set; }
        public bool Ativo { get; set; }
    }
}
