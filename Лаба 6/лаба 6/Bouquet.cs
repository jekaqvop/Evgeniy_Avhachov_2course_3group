using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_6
{
    sealed class Bouquet : ICloneable
    {
        List<Flower> flowers;
        public Bouquet()
        {
            flowers = new List<Flower>();
        }
        public Bouquet(params Flower[] flowers)
        {
            this.flowers = new List<Flower>();
            for (int i = 0; i < flowers.Length; i++)
                this.flowers.Add(flowers[i]);
        }
        public List<Flower> Flowers
        {
            get { return this.flowers; }
            set { this.flowers = value; }
        }
        public void Print()
        {
            for (int j = 0; j < flowers.Count; j++)
            {
                Console.WriteLine(flowers[j]);
            }
        }
       
        

        public int FullPrice()
        {
            int tempPrice = 0;
            for (int i = 0; i < flowers.Count; i++)
                tempPrice += flowers[i].Price;

            return tempPrice;
        }

        public object Clone()
        {
            Bouquet flows = new Bouquet();
            flows.flowers = this.flowers;
            return flows;
        }
    }
}
