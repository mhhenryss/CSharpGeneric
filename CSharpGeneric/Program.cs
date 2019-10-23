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
            var a = 1;
            var b = 2;

            Console.WriteLine($"a:{a}");
            Console.WriteLine($"b:{b}");

            Console.ReadLine();
        }

        private static void Swap(ref int b, ref int a)
        {
            var temp = b;
            b = a;
            a = temp;
        }
    }
}
