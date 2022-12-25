using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace pw6
{
    internal class Program
    {
        public static string PutdoFile;
        static void Main(string[] args)
        {
            Class1.Init();
            while (true)
            {
                Console.WriteLine("This program is using for converting files in 3 file's premisson");
                Console.WriteLine("F1 - Write file, F3 - Open file.");
                ConsoleKey consoleKey = Console.ReadKey().Key;
                if (consoleKey == ConsoleKey.F1)
                        Console.WriteLine("Choose a premission. 1 txt. 2 json. 3 xml. Esc for exit");
                        ConsoleKey consoleKey1 = Console.ReadKey().Key;
                        if (consoleKey1 == ConsoleKey.D1)
                        {


                            convert.InTXT(convert.class1s);
                            Console.WriteLine("Done in TXT");
                        }
                        else if (consoleKey1 == ConsoleKey.D2)
                        {

                            convert.InJson();
                            Console.WriteLine("Done in JSON");
                        }
                        else if (consoleKey1 == ConsoleKey.D3)
                        {
                            convert.InXML();
                            Console.WriteLine("Done in XML");
                        }
                        else if (consoleKey1 == ConsoleKey.Escape)
                        {
                            Environment.Exit(0);
                        }
                        
                    else if (consoleKey == ConsoleKey.F3)
                        Console.WriteLine("Write a path for file.");
                        PutdoFile = Console.ReadLine();
                        if (File.Exists(PutdoFile))
                        {
                            if (PutdoFile.Contains(".txt"))
                            {
                                var arr = convert.FromTXT();
                                foreach (var item in arr)
                                {
                                    Console.WriteLine($"{item.Name}\n{item.Age}\n{item.Height}");
                                }
                            }
                            else if (PutdoFile.Contains(".json"))
                            {
                                var arr = convert.FromJson();
                                foreach (var item in arr)
                                {
                                    Console.WriteLine($"{item.Name}\n{item.Age}\n{item.Height}");
                                }
                            }
                            else if (PutdoFile.Contains(".xml"))
                            {
                                var arr = convert.FromXML();
                                convert.class1s = convert.FromXML();
                                foreach (var item in arr)
                                {
                                    Console.WriteLine($"{item.Name}\n{item.Age}\n{item.Height}");
                                }
                            }
                        }
                        else if (consoleKey == ConsoleKey.Escape)
                {
                        Environment.Exit(0);
                }
                        else
                        {
                            Console.WriteLine("File doesn't exists. Maybe you wrote wrong path.");
                        }
                      

                
            }
        }
    }
}