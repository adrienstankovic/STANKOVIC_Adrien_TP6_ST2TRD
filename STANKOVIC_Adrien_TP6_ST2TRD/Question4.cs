using System;

namespace STANKOVIC_Adrien_TP6_ST2TRD
{
    abstract class Computer
    {
        public void getComputer()
        {
            this.getKeyboard();
            this.getElectronicParts();
            this.getScreen(); //2 types of screen
        }

        protected void getKeyboard()
        {
            Console.WriteLine("Keyboard is on computer");
        }

        protected void getElectronicParts()
        {
            Console.WriteLine("Electronic Parts is in computer");
        }

        protected abstract void getScreen();
    }
    
    class Computer_touch_screen : Computer
    {
        protected override void getScreen()
        {
            Console.WriteLine("Computer gets a touch screen");
        }
    }

    class Computer_normal_screen : Computer
    {
        protected override void getScreen()
        {
            Console.WriteLine("Computer gets a normal screen");
        }
    }

    class Client
    {
        public static void ClientComputer(Computer computer)
        {
            computer.getComputer();
        }
    }
}