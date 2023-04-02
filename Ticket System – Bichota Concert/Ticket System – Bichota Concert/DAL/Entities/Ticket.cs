using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ticket_System___Bichota_Concert.DAL.Entities;

    public class Ticket : Entity
    {
        [Display(Name = "Codigo boleta")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [RegularExpression("(^.[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Range(0, short.MaxValue, ErrorMessage = "Debe ingresar un valor numérico.")]
        
    public int CodTicket { get; set; }

        [Required]
        [Display(Name = "Fecha uso boleta")]
        public DateTime UseDate { get; set; }

        [Display(Name = "Boleta usada")]
        public bool  IsUsed { get; set; }

        public String? EntranceGate { get; set; }

    }
