using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class НаземныйТранстпорт : Машины, IPrice
    {
        protected int maxSpeed;
        public НаземныйТранстпорт(string pName, int pPrice, int pMaxSpeed) : base(pName, pPrice)
        {
            maxSpeed = pMaxSpeed;
        }

        override public string GetName()
        {
            return name + "Максимальная скорость машины: " + maxSpeed.ToString();
        }

        public void GetPrice()
        {
            Console.WriteLine("Цена: "+price);
        }
    }
}
