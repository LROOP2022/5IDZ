using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public class Машины
    {
        protected string name;
        protected int price;

        public Машины(string pName,int pPrice)
        {
            name = pName;
            price = pPrice;
        }
        virtual public string GetName()
        {
            return name;
        }
    }
}
