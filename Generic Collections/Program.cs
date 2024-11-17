//Tim Petersen SUT24
namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            //Menu list so we can create new items. 
            List<MenuItem> menu = new List<MenuItem>()
            {
                new MenuItem(1,"Spaghetti och köttbullar",75),
                new MenuItem(2,"Kebab pizza",100),
                new MenuItem(3,"Kyckling spets 8st",65),
                new MenuItem(4,"250g Hamburgare",105)
            };

            //Loops through the menu and adds the items to the Main menu. 
            foreach (var item in menu)
            {
                restaurant.AddToMenu(item);
            }

            Console.WriteLine("------------------------------------------");
            restaurant.ShowMenu();
            Console.WriteLine("------------------------------------------");
         
            //Creates new lists that uses MenuItem objects and takes items from the menu list so we can create new orders. 
            List<MenuItem> order1 = new List<MenuItem>()
            {
                new MenuItem(1, $"1 st {menu[0].Name}\n1 st {menu[1].Name}", menu[0].Price + menu[1].Price)
            };

            List<MenuItem> order2 = new List<MenuItem>()
            {
                new MenuItem(2, $"1 st {menu[3].Name}\n1 st {menu[1].Name}", menu[3].Price + menu[1].Price)
            };

            List<MenuItem> order3 = new List<MenuItem>()
            {
                new MenuItem(3, $"1 st {menu[2].Name}\n1 st {menu[0].Name}", menu[2].Price + menu[0].Price)
            };

            List<MenuItem> order4 = new List<MenuItem>()
            {
                new MenuItem(4, $"1 st {menu[0].Name}", menu[0].Price)
            };

            //Create new objects from Order class and creates new lists that uses MenuItem class objects and set a tablenumber value. 
            Order addOrder1 = new Order(new List<MenuItem>(order1), 15);
            Order addOrder2 = new Order(new List<MenuItem>(order2), 40);
            Order addOrder3 = new Order(new List<MenuItem>(order3), 8);
            Order addOrder4 = new Order(new List<MenuItem>(order4), 4);

            //Adds orders in the Orders list.         
            restaurant.CreateOrder(addOrder1);
            restaurant.CreateOrder(addOrder2);
            restaurant.CreateOrder(addOrder3);
            Console.WriteLine("------------------------------------------");

            //Shows all orders.
            Console.WriteLine("Aktuella beställningar:");
            restaurant.ShowOrders();
            Console.WriteLine("------------------------------------------");


            restaurant.ShowOrderCount(); //Shows how many orders that exists.
            restaurant.ShowNextOrder(); //Shows first order. 
            restaurant.HandleOrder();   //Removes the first order in the line.
            restaurant.ShowOrderCount(); 
            Console.WriteLine("------------------------------------------");


            restaurant.CreateOrder(addOrder4); //Creates new order. 
            Console.WriteLine(); 
            restaurant.ShowOrderCount();
            restaurant.HandleOrder();
            restaurant.HandleOrder();
            restaurant.ShowOrderCount();
            Console.WriteLine("------------------------------------------");


            restaurant.ShowNextOrder();
            restaurant.HandleOrder();
            restaurant.ShowOrderCount(); 

        }
    }
}
