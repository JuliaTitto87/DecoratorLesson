using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair chair1 = new SquareChair();
            chair1 = new ChairWithBackrest(chair1); // Квадратный стул со спинкой
            Console.WriteLine("Name: {0}", chair1.Name);
            Console.WriteLine("Cost: {0}", chair1.GetCost());

            Chair chair2 = new SquareChair();
            chair2 = new ChairWithSoftSeat(chair2);// Квадратный стул с мягким сиденьем
            Console.WriteLine("Name: {0}", chair2.Name);
            Console.WriteLine("Cost: {0}", chair2.GetCost());

            Chair chair3 = new RoundChair();
            chair3 = new ChairWithBackrest(chair3);
            chair3 = new ChairWithSoftSeat(chair3);// Круглый стул со спинкой и мягким сиденьем  
            Console.WriteLine("Name: {0}", chair3.Name);
            Console.WriteLine("Cost: {0}", chair3.GetCost());

            Console.ReadLine();
        }
    }
}
