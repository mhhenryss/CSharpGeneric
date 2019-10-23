namespace CSharpGeneric.Model
{
    internal class DrinkFactory
    {
        public IDrink ProvideDrink<T>() where T : IDrink, new()
        {
            return new T();
        }
    }
}