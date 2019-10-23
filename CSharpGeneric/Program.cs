using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGeneric
{

    /// <summary>
    /// 1. C# 2.0 新增的功能
    /// 2. 引進型別參數的概念
    /// 3. 編寫程式的時候可以先不用決定好型別，可以等到執行階段時決定
    /// 4. 優點: (1)減少重複的程式碼, (2)增加效能, (3)型別安全
    /// 
    /// reference: https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/generics/
    ///            https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters#why-use-constraints
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Customer()
            {
                Name = "Big Winner",
                Balance = 99999999
            };

            var b = new Customer()
            {
                Name = "Loser",
                Balance = -10000
            };

            //var a = 1;
            //var b = 2;

            //Console.WriteLine($"a:{a}");
            //Console.WriteLine($"b:{b}");

            Console.WriteLine($"{a.Name}:{a.Balance}");
            Console.WriteLine($"{b.Name}:{b.Balance}");

            Console.WriteLine();
            Console.ReadLine();
        }

        private static T Merge<T>(T a, T b) where T : IUser, new()
        {
            return new T()
            {
                Name = a.Name + b.Name,
                Balance = a.Balance + b.Balance
            };
        }

        private static void Swap(ref object a, ref object b)
        {
            var temp = b;
            b = a;
            a = temp;
        }

        private static void Swap<T>(T a, T b) where T : IUser
        {
            var temp = b.Balance;
            b.Balance = a.Balance;
            a.Balance = temp;
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            var temp = b;
            b = a;
            a = temp;
        }

        private static void Swap(ref double b, ref double a)
        {
            var temp = b;
            b = a;
            a = temp;
        }

        private static void Swap(ref string b, ref string a)
        {
            var temp = b;
            b = a;
            a = temp;
        }

        private static void Swap(ref int b, ref int a)
        {
            var temp = b;
            b = a;
            a = temp;
        }
    }

    internal class Customer : IUser
    {
        public string Name { get; set; }
        public int Balance { get; set; }
    }

    internal interface IUser
    {
        string Name { get; set; }
        int Balance { get; set; }
    }

    internal class Player : IUser
    {
        public string Name { get; set; }
        public int Balance { get; set; }
    }
}
