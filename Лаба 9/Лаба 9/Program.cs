using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_9
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Director Dr_1 = new Director();
            
            Tokar tokar1 = new Tokar("tokar1");
            Tokar tokar2 = new Tokar("tokar2");
            Tokar tokar3 = new Tokar("tokar3");
            Tokar tokar4 = new Tokar("tokar4");

            Student student1 = new Student("student1");
            Student student2 = new Student("student2");
            Student student3 = new Student("student3");
            Student student4 = new Student("student4");


            Dr_1.Raising += tokar1.AddZp;
            Dr_1.Raising += tokar2.AddZp;
            Dr_1.Raising += tokar3.AddZp;
         
            Dr_1.Penalizing += tokar1.Minus;
            Dr_1.Penalizing += tokar2.Minus;
            Dr_1.Penalizing += tokar3.Minus;
            Dr_1.Penalizing += tokar4.Minus;

            Dr_1.Raising += student1.AddZp;
            Dr_1.Raising += student2.AddZp;
            Dr_1.Raising += student3.AddZp;

            Dr_1.Add(110);
            Dr_1.Minus();

            string str = $"tokar1: {tokar1.Zp}\ntokar2: {tokar2.Zp}\ntokar3: {tokar3.Zp}\ntokar4: {tokar4.Zp}";
            string str1 = $"student1: {student1.Zp}\nstudent2: {student2.Zp}\nstudent3: {student3.Zp}\nstudent4: {student4.Zp}";

            Console.WriteLine(str + "\n" + str1);

            string testString = "Делегат, Func возвращает результат,    действия и может принимать, параметры!";
            Func<string, string> func;
            func = ChangeString.DeletePunctSigns; //удаление знаков препинания
            func += ChangeString.ToUpperCase;   //перевод строки в верхний регистр
            func += ChangeString.DeleteUnnecessarySpace;    //уделение лишних пробелов


            string result = func(testString);
            Console.WriteLine("\n\n" + result);
            
            Console.ReadKey();
        }
        
    }
}
