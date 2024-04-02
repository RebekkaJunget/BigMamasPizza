using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamasPizza
{
    public class MenuCatalog
    {
        #region Instans Fields
         private List<Pizza> _menu;


      public MenuCatalog() 
        {
            _menu = new List<Pizza>(); 
        }
        #endregion



        public void AddPizza(Pizza pizza)
        {

            _menu.Add (pizza);
          
        }

        public void DeletePizza(string _pizzaName)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= _menu.Count -1 ) 
            {
                if (_menu[index].PizzaName.Equals(_pizzaName))
                {
                    found = true;
                    _menu.RemoveAt (index);
                }
                index++;
            }
            
        }

        public void UpdatePizza(string _pizzaName, int _price)

        {
            bool found = false;
            int index = 0;
            while (found == false && index <= _menu.Count -1 ) 
            { 
                if (_menu[index].PizzaName.Equals(_pizzaName))
                    
                { 
                    found = true;
                    _menu[index].Price = _price;
                   
                }
                index++;
            }
        }

    
        public Pizza SearchPizza(string _searchWord) 
        {
            bool found = false;
            int index = 0;
            Pizza foundPizza = null;
            while (found == false && index <= _menu.Count -1)
            {
                if (_menu[index].PizzaName.Equals (_searchWord))
                {
                    found = true;
                    foundPizza = _menu[index];
                }
                index++;
            }
            if (found == false) throw new PizzaNotFoundException();
            return foundPizza;
         
        }
        

        public void PrintMenu()

        {
            Console.WriteLine("Menu");
            foreach (var pizza in _menu)
            {
                Console.WriteLine(pizza);
            }



        }

       

    }
}
