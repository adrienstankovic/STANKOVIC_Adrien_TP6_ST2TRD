using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace STANKOVIC_Adrien_TP6_ST2TRD
{
    public interface PBuilder
    {
        void addMushroom();

        void addVegetables();

        void addCheese();
    }
    public class PizzaBuilder : PBuilder
    {
        private Pizza pizza = new Pizza();
        
        public void addMushroom()
        {
            this.pizza.add("Mushrooms");
        }

        public void addVegetables()
        {
            this.pizza.add("Vegetables");
        }

        public void addCheese()
        {
            this.pizza.add("Cheese");
        }

        public void newPizza()
        {
            this.pizza = new Pizza();
        }
        
        public Pizza GetPizza()
        {
            Pizza result = this.pizza;
            
            return result;
        }
    }
    public class Pizza
    {
        private List<string> ingredients = new List<string>();
        public void add(string product)
        {
            this.ingredients.Add(product);
        }

        public override string ToString()
        {
            string str = "The pizza contains: \n";
            
            for (int i = 0; i < this.ingredients.Count; i++)
            {
                str += "+" + this.ingredients[i] + "\n";
            }
            
            return  str;
        }
        
        
    }

    public interface IBuilder
    {
        void addMushroom();

        void addVegetables();
    }
}