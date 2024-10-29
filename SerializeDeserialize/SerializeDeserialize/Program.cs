using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.IO;

namespace SerializeDeserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  List<string> yaradırsınız. Bunu names.json adlı jsona yazırsınız.

  Program cs de ashagidaki methodlari yazirsiz:
  void Add(string name) -names.json file - inde datalari cekib deserialize edirsiz(List<string>) 
                  Liste gonderilen deyeri elave edib yeniden serialize edib names.json - a gonderirsiz
  bool Search(stiring name) -names.json file - sinde datalari cekib deserialize edirsiz(List<string>)  
                  Listde gonderilen deyer movcuddursa true, deyilse false qaytaran method(Predicate istifade edin)

  void Delete(int index) -names.json file - sinde datalari cekib deserialize edirsiz(List<string>)
                  Listden gonderilen deyeri silib yeniden serialize edib names.json - a gonderirsiz

  elave olaraq File ve Directorynin metodlari ile emeliyatlar aparirsiz(yarat sil yaz oxu ve s.)*/

            string path = @"C:\Users\LENOVO\source\repos\SerializeDeserialize\SerializeDeserialize\names.json";

            List<string> list = new List<string>() { "Ehmed,Rufet,Cefer" };
            var data = JsonConvert.SerializeObject(list);
            using (var str = new StreamWriter(path))
            {
                str.WriteLine(data);
            };

          

            void Add(string name)
            {
                string result;

                using (var sr = new StreamReader(path))
                {
                    result = sr.ReadToEnd();
                }
                List<string> names = new List<string>();
                var deserialize = JsonConvert.DeserializeObject<List<string>>(result);
                foreach (var item in deserialize)
                {
                    var a = item.Split(',');
                    foreach (var i in a)
                    {
                        names.Add(i);
                    }

                }
                names.Add(name);

                using (var str = new StreamWriter(path))
                {
                    str.WriteLine(JsonConvert.SerializeObject(names));
                }

            }


            bool Search(string name)
            {
                var result = "";
                using (var streamReader = new StreamReader(path))
                {
                    result += streamReader.ReadToEnd();
                }
                var deSeralize = JsonConvert.DeserializeObject<List<string>>(result);
                foreach (var item in deSeralize)
                {
                    var searchContains = item.Contains(name);
                    if (searchContains)
                    {
                        return true;
                    }
                }
                return false;
            }
            
            void Deletee(int index)
            {
                string result;

                using (var read = new StreamReader(path))
                {
                     result = read.ReadToEnd();  
                }
                var deSeralize = JsonConvert.DeserializeObject <List<string>>(result);
                deSeralize.RemoveAt(index);

                using (var write = new StreamWriter(path))
                {
                    write.Write(JsonConvert.SerializeObject(deSeralize));
                }
                   

            }

            Add("Test");

            Console.WriteLine(Search("Test"));

            Deletee(1);

        }

    }
}
