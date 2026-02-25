using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OPP03
{
    internal class Cinema
    {
        private Projector _projector = new Projector();

        private Ticket[] _ticket=new Ticket[20];

        private static int counter = 0;
        public string CinemaName { get; set; }


        public void AddTicket(Ticket t)
        {


            for (int i = 0; i < _ticket.Length; i++)

            {

                if (_ticket[i] == null)
                {

                    _ticket[i] = t;
                    return;

                }



            }
        }


        public void PrintAllTickets() {

            for (int i = 0; i < _ticket.Length; i++) 
            
            {
                if (_ticket[i]!=null)

                Console.WriteLine(_ticket[i]);
            
            
            }
        
        
        }



        public void OpenCinema()=> _projector.OpenProjector();
        public void CloseCinema() => _projector.CloseProjector();



        public static string GenerateBookingReference()
        {
            counter++;
            return $"Booking Ref {counter}: BK-{counter} ";


        }


    }
}
