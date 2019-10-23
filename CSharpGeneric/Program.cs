using System;

namespace CSharpGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //var drinkFactory = new DrinkFactory();

            var customer = new Customer();

            //customer.BuyDrink(drinkFactory.ProvideDrink<Tea>());
            //customer.BuyDrink(drinkFactory.ProvideDrink<Coffee>());
            //customer.BuyDrink(drinkFactory.ProvideDrink<Cola>());

            Console.ReadLine();
        }
    }

    internal class Customer
    {
        //public void BuyDrink(IDrink drink)
        //{
        //    Console.WriteLine($"Customer spent {drink.GetPrice()} on a cup of {drink.GetName()}");
        //}
    }

    internal class Cola
    {
        public string GetName()
        {
            return "Cola";
        }

        public int GetPrice()
        {
            return 25;
        }
    }

    internal class Tea
    {
        public string GetName()
        {
            return "Tea";
        }

        public int GetPrice()
        {
            return 20;
        }
    }

    internal class Coffee
    {
        public string GetName()
        {
            return "Coffee";
        }

        public int GetPrice()
        {
            return 45;
        }
    }
}
