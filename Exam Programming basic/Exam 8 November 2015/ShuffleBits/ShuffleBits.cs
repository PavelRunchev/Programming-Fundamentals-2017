using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace ShuffleBits
{
    class ShuffleBits
    {
        static void Main()
        {
            var firstNumber = long.Parse(Console.ReadLine());
            var secondNumber = long.Parse(Console.ReadLine());

            var binBig = Convert.ToString(firstNumber, 2);
            var binlow = Convert.ToString(secondNumber, 2);

            var bin1 = Convert.ToDouble(binBig);
            var bin2 = Convert.ToDouble(binlow);

            var reverse1 = new List<double>();
            var reverse2 = new List<double>();
            var i = 0;

            while (i < 32 && i < 32)
            {
                reverse1.Add(bin1 % 10);
                bin1 /= 10;
                reverse2.Add(bin2 % 10);
                bin2 /= 10;
                i++;
            }
            reverse1.Reverse();
            reverse2.Reverse();

            var digit1 = 0d;
            var digit2 = 0d;
            var index = 0;
            var binaryNumber = string.Empty;
            if (firstNumber >= secondNumber)
            {
                while (index < 32 && index < 32)
                {
                    digit1 = reverse1[index];
                    digit2 = reverse2[index];
                    index++;
                    binaryNumber += Convert.ToString((int)digit1, 2);
                    binaryNumber += Convert.ToString((int)digit2, 2);
                }
            }
            else
            {
                while (index < 32 && index < 32)
                {
                    digit1 = reverse1[index];
                    binaryNumber += Convert.ToString((int)digit1, 2);
                    digit1 = reverse1[index + 1];
                    binaryNumber += Convert.ToString((int)digit1, 2);
                    digit2 = reverse2[index];
                    binaryNumber += Convert.ToString((int)digit2, 2);
                    digit2 = reverse2[index + 1];
                    binaryNumber += Convert.ToString((int)digit2, 2);
                    index += 2;
                }
            }

            var result = BitConverter.DoubleToInt64Bits(binaryNumber);
            Console.WriteLine(result);
        }
    }
}
