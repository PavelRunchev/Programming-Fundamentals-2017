using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingValidation
{
    class ParkingValidation
    {
        static void Main()
        {
            var dataUsers = new Dictionary<string, string>();
            int numberOfLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLine; i++)
            {
                string[] input = Console.ReadLine().Split();
                string user = input[1];
                if (input[0] == "register")
                {              
                    string plateNumber = input[2];
                    bool isValid = CheckValidPlateNumber(plateNumber);
                    if (dataUsers.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dataUsers[user]}");
                    }
                    else if (dataUsers.ContainsValue(plateNumber))
                    {
                        Console.WriteLine($"ERROR: license plate {plateNumber} is busy");
                    }
                    else if (!dataUsers.ContainsKey(user) && isValid)
                    {
                        dataUsers.Add(user, plateNumber);
                        Console.WriteLine($"{user} registered {plateNumber} successfully");
                    }                
                    else if(!isValid)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plateNumber}");
                    }
                }
                else if(input[0] == "unregister")
                {
                    if (!dataUsers.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        dataUsers.Remove(user);
                        Console.WriteLine($"user {user} unregistered successfully");
                    }
                }
            }

            foreach (var user in dataUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        private static bool CheckValidPlateNumber(string plateNumber)
        {
            bool isLength = false;          
            if(plateNumber.Length == 8)
            {
                isLength = true;
            }

            char[] middle = plateNumber.Skip(2).Take(4).ToArray();
            bool isMiddleCharacter = CheckForDigit(middle);

            char[] firstUpperLetter = plateNumber.Take(2).ToArray();
            char[] lastUpperLetter = plateNumber.Reverse().Take(2).ToArray();
            char[] upperLetter = firstUpperLetter.Concat(lastUpperLetter).ToArray();
            bool isUpperLetter = CheckForUpperLetters(upperLetter);

            return isLength && isMiddleCharacter && isUpperLetter;
        }

        private static bool CheckForUpperLetters(char[] upperLetter)
        {
            bool isUpper = true;
            for (int i = 0; i < upperLetter.Length; i++)
            {
                char letter = upperLetter[i];
                if (!char.IsUpper(letter))
                {
                    isUpper = false;
                    break;
                }
            }
            return isUpper;
        }

        private static bool CheckForDigit(char[] middle)
        {
            bool isDigit = true;
            for (int i = 0; i < middle.Length; i++)
            {
                char token = middle[i];
                if (!char.IsDigit(token))
                {
                    isDigit = false;
                    break;
                }
            }
            return isDigit;
        }
    }
}
