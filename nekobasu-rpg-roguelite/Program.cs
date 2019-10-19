using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace nekobasu_rpg_roguelite
{
    class Program
    {
        public static Dictionary<string,Classes.Type> types = new Dictionary<string, Classes.Type>();
        static void Main(string[] args)
        {
            Func<Attribute, Type, string> func = (a, t) => $"{a.ToString()} of {t}";
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(func));
            Run();
            Console.ReadLine();
        }

        static void Run()
        {
            Load();
            foreach(Classes.Type type in types.Values)
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
            types = JsonConvert.DeserializeObject<Dictionary<string, Classes.Type>>(File.ReadAllText(@"Data\types.json"));
        }
    }
}
