//using LINQ.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
    class Program
    {
        public static readonly string filePath = "../data.json";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            OutPut();
            //Test();
        }

        static void OutPut()
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\RevYolution\source\repos\LINQ\LINQ\data.json"))

            {
                JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                //Console.WriteLine($"{o}");
                //Console.ReadLine();

                var postDaHood =
                             from p in o["features"]
                             select (string)p["properties"]["neighborhood"];
                IEnumerable<string> notEmpty = postDaHood.Where(hood => hood != "");

                foreach (var item in notEmpty)
                {
                    Console.WriteLine(item);
                }
            }
        }

        //static void NoEmpty()
        //{
        //    using (StreamReader reader = File.OpenText(@"C:\Users\RevYolution\source\repos\LINQ\LINQ\data.json"))

        //    {
        //        JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
        //        //Console.WriteLine($"{o}");
        //        //Console.ReadLine();

        //        var postDaHood =
        //                        from p in o["features"]
        //                        where ["features.properties.neighborhood > 0"];
        //                        select (string)p["properties"]["neighborhood"];

        //        foreach (var item in postDaHood)
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }

        //}

    }
}
