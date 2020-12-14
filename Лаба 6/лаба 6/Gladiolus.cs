using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_6
{   

    class Gladiolus : Flower, interface1
    {

        public Color Color2 { get { return Color; } set { Color = value; } }
        public override void rost()
        {
            Console.WriteLine("если не скачать версию C# 8.0, то интерфейсы такое себе удовольствие");
        }
        void interface1.rost()
        {
            Console.WriteLine("метод интерфейса");
        } 
        public override string GetInfo()
        {
            string str;

            str = $"вид: {Vid}\nвысота: {Hidth}\nЦвет: {Color}\nвозраст: {Age}\n";

            return str;
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
