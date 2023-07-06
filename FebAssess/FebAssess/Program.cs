﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Reflection.Emit;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Http;

namespace FebAssess
{
    internal class Program
    {
        public class EDAMAM
        {
            public string q { get; set; }
            public int from { get; set; }
            public int to { get; set; }
            public bool more { get; set; }
            public int count { get; set; }
            public links _links { get; set; }

            public hits[] hits { get; set; }         

        }
        public class hits
        {
            public recipe recipe { get; set; }
        }
        public class self
        {
            public string href { get; set; } 
            public string title { get; set; }
        }

        public class recipe
        {
            public string uri { get; set; }
            public string label { get; set; }
            public string image { get; set; }
            public Images images { get; set; }
            public string source { get; set; }
            public string url { get; set; }
            public string shareas { get; set; }
            public double yield { get; set; }
            public string[] dietlabels { get; set; }
            public string[] healthlabels { get; set; }
            public string[] cautions { get; set; }
            public string[] ingredientlines { get; set; }
            public ingredients[] ingredients { get; set; }
            public double calories { get; set; }
            public double totalC02Emissions { get; set; }
            public string co2EmissionsClass { get; set; }
            public double weight { get; set; }
            public double totalTime { get; set; }
            public string[] cuisineType { get; set; }
            public string[] mealType { get; set; }
            public string[] dishType { get; set; }
            public totalnut totalNutrients { get; set; }
            public totaldaily totaldaily { get; set; }
            public digest[] digests { get; set; }
            
        }
        public class digest
        {
            public string label { get; set; }
            public string tag { get; set; }
            public string schemaOrgTag { get; set; }
            public double total { get; set; }
            public bool hasRDI { get; set; }
            public double daily { get; set; }
            public string unit { get; set; }
            public sub[] subs { get; set; }

        }
        public class sub
        {
            public string label { get; set; }
            public string tag { get; set; }
            public string schemaOrgTag { get; set; }
            public double total { get; set; }
            public bool hasRDI { get; set; }
            public double daily { get; set; }
            public string unit { get; set; }

        }

        public class totalnut
        {
            public energycalc ENERC_KCAL { get; set; }
            public fat FAT { get; set; }
            public fatr FATRN { get; set; }
            public fams FAMS { get; set; }
            public Fapu FAPU { get; set; }
            public chocdf CHOCDF { get; set; }
            public fitbtg FIBTG { get; set; }
            public sugar SUGAR { get; set; }
            public procnt PROCNT { get; set; }
            public chloe CHLOE { get; set; }
            public na NA { get; set; }
            public ca CA { get; set; }
            public mg mg { get; set; }
            public k K { get; set; }
            public fe FE { get; set; }
            public zn ZN { get; set; }
            public p P { get; set; }
            public vita_rae VITA_RAE { get; set; }
            public vitc VITC { get; set; }
            public thia THIA { get; set; }
            public ribf RIBF { get; set; }
            public nia NIA { get; set; }
            public vitb6a VITB6A { get; set; }
            public foldfe FOLDFE { get; set; }
            public folfd FOLFD { get; set; }
            public vitba12 VITB12 { get; set; }
            public vitd VITD { get; set; }
            public topcha TOPCHA { get; set; }
            public vitk1 VITK1 { get; set; }
            public water WATER { get; set; }
        }
       public class totaldaily
        {
            public energycalc ENERC_KCAL { get; set; }
            public fat FAT { get; set; }
            public fatr FATRN { get; set; }
            public fams FAMS { get; set; }
            public Fapu FAPU { get; set; }
            public chocdf CHOCDF { get; set; }
            public fitbtg FIBTG { get; set; }
            public sugar SUGAR { get; set; }
            public procnt PROCNT { get; set; }
            public chloe CHLOE { get; set; }
            public na NA { get; set; }
            public ca CA { get; set; }
            public mg mg { get; set; }
            public k K { get; set; }
            public fe FE { get; set; }
            public zn ZN { get; set; }
            public p P { get; set; }
            public vita_rae VITA_RAE { get; set; }
            public vitc VITC { get; set; }
            public thia THIA { get; set; }
            public ribf RIBF { get; set; }
            public nia NIA { get; set; }
            public vitb6a VITB6A { get; set; }
            public foldfe FOLDFE { get; set; }
            public folfd FOLFD { get; set; }
            public vitba12 VITB12 { get; set; }
            public vitd VITD { get; set; }
            public topcha TOPCHA { get; set; }
            public vitk1 VITK1 { get; set; }
            public water WATER { get; set; }
        }

       public class energycalc
        {
            public string label { get; set;}
            public double quantity { get; set; }
            public string unit { get; set; }

        }
        public class fat
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }

        public class fatr
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class fams
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class Fapu
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
       public class chocdf
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
       public class chocdfnet
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class fitbtg
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class sugar
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class procnt
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
       public class chloe
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class na
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class ca
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class mg
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class k
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class fe
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class zn
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class p
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
       public class vita_rae
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class vitc
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class thia
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class ribf
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class nia
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
       public class vitb6a
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class foldfe
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class folfd
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
       public class folac
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
       public class vitba12
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class vitd
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
       public class topcha
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
       public class vitk1
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
       public class water
        {
            public string label { get; set; }
            public double quantity { get; set; }
            public string unit { get; set; }
        }
        public class ingredients
        {
            public string text { get; set; }
            public double quantity { get; set; }
            public string measure { get; set; }
            public string food { get; set; }
            public double weight { get; set; }
            public string foodCategory { get; set; }
            public string foodId { get; set; }
            public string image { get; set; }
        }

       public class Images
        {
            public thumbnail THUMBNAIL { get; set; }
            public small SMALL { get; set; }
            public regular REGULAR { get; set; }
        }

        public class thumbnail
        {
            public string url { get; set; }
            public int width { get; set; } 
            public int hieght { get; set; }

        }
        public class small
        {
            public string url { get; set; }
            public int width { get; set; }
            public int hieght { get; set; }
        }
        public class regular
        {
            public string url { get; set; }
            public int width { get; set; }
            public int hieght { get; set; }
        }
       public class next
        {
            public string href { get; set; }
            public string title { get; set; }
        }
        public class links
        {
           public next next { get; set; }
        }
        static string query = "egg";
        static string appId = "edfdc8f1";
        static string appKey = "50fa241eb8b5b6dd0d0f186ee7a347a0";
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("https://worldwide-recipes1.p.rapidapi.com/api/search?q=" + query);
            request.Method = WebRequestMethods.Http.Get;
            request.ContentType= "application/json; charset=utf-8";
            request.Headers.Add("X-RapidAPI-Key", "bc31ab951fmsh6e3e0e5f02b3095p1aa63cjsn3af8c76deead");
            request.Headers.Add("X-RapidAPI-Host", "worldwide-recipes1.p.rapidapi.com");
            string t;
            HttpWebResponse response =(HttpWebResponse) request.GetResponse();
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                t = sr.ReadToEnd();
            }

            WorldwideRecipes wr = JsonConvert.DeserializeObject<WorldwideRecipes>(t);
            EDAMAM e = null;
            List<EDAMAM> list = new List<EDAMAM>();
            string m = $"https://api.edamam.com/api/recipes/v2?type=public&q={query}&app_id={appId}&app_key={appKey}";
            bool b = false;
            while (!b)
            {
                b = edamamApi(ref m,e);
                list.Add(e);
            }

            Console.ReadKey();
            
        }

        static bool edamamApi(ref string m,EDAMAM e)
        {
            WebRequest r = WebRequest.Create(m);
            r.Method = WebRequestMethods.Http.Get;
            r.ContentType = "application/json; charset=utf-8";
            string l;
            HttpWebResponse resp = r.GetResponse() as HttpWebResponse;
            using(StreamReader sr = new StreamReader(resp.GetResponseStream()))
            {
                l = sr.ReadToEnd();
            }
           
            e =JsonConvert.DeserializeObject<EDAMAM>(l);
            if(e._links.next.href.Length > 0)
            {
                m = e._links.next.href;
                 return false;
            }

            return true;
            

        }







        }
}
