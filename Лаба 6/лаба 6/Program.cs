﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Flower fl = new Flower();
            fl.Age = new DateTime(10, 10, 10);
            fl.Color = Color.blue;
            fl.Hidth = 10;
            fl.Vid = "fialka";
            Console.WriteLine(fl.ToString());

            Gladiolus glad = new Gladiolus();
            glad.Age = new DateTime(11, 11, 11);
            glad.Color = Color.green;
            glad.Hidth = 11;
            glad.Vid = "Gladiolus One";
            glad.Price = 10;
            glad.zapah();
            Console.WriteLine(glad.ToString());

            Gladiolus glad2 = new Gladiolus();
            glad2.Age = new DateTime(11, 11, 11);
            glad2.Color = Color.orange;
            glad2.Hidth = 11;
            glad2.Vid = "Gladiolus two";
            glad2.Price = 10;
            Console.WriteLine(glad.ToString());

            Color[] vidColor = { Color.blue, Color.green, Color.orange, Color.white, Color.yellow, Color.red, Color.pink };
            Paper paper = new Paper(Vid.birch);
            paper.Age = new DateTime(10, 10, 10);
            paper.Color = Color.pink;
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
            roza.Color = Color.red;
            roza.Hidth = 10;
            roza.Price = 10;
            roza.Vid = "какая-то роза";


            Rose roza2 = new Rose();
            roza2.Age = new DateTime(10, 10, 10);
            roza2.Color = Color.pink;
            roza2.Hidth = 10;
            roza2.Vid = "какая-то роза 2";
            roza2.Price = 10;
            roza2.zapah();
            Console.WriteLine(roza2.ToString());

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
            Console.WriteLine("проверка на принадлежность roza is Rose:" + (glad is Plant));
            Console.WriteLine("проверка на принадлежность roza is Rose:" + (glad is interface1));

            interface1[] arr = { glad, glad2 };
            Printer print = new Printer();
            for (int i = 0; i < arr.Length; i++)
            {
                print.iAmPrinting(arr[i]);
                Console.WriteLine();
            }
            glad.rost();
            ((interface1)glad).rost();


            Bouquet bouquet = new Bouquet(roza, roza2, glad);
            bouquet.Flowers.Add(glad2);

            Console.WriteLine($"Стоимость букета: {bouquet.FullPrice()}");
            bouquet.Print();
            
            
           
            Console.WriteLine("Отсортированные цветы: ");
            Controller.SortColor(bouquet);
            Console.WriteLine();
            bouquet.Print();

            Bouquet bouquet1 = Controller.GetColor(bouquet, Color.red);
            Console.WriteLine("Красные цветы: ");
            bouquet1.Print();
            Controller dkgm = new Controller();

            Console.WriteLine(dkgm.CompareTo(fl));

            Bouquet bouq = Controller.Clone(bouquet1);
            
            Console.ReadKey();


        }
    }
}
