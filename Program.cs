using System;
using System.IO;

namespace Ticketing_system
{
    class Program
    {
        static void Main(string[] args)
        {
           // Build data file with initial system tickets and data in a CSV
          //Write Console application to process and add records to the CSV file
          Console.WriteLine("Welcome to the Ticketing System");
            string file = "tickets.csv";
            string choice;
            do
            {
               
                Console.WriteLine("1) Read Ticket");
                Console.WriteLine("2) Create Ticket");
                Console.WriteLine("Enter any other key to exit.");
                
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    
                  if (File.Exists(file))
                    {
                        
                        
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                            
                        }
                        sr.Close();
                    }
                }
                else if (choice == "2")
                {
                    
                    StreamWriter sw = new StreamWriter(file);
                    for (int i = 0; i < 7; i++)
                    {
                    
Console.WriteLine("________________________");
                    Console.WriteLine("0.) TicketID");
                    Console.WriteLine("1.) Summary");
                    Console.WriteLine("2.) Status");
                    Console.WriteLine("3.) Priority");
                    Console.WriteLine("4.) Submitter");
                    Console.WriteLine("5.) Assigned");
                    Console.WriteLine("6.) Watching");
                    Console.WriteLine("type esc to exit");
                    Console.WriteLine("________________________");
Console.WriteLine();
                    Console.WriteLine("Please Enter data for "+i);
                    String entry = Console.ReadLine().ToLower();
            if (entry == "esc")
           { break; }
            else
           { sw.WriteLine(entry);}
                        
                    }
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");
        }
    }
}
