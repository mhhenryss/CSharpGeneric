using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void TestArrayList(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        //private static void TestList(List<int> list)
        //{
        //    foreach (var i in list)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    Console.ReadLine();
        //}

    }
}
