using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        StreamReader reader = File.OpenText(@"c:\person.json");
        
    JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
    // do stuff
        
    }
}
