using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_7
{   
    class Rose : Flower
    {
        public string pole;
        public override string ToString()
        {
            return GetInfo();
        }
        public override int GetHashCode() //возвращает высоту розы
        {            
            return Hidth;
        }
        public override bool Equals(object obj)
        {
            return true;
        }

        public override string GetInfo()
        {
            string str;

            str = $"вид: {Vid}\nвысота: {Hidth}\nЦвет: {Color}\nвозраст: {Age}\n";

            return str;
        }

        public override void zapah()
        {
            Console.WriteLine("я не пахну");
        }
    }
}
