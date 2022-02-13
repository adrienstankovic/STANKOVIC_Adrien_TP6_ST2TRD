using System;

namespace STANKOVIC_Adrien_TP6_ST2TRD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            /*
             * Question 2: Builder pattern - pizza
             */
            Console.WriteLine("Question 2\n");
            
            PizzaBuilder builder = new PizzaBuilder();

            builder.addMushroom();
            builder.addVegetables();
            builder.addCheese();
            
            Console.WriteLine(builder.GetPizza().ToString());
            Console.WriteLine();
            
            /*
             * Question 3: Decorator pattern
             */
            Console.WriteLine("Question 3\n");
            
            PhoneHigh phoneHigh = new PhoneHigh();
            PhoneLow phoneLow = new PhoneLow();

            iPhone13 Apple_iPhone13 = new iPhone13(phoneHigh);
            wiko wikoPhone = new wiko(phoneLow);
            wiko newWiko = new wiko(Apple_iPhone13);

            Console.WriteLine(Apple_iPhone13);
            Console.WriteLine(wikoPhone);
            Console.WriteLine(newWiko);
            Console.WriteLine();
            
            /*
             * Question 4: 
             */
            Console.WriteLine("Question 4\n");
            
            Console.WriteLine("Normal Screen: ");
            Client.ClientComputer(new Computer_normal_screen());
            Console.WriteLine();
            Console.WriteLine("Touch screen");
            Client.ClientComputer(new Computer_touch_screen());
        }
    }
}