using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();
            switch(type)
            {
                case "int":
                    var firstNumber = int.Parse(Console.ReadLine());
                    var secondNumber = int.Parse(Console.ReadLine());
                    var max = GetMaxNumber(firstNumber, secondNumber);
                    Console.WriteLine(max);
                    break;
                case "char":
                    char firstLetter = char.Parse(Console.ReadLine());
                    char secondLetter = char.Parse(Console.ReadLine());
                    var letter = GetMaxLetter(firstLetter, secondLetter);
                    Console.WriteLine(letter);
                    break;
                case "string":
                    string firstWord = Console.ReadLine();
                    string secondWord = Console.ReadLine();
                    string word = GetMaxWord(firstWord, secondWord);
                    Console.WriteLine(word);
                    break;
            }
        }

        private static string GetMaxWord(string firstWord, string secondWord)
        {
            if(firstWord.CompareTo(secondWord) >= 0)
            {
                return firstWord;
            }
            return secondWord;
        }

        private static object GetMaxLetter(char firstLetter, char secondLetter)
        {
            if(firstLetter.CompareTo(secondLetter) >= 0)
            {
                return firstLetter;
            }
            return secondLetter;
        }

        private static int GetMaxNumber(int firstNumber, int secondNumber)
        {
            if(firstNumber > secondNumber)
            {
                return firstNumber;
            }
            return secondNumber;
        }
    }
}
