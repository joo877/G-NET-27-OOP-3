using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP03
{
    internal class Ticket
    {

        private decimal _price;
        public string MovieName { get; set; }

        public decimal PriceAfterTax => _price + _price * .14m;

        private static int ticketCounter = 0;

        public int TicketId { get; }
        public decimal Price
        {
            get { return _price; }
            set
            {

                if (value > 0)
                    _price = value;
                else
                    Console.WriteLine("Price must be greater than zero");


            }
        }

        public Ticket(string name , decimal price)
        {
            MovieName = name;
            Price = price;
            ticketCounter++;
            TicketId = ticketCounter;


        }

        public override string ToString()
        {
            return $" TicketId : {TicketId} | MovieName : {MovieName} | price : {Price} | PriceAfterTax : {PriceAfterTax}";
        }

        public static int GetTotalTickets()
        {
            return ticketCounter;
        }
    }
}
