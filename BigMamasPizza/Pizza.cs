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
       
        private int _price;
        
        #endregion

        #region Constructor
        public Pizza(int pizzaId, string pizzaName, int price)
        {
            _pizzaId = pizzaId;
            _pizzaName = pizzaName;
           
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
       

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }



        #endregion

        private Dictionary<int, Pizza> pizzas { get; }
        public Pizza()
        {
            pizzas = new Dictionary<int, Pizza>();

            new Pizza(1, "Cheese_pizza", 98);
            new Pizza(2, "Bufalla_pizza", 59);
            new Pizza(3, "Chicken_pizza", 120);
            new Pizza(4, "Mozzarella_pizza", 77);
            new Pizza(5, "Vegetable_pizza", 88);
        }

        public Dictionary<int, Pizza> AllPizzas()
        {
            return pizzas;
        }

        #region Method

        public override string ToString()
        {
            return $"{_pizzaId} - {_pizzaName} - $Price: {_price}";
        }
  
        #endregion

    }

}

