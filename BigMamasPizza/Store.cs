using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BigMamasPizza
{
    public class Store
    {
        private MenuCatalog catalog;

        public Store()
        {
            catalog = new MenuCatalog();
        }

        public void TestMethods()
        {
            //Test CRUD 

            var pizza1 = new Pizza(1, "Margherita", new List<string> { "tomato", "Cheese", "basil" }, 80);
            var pizza2 = new Pizza(2, "Pepperoni", new List<string> { "Pepperoni", "tomato, Cheese & Pepperoni" }, 84);
            var pizza3 = new Pizza(3, "Vegetarian", new List<string> { "tomato", "salat", "onien" }, 70);

            catalog.AddPizza(pizza1);
            catalog.AddPizza(pizza2);
            catalog.AddPizza(pizza3);

            catalog.PrintMenu();

            catalog.DeletePizza("Pepperoni");

            Console.WriteLine("After Deletion:");
            catalog.PrintMenu();

            catalog.UpdatePizza("Vegetarian", 90);

            Console.WriteLine("After update");
            catalog.PrintMenu();
            // Test Seaech
            try
            {
                Pizza p = catalog.SearchPizza("Margherita");
                Console.WriteLine("Seach pizza");
                Console.WriteLine(p.ToString());
               

            }
            catch (PizzaNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            
       
            


            

        }


    } 
}
