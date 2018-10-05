using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер билета:");
            int TicketNumber = Convert.ToInt32(Console.ReadLine());
            LuckyTicket Lucky = new LuckyTicket();
            Lucky.Result(TicketNumber);
            Console.ReadLine();
            Console.ReadLine();
        }

        class LuckyTicket
        {
            public void Result(int TicketNumber)
            {
                int FirstPart = (TicketNumber / 100000 % 10) + (TicketNumber / 10000 % 10) + (TicketNumber / 1000 % 10);
                int SecondPart = (TicketNumber / 100 % 10) + (TicketNumber % 100 / 10) + (TicketNumber % 10);
                if (FirstPart == SecondPart)
                {
                    Console.WriteLine("Счастливый билет!");
                }
                else { Console.WriteLine("Билет не счастливый!"); }
            }
        }
    }
}
