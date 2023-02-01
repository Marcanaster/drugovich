using System.ComponentModel.DataAnnotations;

namespace Drugovich.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        private DateTime? _createAt;

        //protected BaseEntity()
        //{
        //    Id = Guid.NewGuid();
        //}

        public DateTime? CreatAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }

        public void Create(int id)
        {
            Id = id;
        }

    }
}
