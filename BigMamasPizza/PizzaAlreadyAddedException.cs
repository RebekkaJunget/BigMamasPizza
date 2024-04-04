using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamasPizza
{
    public class PizzaAlreadyAddedException : Exception

    {
        public PizzaAlreadyAddedException() : base("Pizza already added to menu") { }


        public PizzaAlreadyAddedException(string message) : base(message) { }
    }
}
 

