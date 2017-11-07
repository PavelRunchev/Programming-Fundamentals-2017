using System;

namespace RectangleProperties
{
    class RectangleProperties
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);

            PrintRectangleProperties(rectangle);          
        }

        public static void PrintRectangleProperties(Rectangle rectangle)
        {
            Console.WriteLine(rectangle.Perimeter);
            Console.WriteLine(rectangle.Area);
            Console.WriteLine(Rectangle.Diagonal(rectangle.Width, rectangle.Height));
        }
    }

    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Perimeter
        {
            get
            {
                return (Width + Height) * 2;
            }           
        }

        public double Area
        {
            get
            {
                return Width * Height;
            }
        }

        public static double Diagonal(double width, double height)
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
        }
    }
}
