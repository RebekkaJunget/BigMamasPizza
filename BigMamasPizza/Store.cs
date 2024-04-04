using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BigMamasPizza
{
    public class Store
    {

        private string _name;

        private MenuCatalog menuCatalog;

        public Store()
        {
            menuCatalog = new MenuCatalog();
        }

        public string Name { get => _name; set => _name = value; }

        public int TestMethods()


        {
            

            List<string> menu = new List<string>
                {
                     "1. Add new pizza to the menu",
                     "2. Delete pizza",
                     "3. Update pizza",
                     "4. Search pizza",
                     
                };

            {
                Console.WriteLine("Pizza Menu");
                Pizza pizza1 = new Pizza(1, "Margerita", 50);
                Pizza pizza2 = new Pizza(2, "Pepperoni", 55);
                Pizza pizza3 = new Pizza(3, "Vegetarian", 60);
                menuCatalog.AddPizza(1, "Margerita", 50);
                menuCatalog.AddPizza(2, "Pepperoni", 55);
                menuCatalog.AddPizza(3, "Vegetarian", 60);

                Console.WriteLine("1. Margerita - 50 kr.");
                Console.WriteLine("2. Pepperoni, 55 kr.");
                Console.WriteLine("3. Vegetarian, 60");

            }
               
                 
                    
                   
            {
                Console.WriteLine("Menu overveiw");
                foreach (string menuItem in menu)
                {
                    Console.WriteLine(menuItem);
                }
            }
            Console.WriteLine("Enter number according to the action you want to take");

            int selcetMenu = int.Parse(Console.ReadLine());

            switch (selcetMenu)
            {
                case 1:
                    Console.WriteLine(" You selected:     " + menu[1 - 1]);
                    Console.Clear();

                    Console.WriteLine("Enter new pizza id");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter new pizza name");
                    string pizzaName = Console.ReadLine();
                    Console.WriteLine("Enter price of pizza");
                    int price = int.Parse(Console.ReadLine());
                    
                    try
                    {
                        menuCatalog.AddPizza(id, pizzaName, price);
                    }
                    catch (PizzaAlreadyAddedException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    menuCatalog.PrintMenu();
                    break;


                case 2:

                    Console.WriteLine(" You selected:     " + menu[2 - 1]);
                    Console.Clear();
                    menuCatalog.ReadInput();

                    menuCatalog.DeletePizza("Pepperoni");

                    Console.WriteLine("Deleted Pepperoni");
                    menuCatalog.PrintMenu();

                    break;


                case 3:
                    Console.WriteLine(" You selected:    " + menu[3 - 1]);
                    Console.Clear();
                    var pizzaUpdate = new Pizza();
                    menuCatalog.UpdatePizza("Vegetarian", 70);

                    Console.WriteLine("Number 3 was updated on price : Before 60kr. ,Efter 70kr.");
                    menuCatalog.PrintMenu();
                    break;


                case 4:
                    Console.WriteLine(" You selceted:     " + menu[4 - 1]);
                    Console.Clear();
                    Console.WriteLine("Enter the name of the pizza you want to find");
                    Console.WriteLine(" Please make sure the name is spelled correct");
                    string criteria = (Console.ReadLine());
                   
                    try
                    {
                        Pizza p = menuCatalog.SearchPizza(criteria);
                        Console.WriteLine("Pizza searched: ");
                        Console.WriteLine(p.ToString());
                    }
                    catch (PizzaNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                   
                  
                    

            }
            return selcetMenu;

        }

        public override string ToString()
        {
            return $"{TestMethods}";
        }
    }
  
}