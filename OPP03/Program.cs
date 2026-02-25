namespace OPP03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01
            #region Q1
            /*
             1-Composition
             2-Association
             3-Inheritance
             4-Aggregation
             5-Dependency
             
             */
            #endregion
            #region Q02
            /*
             a- child class can access protected field from parnt. an object instance from chiled to outside can be access this field (behaivor as a private field)
             
              
      b-                            with inheritance               Vs             without inheritance 

     protected internal     access in same assembly and other                   access in same assembly only 
    private protected         access in same assembly only                      access in class only   
            


            c- sealed with class :  class cannot inhirt (can be child , cannot be parent  and an still create objects  ) 
               sealed with method :  prevent further overriding 

            d- Yes! Sealed prevents inheritance, not instantiation. You can still create objects.
             */
            #endregion
            #endregion

            #region part02
            //Cinema cinema = new Cinema();
            //VIPTicket  vIP = new VIPTicket("Avengers", 200m,true,50m);
            //StandardTicket standard = new StandardTicket ("Inception",120m,"A-5");
            //IMAXTicket iMAX = new IMAXTicket("Dune",180m,false);
            //Console.WriteLine(" ::::::::: Cinema Opened :::::::");
            //cinema.OpenCinema();

            //cinema.AddTicket(standard);
            //cinema.AddTicket (vIP);
            //cinema.AddTicket(iMAX);

            //Console.WriteLine();
            //Console.WriteLine("::::::: All Tickets :::::::::");
            //cinema.PrintAllTickets();


            //Console.WriteLine();
            //Console.WriteLine(":::::::::: Statistics  ::::::::::");
            //Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");
            //Console.WriteLine($"{Cinema.GenerateBookingReference()}");
            //Console.WriteLine($"{Cinema.GenerateBookingReference()}");


            #endregion
        }
    }
}
