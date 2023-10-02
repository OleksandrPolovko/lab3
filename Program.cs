using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {

        static void Task1()
        {
            Console.WriteLine("Введіть першу довжину прямокутника:");
            string strA = Console.ReadLine();
            double A = Convert.ToDouble(strA);

            Console.WriteLine("Введіть другу довжину прямокутника:");
            string strB = Console.ReadLine();
            double B = Convert.ToDouble(strB);

            Rectangle rect = new Rectangle(A, B);
            Console.WriteLine("Площа прямокутника: " + rect.Area);
            Console.WriteLine("Периметер прямокутника: " + rect.CalculatePerimeter());
        }


        static void Main(string[] args)
        {
            Task1();
        }
    }
}
