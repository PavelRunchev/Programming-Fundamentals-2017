using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace WriteToFile
{
    class WriteToFile
    {
        static void Main()
        {

            var input = File.ReadAllLines("..\\..\\sample_text.txt");
            char[] punctoation = new char[] { '.', ',', '!', '?', ':' };
            
            File.WriteAllText("..\\..\\output.txt", string.Empty);
            for (int i = 0; i < input.Length; i++)
            {
                string filtredText = string.Empty;
                foreach (var letter in input[i])
                {
                    if (!punctoation.Contains(letter))
                    {
                        filtredText += letter;
                    }
                }
                filtredText = filtredText + Environment.NewLine;
                File.AppendAllText("..\\..\\output.txt", filtredText);
            }                  
        }
    }
}
