using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 10;
            int gold;
            int purchase;
 
            Console.WriteLine(" Сколько криссталов вам нужно ");
            purchase = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Сколько у вас золота? ");
            gold = Convert.ToInt32(Console.ReadLine());
            int total = (gold - price * purchase);

            Console.WriteLine(" У вас осталось золота " + total);
            Console.WriteLine(" У вас кристаллов " + purchase);
        }
    }
}
