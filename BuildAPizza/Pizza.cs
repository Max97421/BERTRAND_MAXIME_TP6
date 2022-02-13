using System.Collections.Generic;

namespace BuildAPizza
{
    
        enum Dough{
            White, Brown
        }
        
        enum Cheese{
            White, Brown
        }
        
        enum Topping{
            Kittens, Onions, Salami
        }
        
        class Pizza{

            private Dough dough;
            private Cheese cheese;
            private HashSet<Topping> toppings;

            public Pizza(Dough dough, Cheese cheese, HashSet<Topping> toppings){
                this.dough = dough;
                this.cheese = cheese;
                this.toppings = toppings;
            }

            //add some getters

        }
        
        class PizzaBuilder{

            private Dough dough;
            private Cheese cheese;
            private HashSet<Topping> toppings = new HashSet<Topping>();

            public PizzaBuilder(){

            }
            public PizzaBuilder setDough(Dough dough){
                this.dough = dough;
                return this;
            }
            public PizzaBuilder setCheese(Cheese cheese){
                this.cheese = cheese;
                return this;
            }
            public PizzaBuilder addTopping(Topping topping){
                this.toppings.Add(topping);
                return this;
            }
            public Pizza buildPizza(){
                return new Pizza(this.dough, this.cheese, this.toppings);
            }

        }
        
    }
