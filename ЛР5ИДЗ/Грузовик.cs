using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Грузовик : НаземныйТранстпорт, IPrice
    {
        protected float loadCapacity;

        public Грузовик(string pName, int pPrice, int pMaxSpeed, float pLoadCapacity) : base(pName, pPrice, pMaxSpeed)
        {
            this.loadCapacity = pLoadCapacity;
        }
        override public string GetName()
        {
            return name + " Максимальная скорость грузовика: " + maxSpeed.ToString();
        }
        new public void GetPrice()
        {
            Console.WriteLine("Цена грузовика: " + price);
        }
    }
}
