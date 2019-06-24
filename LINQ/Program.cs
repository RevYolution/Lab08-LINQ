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
            Console.WriteLine("Neighborhoods of Manhattan");
            Console.WriteLine("========================");
            //AllHoods();
            //NoEmptyStrings();
            OnlyDistinct();
            //OutPutRefac();
        }

        /// <summary>
        /// Outputs all neighborhoods from JSON data file
        /// </summary>
        static void AllHoods()
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\RevYolution\source\repos\LINQ\LINQ\data.json"))

            {
                JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                //Console.WriteLine($"{o}");
                //Console.ReadLine();

                var postDaHood =
                             from p in o["features"]
                             select (string)p["properties"]["neighborhood"];

                foreach (var item in postDaHood)
                {
                    Console.WriteLine(item);
                }


            }
        }

        /// <summary>
        /// Outputs all neighborhoods of Manhattan data without empty string data. 
        /// </summary>
        static void NoEmptyStrings()
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\RevYolution\source\repos\LINQ\LINQ\data.json"))

            {
                JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));

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

        /// <summary>
        /// Outputs all neighborhoods of Manhattan data without duplication of neighborhoods. 
        /// </summary>
        static void OnlyDistinct()
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\RevYolution\source\repos\LINQ\LINQ\data.json"))

            {
                JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));

                var postDaHood =
                             from p in o["features"]
                             select (string)p["properties"]["neighborhood"];
                IEnumerable<string> notEmpty = postDaHood.Where(hood => hood != "");

                IEnumerable<string> noDups = notEmpty.Distinct();

                foreach (var item in noDups)
                {
                    Console.WriteLine(item);
                }
            }
        }

        /// <summary>
        /// Chains the previous methods together 
        /// </summary>
        static void OutPutRefac()
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\RevYolution\source\repos\LINQ\LINQ\data.json"))

            {
                JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                var postDaHood =
                             from p in o["features"]
                             select (string)p["properties"]["neighborhood"];
                IEnumerable<string> refacOutput = postDaHood.Where(hood => hood != "").Distinct();

                foreach (var item in refacOutput)
                {
                    Console.WriteLine(item);
                }
            }
        }


    }
}
