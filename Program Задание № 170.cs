using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program170
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Номер пальца (1–5): ");
            if (!int.TryParse(Console.ReadLine(), out int finger))
            {
                Console.WriteLine("Ошибка.");
                return;
            }

            string name;
            switch (finger)
            {
                case 1: name = "Большой"; break;
                case 2: name = "Указательный"; break;
                case 3: name = "Средний"; break;
                case 4: name = "Безымянный"; break;
                case 5: name = "Мизинец"; break;
                default:
                    Console.WriteLine("Неверный номер.");
                    return;
            }
            Console.WriteLine(name);
        }
    }
}