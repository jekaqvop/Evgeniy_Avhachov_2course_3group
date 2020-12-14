using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_6
{
    class Controller :Flower, IComparable
    {
        public static Bouquet SortColor(Bouquet bouquet)
        {
            int cont = 0;
            Flower flow = bouquet.Flowers[cont];
            for(int i = 0; i<bouquet.Flowers.Count; i++)
            {
                if(bouquet.Flowers[i].Color == Color.red)
                {
                    flow = bouquet.Flowers[cont];
                    bouquet.Flowers[cont] = bouquet.Flowers[i];
                    bouquet.Flowers[i] = flow;
                    cont++;
                }
            }
            
            return bouquet;
        }
        public static Bouquet GetColor(Bouquet bouquet, Color color)
        {
            Bouquet bouquet1 = new Bouquet();
            int count = 0;
            for (int i = 0; i < bouquet.Flowers.Count; i++)
            {
                if (bouquet.Flowers[i].Color == color)
                {
                    bouquet1.Flowers.Add(bouquet.Flowers[i]);
                    count++;
                }
            }
            return bouquet1;
        }
        
        public int CompareTo(object obj)
        {
            int a = Convert.ToInt32(obj is Bouquet);
            if (obj != null)
                return a;
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

        public static Bouquet Clone(Bouquet obj)
        {                  
            return (Bouquet)obj.Clone();
        }
    }
}
