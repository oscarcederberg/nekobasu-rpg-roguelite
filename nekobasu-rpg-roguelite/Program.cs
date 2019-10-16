using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace nekobasu_rpg_roguelite
{
    class Program
    {
        static List<Classes.Type> types = new List<Classes.Type>();
        static void Main(string[] args)
        {
            Run();
            Console.ReadLine();
        }

        static void Run()
        {
            Load();

            foreach(Classes.Type type in types)
            {
                Console.WriteLine(type);
            }
        }

        static void Load()
        {
            LoadTypes();
        }

        static void LoadTypes()
        {
            types = JsonConvert.DeserializeObject<List<Classes.Type>>(File.ReadAllText(@"Data\types.json"));
        }
    }
}
