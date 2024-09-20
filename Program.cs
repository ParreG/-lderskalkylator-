namespace Ålderskalkylator___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void separator()
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }
          

            Console.WriteLine("Hej och välkommen till ålderskalkylatorn.");
            Console.WriteLine("Du ska berätta för mig vilket år, månad och dag du är född så ska jag säga till dig hur gammal du är.");
            separator();
            Console.WriteLine("Vilket år är du född? "); 
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vilket månad är du född? ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vilken dag är du född? ");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime birthday = new DateTime(year, month, day);

            separator();
            Console.WriteLine($"Idag är den {DateTime.Now} och för det år, månad och dag du är född till idag är det: ");
            
            TimeSpan difference = DateTime.Now - birthday;

            Console.WriteLine("Dagar: " + difference.Days);
            Console.WriteLine("Timmar: " + difference.Hours);
            Console.WriteLine("Minuter: " + difference.Minutes);
            Console.WriteLine("Sekunder: " + difference.Seconds);
            Console.WriteLine("Milisekunder: " + difference.Milliseconds);
            separator();

            Console.WriteLine("Nu kan jag med enkelhet säga att du är: ");
            Console.WriteLine(difference.Days / 365 + " år gammal.");

            Console.ReadLine();



        }
    }
}
