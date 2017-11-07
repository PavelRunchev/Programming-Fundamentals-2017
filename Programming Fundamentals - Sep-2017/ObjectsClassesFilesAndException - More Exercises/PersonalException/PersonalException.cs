using System;

namespace PersonalException
{
    class DemoException : Exception
    {
        public DemoException() : base("My first exception is awesome!!!")
        {
           
        }
    }

    class PersonException
    {
        static void Main()
        {
            try
            {
                while (true)
                {
                    long number = long.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        throw new  DemoException();
                    }
                    Console.WriteLine(number);
                }
            }
            catch(DemoException de)
            {
                Console.WriteLine(de.Message);
            }           
        }
    }
}
