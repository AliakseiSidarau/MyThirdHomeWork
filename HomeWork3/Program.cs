using System;

namespace HomeWork3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const float PI = 3.14f;

            Console.WriteLine("Введите радиус: ");

            int r = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите образующую: ");

            int l = Int32.Parse(Console.ReadLine());

            float square = PI * r * (r + l);

            Console.WriteLine($"Площадь поверхности круглого конуса: {square}");

            ///////////////////////////////

            int x = 14;
            int y = 1;
            int z = 5;

            x += y - x++ * z;

            Console.WriteLine($" x += y - x++ * z    x = {x}, y = {y}, z = {z}");

            z = --x - y * 5;

            Console.WriteLine($" z = --x - y * 5     x = {x}, y = {y}, z = {z}");

            y /= x + 5 % z;

            Console.WriteLine($" y /= x + 5 % z      x = {x}, y = {y}, z = {z}");

            z = x++ + y * 5;

            Console.WriteLine($" z = x++ + y * 5;    x = {x}, y = {y}, z = {z}");

            x = y - x++ * z;

            Console.WriteLine($" x = y - x++ * z;    x = {x}, y = {y}, z = {z}");

        }
    }
}
