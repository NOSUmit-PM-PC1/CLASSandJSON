using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Subject teh1 = new Subject("Технологии программирования", 72, 1);
             Console.WriteLine(teh1);

             Subject teh2 = new Subject("Технологии программирования", 68, 2);
             Console.WriteLine(teh2);

             var teh1JSON = JsonConvert.SerializeObject(teh1);
             Console.WriteLine(teh1JSON);

             List<Subject> subjects = new List<Subject>();
             subjects.Add(teh1);
             subjects.Add(teh2);

             JsonSerializer sr = new JsonSerializer();
             using (StreamWriter file = new StreamWriter("data.json"))
             {
                 using (JsonWriter jw = new JsonTextWriter(file))
                 {
                     sr.Serialize(jw, subjects);

                 }
             }
             */
            List<Subject> sb = new List<Subject>();
            using (StreamReader sr = new StreamReader("data.json"))
            {
                sb = JsonConvert.DeserializeObject<List<Subject>>(sr.ReadToEnd());
            }

            foreach(var s in sb)
                Console.WriteLine(s);

            Employee md = new Employee("Макаренко", "Мария", 0.5);
            md.AddSubject(sb[0]);
            md.AddSubject(sb[1]);
            md.AddSubject(sb[2]);
       
            


            var mdJson = JsonConvert.SerializeObject(md);
            Console.WriteLine(mdJson);
            using (StreamWriter sw = new StreamWriter("employee.json"))
                sw.WriteLine(mdJson);
        }
    }
}
