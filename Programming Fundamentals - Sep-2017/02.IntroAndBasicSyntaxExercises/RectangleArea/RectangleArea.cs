using System;
using System.Text;


namespace RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{width * height:f2}");
        }
    }
}
