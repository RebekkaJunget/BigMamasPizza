namespace BigMamasPizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Store store = new Store();
            store.TestMethods();

            List<string> menuItems = new List<string>
            {
                "Add new pizza to the menu",
                "Delete pizza",
                "Update pizza",
                "Search pizza",
                "Display pizza menu"

            };
            
           
        }
    }
}
