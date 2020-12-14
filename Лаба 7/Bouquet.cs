using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Лаба_7;

namespace лаба_7
{
    sealed class Bouquet : ICloneable
    {
        
        int maxCount;
        public int MaxCount
        {
            get { return maxCount; }
            set { maxCount = value; }
        }
        public float byuerBudget;
        List<Flower> flowers;
        public Bouquet()
        {
            flowers = new List<Flower>();
        }
        public Bouquet(float byuerBudget, int maxCount, params Flower[] flowers)
        {
            if (byuerBudget <= 0)
            {
                throw new InvalidInputException("Недопустимый бюджет покупателя");
            }

            if (maxCount <= 0)
            {
                throw new InvalidInputException("Максимальное количество цветов в букете должно быть положительным числом");
            }

            this.byuerBudget = byuerBudget;
            this.maxCount = maxCount;
            this.flowers = new List<Flower>();
            for (int i = 0; i < flowers.Length; i++)
                this.flowers.Add(flowers[i]);
        }
        public Bouquet(params Flower[] flowers)
        {
            this.flowers = new List<Flower>();
            for (int i = 0; i < flowers.Length; i++)
                this.flowers.Add(flowers[i]);
        }

        public void Add(Flower flower)
        {
            int maxCount = 10;
            if (flowers.Count < maxCount)
                flowers.Add(flower);
            else
                throw new BouquetOverflowException(flowers.Count, maxCount);
        }
        public List<Flower> Flowers
        {
            get { return this.flowers; }
            set { this.flowers = value; }
        }
        
        public void Print()
        {
            if (flowers.Count != 0)
                for (int j = 0; j < flowers.Count; j++)
                    Console.WriteLine(flowers[j]);
            else
                throw new ZeroFlowersException();            
        }

        public List<Flower> ByBouquet()
        {
            if (byuerBudget >= FullPrice())
                return flowers;
            else
                throw new ExpensiveException(byuerBudget, FullPrice());
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
