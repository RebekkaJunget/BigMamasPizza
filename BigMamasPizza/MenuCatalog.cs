using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamasPizza
{
    public class MenuCatalog
    {

        private List<Pizza> _pizzaMenu = new List<Pizza>();


      
        public List<Pizza> PizzaMenu
        {
            get { return _pizzaMenu; }
        }

        // Methods for CRUD operations

        //Create
        public void AddPizza(int pizzaId, string pizzaName, int price)
        {
            Pizza p = new Pizza(pizzaId, pizzaName, price);
            _pizzaMenu.Add(p);

        
        }


        //Read
        public void ReadInput()
        {
            int x;
            Console.WriteLine("Enter the pizza number");
            x = Console.Read();
            Console.WriteLine(x);

            Console.WriteLine(Convert.ToString(x));

        }

        //Delete
        public void DeletePizza(string _pizzaName)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= PizzaMenu.Count - 1)
            {
                if (PizzaMenu[index].PizzaName.Equals(_pizzaName))
                {
                    found = true;
                    PizzaMenu.RemoveAt(index);
                }
                index++;
            }

        }


        
        //Update
        public void UpdatePizza(string _pizzaName, int _price)

        {
            bool found = false;
            int index = 0;
            while (found == false && index <= PizzaMenu.Count -1 ) 
            { 
                if (PizzaMenu[index].PizzaName.Equals(_pizzaName))
                    
                { 
                    found = true;
                    PizzaMenu[index].Price = _price;
                   
                }
                index++;
            }
            if (found == false) throw new PizzaNotFoundException();
           
        }

        //Print
        public void PrintMenu()

        {
            Console.WriteLine("Menu");
            foreach (var pizza in PizzaMenu)
            {
                Console.WriteLine(pizza);
            }



        }


        //Search
        public Pizza SearchPizza(string _searchWord) 
        {
            bool found = false;
            int index = 0;
            Pizza foundPizza = null;
            while (found == false && index <= PizzaMenu.Count -1)
            {
                if (PizzaMenu[index].PizzaName.Equals (_searchWord))
                {
                    found = true;
                    foundPizza = PizzaMenu[index];
                }
                index++;
            }
            if (found == false) throw new PizzaNotFoundException();
            return foundPizza;
         
        }

       
    }
}
