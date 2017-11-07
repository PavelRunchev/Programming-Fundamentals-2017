using System;

namespace PhotoGallery
{
    class PhotoGallery
    {
        static void Main()
        {
            var numberOfPhoto = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var size = int.Parse(Console.ReadLine());
            var widthPixel = int.Parse(Console.ReadLine());
            var heightPixel = int.Parse(Console.ReadLine());

            string photoSize = string.Empty;
            if (size < 1024)
            {
                photoSize = size.ToString() + "B";
            }
            else if(size < 1048576)
            {
                photoSize = (size / 1000.0).ToString() + "KB";
            }
            else if(size > 1048576)
            {
                photoSize = (size / 1000000.0).ToString() + "MB";
            }

            string resolution = string.Empty;
            if(widthPixel == heightPixel)
            {
                resolution = "square";
            }
            else if(widthPixel > heightPixel)
            {
                resolution = "landscape";
            }
            else if(widthPixel < heightPixel)
            {
                resolution = "portrait";
            }

            Console.WriteLine($"Name: DSC_{numberOfPhoto:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");           
            Console.WriteLine($"Size: {photoSize}");
            Console.WriteLine($"Resolution: {widthPixel}x{heightPixel} ({resolution})");
        }
    }
}
