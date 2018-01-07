using System;
using System.IO;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static string inputFilePath;
        static void Main()
        {
            inputFilePath = @"..\..\input.txt";
            if (!File.Exists(inputFilePath))
            {
                File.Create(@"..\..\input.txt");
            }
            
            try
            {           
                File.WriteAllText(@"..\..\output.txt", string.Empty);
                StreamReader input = new StreamReader(inputFilePath);

                using (input)
                {
                    string line = input.ReadLine();
                    StreamWriter streamWriter = new StreamWriter(@"..\..\output.txt");
                    using (streamWriter)
                    {
                        while (line != null)
                        {
                            streamWriter.WriteLine($"{line}:");
                            for (int i = 0; i < line.Length; i++)
                            {
                                char letter = line[i];
                                int index = letter - 97;
                                string output = $"{letter} -> {index}";
                                streamWriter.WriteLine(output);
                            }
                        
                            line = input.ReadLine();
                        }
                    }
                }
            }
            catch(FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find file {0}", inputFilePath);
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Can not read the file {0}", inputFilePath);
            }
        }
    }
}
