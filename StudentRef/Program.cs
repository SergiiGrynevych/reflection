using System;
using System.Reflection;

namespace StudentRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom(@"D:\FOZZY_GROUP\myPractice\reflectionFirst\reflectionFirst\bin\Debug\reflectionFirst.dll");

            Type t = asm.GetType("reflectionFirst.Student", true, true);

            object obj = Activator.CreateInstance(t, new object[2] {"Leon", 17});

            MethodInfo method = t.GetMethod("ShowResult");

            object result = method.Invoke(obj, new object[] { });

            Console.WriteLine(result);

            object objSecond = Activator.CreateInstance(t, new object[2] { "Kivi", 22 });

            object resultSecond = method.Invoke(objSecond, new object[] { });
            
            Console.WriteLine(resultSecond);

            Console.ReadKey();
        }
    }
}
