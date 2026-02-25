using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP03
{
    internal class IMAXTicket : Ticket
    {

        public string Is3D { get; set; }

        public IMAXTicket(string name, decimal price, bool is3D) : base(name, price+= is3D?30:0)
        {
            Is3D = is3D ? "Yes" : "No";

        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | MovieName : {MovieName} | price : {Price} EGP | PriceAfterTax : {PriceAfterTax} EGP | Is3D : {Is3D}";
        }
    }
}
