using System;

namespace STANKOVIC_Adrien_TP6_ST2TRD
{
    public abstract class Phone
    {
        protected string model;
        protected double price;
        protected double size;
        protected int memory;
        
        public virtual string Model()
        {
            return model;
        }
        public virtual double Price()
        {
            return price;
        }
        public virtual double Size()
        {
            return size;
        }
        public virtual int Memory()
        {
            return memory;
        }
    }

    class PhoneHigh : Phone
    {
        public PhoneHigh()
        {
            model = "Phone High";
            price = 1000;
            size = 6.2;
            memory = 256;
        }
    }

    class PhoneLow : Phone
    {
        public PhoneLow()
        {
            model = "Phone Low";
            price = 200;
            size = 5.5;
            memory = 64;
        }
    }

    public abstract class Decorator : Phone
    {
        Phone phone = null;

        public Decorator(Phone new_phone)
        {
            phone = new_phone;
        }
        public override double Size()
        {
            return this.Size();
        }
        public override string Model()
        {
            return this.Model();
        }
        public override int Memory()
        {
            return this.Memory();
        }
        public override double Price()
        {
            return this.Price();
        }

        public override string ToString()
        {
            string str = "Phone: " + model + " price: " + price + " size: " + size + " memory: " + memory;
            return str;
        }
    }

    class iPhone13 : Decorator
    {
        public iPhone13(Phone phone_iphone13) : base(phone_iphone13)
        {
            this.model = "iPhone 13";
            this.price = 1200;
            this.size = 6.1;
            this.memory = 256;
        }
    }

    class wiko : Decorator
    {
        public wiko(Phone new_wiko) : base(new_wiko)
        {
            this.model = "Wiko";
            this.price = 250;
            this.size = 5.9;
            this.memory = 64;
        }
    }
}