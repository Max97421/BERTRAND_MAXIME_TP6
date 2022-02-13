

namespace BuildAPizza
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pizza myPizza = new PizzaBuilder()
                .setDough(Dough.White)
                .setCheese(Cheese.White)
                .addTopping(Topping.Kittens)
                .addTopping(Topping.Salami)
                .buildPizza();
        }
    }
}