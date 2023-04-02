using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ticket_System___Bichota_Concert.DAL.Entities
{
    public class Ticket : Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public DateTime UseDate { get; set; }

        public bool  IsUsed { get; set; }

        public Guid EntranceGate { get; set; }

    }
}
