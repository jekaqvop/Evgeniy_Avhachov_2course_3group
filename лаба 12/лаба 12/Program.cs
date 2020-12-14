using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace лаба_12
{
    class Car
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Reflector.GetAssemblyName("System.Int32");
            Reflector.GetPublicConstructor("System.Int32");
            Reflector.GetPublicMethods("System.Int32");
            Reflector.GetFieldsAndProperties("System.Int32");
            Reflector.GetMethodsByParameters("System.String", "System.Int32");
            Reflector.GetRealisedInterfaces("System.Int32");

            Reflector.MyInvoke(typeof(List<string>).FullName, "Add");
            Reflector.MyInvoke2(typeof(List<string>).FullName, "Add");
            object arr = Reflector.CreateObj<ArrayList>("array");
            

            Console.ReadKey();         
        }
    }
}
