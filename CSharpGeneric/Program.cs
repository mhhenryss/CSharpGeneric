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
            TestArrayList();
        }

        private static void TestArrayList()
        {
            var arrayList = new ArrayList();

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        //private static void TestList()
        //{
        //    var ints = new List<int>();

        //    foreach (var i in ints)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    Console.ReadLine();
        //}

    }
}
