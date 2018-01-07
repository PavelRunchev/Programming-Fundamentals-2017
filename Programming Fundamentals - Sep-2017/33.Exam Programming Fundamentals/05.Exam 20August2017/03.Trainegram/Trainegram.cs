using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Trainegram
{
    class Trainegram
    {
        static void Main()
        {
            string pattern = @"^\<\[[^A-Za-z0-9]*\]\.{1}(\.\[[A-Za-z0-9]*\]\.)*$";
            Regex regex = new Regex(pattern);
            string inputTrain;
            while ((inputTrain = Console.ReadLine()) != "Traincode!")
            {
                Match matchedTrain = regex.Match(inputTrain);
                if (matchedTrain.Success)
                {                 
                    Console.WriteLine(inputTrain);                 
                }
            }
        }
    }
}
