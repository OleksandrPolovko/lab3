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

        static void Task2()
        {
            Console.Write("Назва фігури: ");
            string name = Console.ReadLine();
            Console.Write("З скількох точок складається фігура (3-5): ");
            string sNum = Console.ReadLine();
            int num = Convert.ToInt32(sNum);
            if (num<3 || num>5)
            {
                Console.Write("Неправильне значення");
                return;
            }
            Point[] points = new Point[num];
            for (int i=0;i<num;i++)
            {
                Console.Write("Точка" + i + " X=");
                string sX = Console.ReadLine();
                double x = Convert.ToDouble(sX);
                Console.Write("Точка" + i + " Y=");
                string sY = Console.ReadLine();
                double y = Convert.ToDouble(sY);
                points[i] = new Point(x, y);
            }
            Figure f;
            if (num == 3)
                f = new Figure(name, points[0], points[1], points[2]);
            else if (num == 4)
                f = new Figure(name, points[0], points[1], points[2], points[3]);
            else
                f = new Figure(name, points[0], points[1], points[2], points[3], points[4]);

            Console.WriteLine("Фігура " + f.Title + " має периметер " + f.Perimeter);
        }
        static void Main(string[] args)
        {
            //Task1();
            Task2();
            Console.Read();
        }
    }
}
