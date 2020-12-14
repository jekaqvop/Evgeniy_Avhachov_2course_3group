using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Collections;

namespace лаба_12
{
    
        static class Reflector
    {
        public static Type GetTypeByString(string name)
        {
            return Type.GetType(name);
        }
        public static void WriteToFile(string path, string str)
        {
            StreamWriter writeToFile = new StreamWriter(path + ".txt", true);
            writeToFile.WriteLine(str);
            writeToFile.Close();
        }
        //получение имени сборки
        public static string GetAssemblyName(string t)
        {
            Type Type = GetTypeByString(t);
            string s = "Assembly_name: " + Type.Assembly.GetName().Name.ToString();
            WriteToFile(Type.Name.ToString(), s);
            return s;
        }
        //получение количества public конструкторов
        public static string GetPublicConstructor(string t)
        {
            Type Type = GetTypeByString(t);
            string str = "Number_Of_Public_Constructors: " + Type.GetConstructors().Count();
            WriteToFile(Type.Name.ToString(), str);
            return str;
        }
        //получение public методов
        public static IEnumerable<string> GetPublicMethods(string t)
        {
            Type Type = GetTypeByString(t);
            IEnumerable<string> publicMethods = Type.GetMethods().Select(method => method.Name);
            string str = "public_methods: ";
            foreach (string method in publicMethods)
            {
                str += method;
                str += " ";
            }
            WriteToFile(Type.Name.ToString(), str);
            return publicMethods;
        }
        //получение всех свойств и полей
        public static IEnumerable<string> GetFieldsAndProperties(string t)
        {
            Type Type = GetTypeByString(t);
            IEnumerable<string> fieldsAndProperties = Type.GetFields().Select(field => " " + field.Name)
                                        .Concat(Type.GetProperties().Select(prop => " " + prop.Name));
            string str = "Fields_And_Properties: ";

            foreach (string buf in fieldsAndProperties)
            {
                str += buf + " ";
            }
            WriteToFile(Type.Name.ToString(), str);
            return fieldsAndProperties;
        }
        //получение реализованных интерфейсовType
        public static IEnumerable<string> GetRealisedInterfaces(string t)
        {
            Type Type = GetTypeByString(t);
            IEnumerable<string> interfaces = Type.GetInterfaces().Select(realizedInterface => realizedInterface.Name);
            string str = "Interfases: ";
            foreach (string interf in interfaces)
            {
                str += interf + " ";
            }
            WriteToFile(Type.Name.ToString(), str);
            return interfaces;
        }
        //получение методов с параметром
        public static void GetMethodsByParameters(string t, string param)
        {
            Type Type = GetTypeByString(t) ;
            string p = GetTypeByString(param).Name.ToString();
            MethodInfo[] methodsOfClass = Type.GetMethods();
            string str = "Methods_With_Parameters: ";
            
            foreach (var x in Type.GetMethods())
            {
                foreach (var y in x.GetParameters())
                {
                    string s = y.ParameterType.Name.ToString();
                    if (s == p)
                        str += x + " ";
                }
            }
            Console.WriteLine();
            WriteToFile(Type.Name.ToString(), str);
        }

        public static void MyInvoke(string ClassName, string MethodName)
        {
            
            object result = null;
            Type type = GetTypeByString(ClassName);
         
            object obj = Activator.CreateInstance(type);
            StreamReader reader = new StreamReader("params.txt");
            List<string> param = new List<string>();
            while (!reader.EndOfStream)
            {
                param.Add(reader.ReadLine());
            }
            reader.Close();
            foreach (var x in type.GetMethods())
            {
                if (x.Name == MethodName)
                {
                    if(x.IsStatic)
                        result = x.Invoke(null, param.ToArray());
                    else
                    {                        
                        result = x.Invoke(obj, param.ToArray());
                    }
                    if (result == null)
                        result = "null";
                    WriteToFile("MyInvoke.txt", result.ToString());
                }
               
            }

            
        }
        public static void MyInvoke2(string ClassName, string MethodName)
        {

            object result = null;
            Type type = GetTypeByString(ClassName);

            object obj = Activator.CreateInstance(type);
            string[] stringsForRandom = { "Atlanta", "Boston", "Chicago", "Detroit",
                    "Fort Wayne", "Greensboro", "Honolulu", "Indianapolis",
                    "Jersey City", "Kansas City", "Los Angeles",
                    "Milwaukee", "New York", "Omaha", "Philadelphia",
                    "Raleigh", "San Francisco", "Tulsa", "Washington" };
            Random rnd = new Random();

            List<string> param = new List<string>();
            
            
            param.Add(stringsForRandom[rnd.Next(DateTime.Now.Minute) % stringsForRandom.Length]);
            
           
            foreach (var x in type.GetMethods())
            {
                if (x.Name == MethodName)
                {
                    if (x.IsStatic)
                        result = x.Invoke(null, param.ToArray());
                    else
                    {
                        result = x.Invoke(obj, param.ToArray());
                    }
                    if (result == null)
                        result = "null";
                    WriteToFile("MyInvoke.txt", result.ToString());
                }

            }


        }
        static public object CreateObj<T>(string nameOfType) where T : new()                                      //Создание объекта
        {
            T objectOfUnknownType = new T();
            return objectOfUnknownType;
        
        }
    }
}
