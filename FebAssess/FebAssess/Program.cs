using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FebAssess
{
    internal class Program
    {
        class EDAMAM
        {
            public int from { get; set; }
            public int to { get; set; }
            public int count { get; set; }
            public links _links { get; set; }

            public recipe recipe { get; set; }

        }

        class recipe
        {
            public string uri { get; set; }
            public string label { get; set; }
            public Images image { get; set; }
            public string source { get; set; }
            public string url { get; set; }
            public string shareas { get; set; }
            public int yield { get; set; }
            public string[] dietlabels { get; set; }
            public string[] healthlabels { get; set; }
            public string[] cautions { get; set; }
            public string[] ingredientlines { get; set; }
            public ingredients[] ingredients { get; set; }
            public double calories { get; set; }
            public double totalC02Emissions { get; set; }
            public double co2EmissionsClass { get; set; }
            public double weight { get; set; }
            public int totalTime { get; set; }
            public string[] cuisineType { get; set; }
            public string[] mealType { get; set; }
            public string[] dishType { get; set; }

            
        }

        class totalnut
        {

        }

        class energycalc
        {

        }
        class ingredients
        {
            public string text { get; set; }
            public int quantity { get; set; }
            public string measure { get; set; }
            public string food { get; set; }
            public int weight { get; set; }
            public string foodCategory { get; set; }
            public string foodId { get; set; }
            public string image { get; set; }
        }

        class Images
        {
            public thumbnail THUMBNAIL { get; set; }
            public small SMALL { get; set; }
            public regular REGULAR { get; set; }
        }

        class thumbnail
        {
            public string url { get; set; }
            public int width { get; set; } 
            public int hieght { get; set; }

        }
        class small
        {
            public string url { get; set; }
            public int width { get; set; }
            public int hieght { get; set; }
        }
        class regular
        {
            public string url { get; set; }
            public int width { get; set; }
            public int hieght { get; set; }
        }
        class next
        {
            public string href { get; set; }
            public string title { get; set; }
        }
        class links
        {
           public next next { get; set; }
        }
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("https://api.edamam.com/api/recipes/v2");
            request.Method = WebRequestMethods.Http.Get;
            request.ContentType = "application/json; charset utf-8";
            string t;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using(StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                t = sr.ReadToEnd();
            }

            Console.ReadKey();
        }

        


    }
}
