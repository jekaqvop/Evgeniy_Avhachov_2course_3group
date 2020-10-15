using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower fl = new Flower();
            fl.Age = new DateTime(10, 10, 10);
            fl.Color = "white";
            fl.Hidth = 10;
            fl.Vid = "fialka";
            Console.WriteLine(fl.ToString());

            Gladiolus glad = new Gladiolus();
            glad.Age = new DateTime(11, 11, 11);
            glad.Color = "white";
            glad.Hidth = 11;
            glad.Vid = "Gladiolus One";
            Console.WriteLine(glad.ToString());

            Gladiolus glad2 = new Gladiolus();
            glad.Age = new DateTime(11, 11, 11);
            glad.Color = "white";
            glad.Hidth = 11;
            glad.Vid = "Gladiolus two";
            Console.WriteLine(glad.ToString());


            Paper paper = new Paper("list");
            paper.Age = new DateTime(10, 10, 10);
            paper.Color = "white";
            paper.Hidth = 10;
            paper.Vid = "дуб";
            Console.WriteLine(paper.ToString());

            Cactus cactus = new Cactus(10, true, new DateTime(10, 10, 10));
            cactus.Age = new DateTime(10, 10, 10);            
            cactus.Hidth = 10;
            cactus.Vid = "неизвестный кактус";
            Console.WriteLine(cactus.ToString());            

            Bush bush = new Bush();
            bush.Age = new DateTime(10, 10, 10);           
            bush.Hidth = 10;
            bush.Vid = "куст";
            Console.WriteLine(fl.ToString());

            Rose roza = new Rose();
            roza.Age = new DateTime(10, 10, 10);
            roza.Color = "white";
            roza.Hidth = 10;
            roza.Vid = "какая-то роза";
            Console.WriteLine(roza.ToString());

            Plant rozaPlant = new Rose();
            
            //rozaplant.pole = "какое-то поле";
            rozaPlant.Age = new DateTime(10, 10, 10);
            //rozaPlant.Color = "white";
            rozaPlant.Hidth = 10;
            rozaPlant.Vid = "Роза из Plant";
            Console.WriteLine(fl.ToString());


            Console.WriteLine("проверка на принадлежность rozaPlant is Rose:" + (rozaPlant is Rose));
            Console.WriteLine("проверка на принадлежность rozaPlant is Plant:" + (rozaPlant is Plant));
            Console.WriteLine("проверка на принадлежность rozaPlant is Flower:" + (rozaPlant is Flower));
            Console.WriteLine("проверка на принадлежность roza is Rose:" + (roza is Plant));
            Console.WriteLine("проверка на принадлежность roza is Rose:" + (roza is Paper));

            interface1[] arr = { glad, glad2 };
            Printer print = new Printer();
            for (int i = 0; i < arr.Length; i++)
            {
                print.iAmPrinting(arr[i]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
