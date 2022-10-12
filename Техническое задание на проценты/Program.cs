using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Техническое_задание_на_проценты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите процент:");
            double percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Рeзультат:" + Percent(number, percent));
            Console.ReadKey();
        }
        static public double Percent(double numberone, double numbertwo)
        {
            return (numberone * numbertwo) / 100;
        }
    }
}
