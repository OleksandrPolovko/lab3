using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    //Створити клас із ім'ям Rectangle.
    internal class Rectangle
    {
        //У тілі класу створити два поля, що описують довжини сторін double side1, side2
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            // в тілі якого поля side1 та side2 ініціалізуються значеннями аргументів.
            this.side1 = side1;
            this.side2 = side2;
        }

        //обчислюють площу прямокутника
        public double CalculateArea()
        {
            return side1 * side2;            
        }

        //периметр прямокутника
        public double CalculatePerimeter()
        {
            return side1 + side2;
        }

        public double Area
        { get { return CalculateArea(); } }

        public double Perimeter
        { get { return CalculatePerimeter(); } }

    }
}
