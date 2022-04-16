
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Base
{
    public class BaseEntity: IDateCreated
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
