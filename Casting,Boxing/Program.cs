using Casting_Boxing.Models;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Casting_Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple1 = new(100,100,100,"Quba");
            Apple apple2 = new(200,200,200,"Ehmedi");

            Orange orange1 = new(300, 300, "duz portagal");
            Orange orange2 = new(400, 400, "sehv portagal");

            Pineapple pineapple1 = new(500, 500, 500, "Yaxsisindan");
            Pineapple pineapple2 = new(600, 600, 600, "Pisinden");




            Fruit[] Basket=new Fruit[] {apple1,apple2,orange1,orange2,pineapple1,pineapple2};

            foreach(var fruit in Basket)
            {
                Type type = fruit.GetType();
                FieldInfo[] fields=type.GetFields(  BindingFlags.Public | BindingFlags.Instance);
                Console.WriteLine($"type:{type.Name}");
                foreach (FieldInfo field in fields)
                {
                    
                    Console.WriteLine($"{field.Name}:{field.GetValue(fruit)}");
                }

                Console.WriteLine();
            }
        }
    }
}