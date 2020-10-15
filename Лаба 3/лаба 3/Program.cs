using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace лаба_3
{
    class Customer
    {
        static int kol = 0;
        public readonly byte[] id;

        string name;
        string surname;
        string midName;     
        string address;
        int? numCurd;
        int? balans;
        const byte poleConst = 1;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string MidName
        {
            get
            {
                return midName;
            }
            set
            {
                midName = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Address
        {
            private get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public int NumCurd
        {
            get
            {
                return Convert.ToInt32(numCurd);
            }
            set
            {
                numCurd = value;
            }
        }
        public Customer()
        {
            id = null;
            name = "none";
            surname = "nane";
            midName = "none";
            address= "none";
            numCurd = null;
            balans= 0;
            Customer.kol++;
        }
        public Customer(int id1, string name1, string surname1, string midName1, string address1, int numCurd1, int balans1)
        {
            id = Hashfunck(id1);
            name = name1;
            surname = surname1;
            midName = midName1;
            address = address1;
            numCurd = numCurd1;
            balans = balans1;
            Customer.kol++;
        }
        public Customer(int id1 = 0, string name1 = "none", string surname1 = "none", string midName1 = "none", string address1 = "none", int? numCurd1 = null, int? balans1 = null)
        {
            id = Hashfunck(id1);
            name = name1;
            surname = surname1;
            midName = midName1;
            address = address1;
            numCurd = numCurd1;
            balans = balans1;
            Customer.kol++;
        }
        static Customer()
        {
            Console.WriteLine("Static Customer");
        }
        public Customer(int id, string name) : this (1)
        {

        }
        private Customer(int id)
        {

        }
        private byte[] Hashfunck(int id)
        {
            string sSourceData = id.ToString();
            byte[] tmpSource;
            byte[] tmpHash;

            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);

            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            return tmpHash;
        }
       public void GetInfom()
        {
            Console.Write("hash Id: ");
            for (byte i = 0; i<15; i++)
             Console.Write(id[i]+" ");

             Console.WriteLine("\nname: " + name);
             Console.WriteLine("surname: " + surname);
             Console.WriteLine("midmame: " +midName);
             Console.WriteLine("address: " + address);
             Console.WriteLine("numCurd: " + numCurd);
             Console.WriteLine("balans: " + balans); 

        }
        static void GetInfo()
        {
            Console.WriteLine("Поля: ");
            Console.WriteLine("\thash Id");
            Console.WriteLine("name");
            Console.WriteLine("surname");
            Console.WriteLine("midmame");
            Console.WriteLine("address");
            Console.WriteLine("numCurd");
            Console.WriteLine("balans");
            Console.WriteLine("Количество объектов: " + Customer.kol);
            Console.WriteLine();
        }
        public void TopUpBalans(ref int refArgument)
        {
            this.balans = refArgument;
        }
        public void TopUpBalans2(out int outArgument)
        {
            outArgument = 0;
            this.balans = outArgument;
        }
        
        
    }
    partial class Partial
    {
        public double Real { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Partial partial &&
                   Real == partial.Real;
        }

        public override int GetHashCode()
        {
            return 1380053253 + Real.GetHashCode();
        }
    }
    partial class Partia
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {  
            Random rnd = new Random();
            Customer cuto = new Customer(1);
            var cust = new Customer();
            Customer[] Cust = new Customer[4];          
              


            Cust[0] = new Customer(1, "c", "bsurname ", "gmidName ", "baddress ", rnd.Next(0, 1000), rnd.Next(0, 1000));
            rnd = new Random(3);

            Cust[1] = new Customer(2, "a", "agsurname ", "abmidName", "aaddress ", rnd.Next(0, 1000), rnd.Next(0, 1000));
            rnd = new Random(2);
            Cust[2] = new Customer(3, "d", "dsurname ", "bmidName ", "daddress ", rnd.Next(0, 1000), rnd.Next(0, 1000));
            Cust[3] = new Customer(3, "b", "dsurname ", "bmidName ", "daddress ", rnd.Next(0, 1000), rnd.Next(0, 1000));

            var result = from user in Cust
                         orderby user.Name
                         select user;
            foreach (Customer u in result)
                Console.WriteLine($"{u.Name} {u.NumCurd}");
            int a = 100, b = 400;
            fun(a, b);
            void fun(int a1, int b2)
            {
                for(byte i = 0; i < Cust.Length; i++)
                {
                    if (Cust[i].NumCurd >= a1 && Cust[i].NumCurd <= b2)
                        Cust[i].GetInfom();
                }
            }

            Console.ReadKey();

        }

    }
}
