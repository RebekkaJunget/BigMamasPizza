using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BigMamasPizza
{
   public class Pizza
    {
        #region Instens Fields
        private int _pizzaId;
        private string _pizzaName;
        private List<string> _toppings;
        private int _price;
        
        #endregion

        #region Constructor
        public Pizza(int pizzaId, string pizzaName,List<string> toppings, int price)
        {
            _pizzaId = pizzaId;
            _pizzaName = pizzaName;
            _toppings = toppings;
            _price = price;
           
        }
        #endregion

        #region Properties

        public int PizzaId
        {
            get { return _pizzaId; }
            set { _pizzaId = value; }
        }
        public string PizzaName 
        {
            get { return _pizzaName; }
            set { _pizzaName = value; }

        }
        public List<string> Toppings
        {
            get { return _toppings; }
            set { _toppings = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
     
     
       
        #endregion
       
        #region Method
            
        public override string ToString()
        {
            return $"{_pizzaId} - {_pizzaName} - Topping: {string.Join(",", Toppings)}, $Price: {_price}";
        }
  
        #endregion

    }

}

