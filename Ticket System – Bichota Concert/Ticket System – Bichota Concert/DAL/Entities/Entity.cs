using System.ComponentModel.DataAnnotations;

namespace Ticket_System___Bichota_Concert.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
    }
}
