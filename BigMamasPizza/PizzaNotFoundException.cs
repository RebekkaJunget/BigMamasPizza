using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamasPizza
{
    public class PizzaNotFoundException : Exception
    {
        public PizzaNotFoundException() : base("Pizza not found")
        {
        }

        public PizzaNotFoundException(string message) : base(message)
        {

        }


    }

    
}
