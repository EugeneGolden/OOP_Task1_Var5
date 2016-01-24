using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Var5_OOP
{
    /*
    Создать класс Circle, разработав следующие элементы класса:
    d. Поля:
    double x, y; // координаты центра круга
    double r; // радиус круга
    e.  Конструктор, позволяющий создать экземпляр класса:
    с одним параметром,  задающим  радиус круга с центром в начале координат;
    с тремя параметрами.
    f. Методы, позволяющие:
    вывести радиус и координаты центра круга на экран;
    получить площадь круга;
    переместить круг на плоскости в заданную точку .
     */
    class Circle
    {
        double x, y;
        double r;

        public Circle(double radius)
        {
            x = 0;
            y = 0;
            r = radius;
        }

        public Circle(double axisX, double axisY, double radius)
        {
            x = axisX;
            y = axisY;
            r = radius;
        }

        public void Print()
        {
            Console.WriteLine("Radius = " + r);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }

        public double CircleSquare()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public void Movement(double newX, double newY)
        {
            x = newX;
            y = newY;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 4;
            Circle circ1 = new Circle(radius);
            //Выводим радиус и координаты центра круга на экран
            circ1.Print();
            //Рассчитываем площадь круга
            Console.WriteLine(circ1.CircleSquare());
            Console.WriteLine();

            double x = 3;
            double y = 7;
            radius = 5;
            Circle circ2 = new Circle(x, y, radius);
            //Выводим радиус и координаты центра второго круга на экран
            circ2.Print();
            //Рассчитываем площадь круга
            Console.WriteLine(circ2.CircleSquare());
            Console.WriteLine();

            Console.WriteLine("Устанавливаем новые координаты круга:");
            double newX = 8;
            double newY = 9;
            circ2.Movement(newX, newY);
            circ2.Print();

            Console.ReadKey();
        }
    }
}
