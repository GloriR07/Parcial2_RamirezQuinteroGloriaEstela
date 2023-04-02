using Microsoft.Data.SqlClient;
using System.Net.Sockets;
using Ticket_System___Bichota_Concert.DAL.Entities;


namespace Ticket_System___Bichota_Concert.DAL
{
    public class SeedDB
    {
        private readonly DatabaseContext _context;

        public SeedDB(DatabaseContext context)

        {
            List<Ticket> ListaTicket = new List<Ticket>();

            if (!_context.Tickets.Any())

                for (int i = 1; i <= 50000; i++)
                    _context.Tickets.Add(new Ticket { });
                {
                    var Ticket = new Ticket();
                    {
                        Ticket.CodTicket = +1;
                        Ticket.IsUsed = true;
                        Ticket.EntranceGate = "Porton de entrada";
                    }


                }
         
        }
    }
}
