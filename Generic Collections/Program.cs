//Tim Petersen SUT24
namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            
            //Create new menuItems and adds to menu
            var menuItem1 = new MenuItem(1, "Spaghetti och köttbullar", 75);
            restaurant.AddToMenu(menuItem1);
         
            var menuItem2 = new MenuItem(2, "Kebab pizza", 100);
            restaurant.AddToMenu(menuItem2);
           
            var menuItem3 = new MenuItem(3, "Kyckling spets", 65);
            restaurant.AddToMenu(menuItem3);
            
            var menuItem4 = new MenuItem(4, "250g Hamburgare", 105);
            restaurant.AddToMenu(menuItem4);
            
            //Shows menu
            Console.WriteLine("------------------------------------------");
            restaurant.ShowMenu();
            Console.WriteLine("------------------------------------------");

            //Create new orders using order class and adds the menuitems and tablenumber
            Order newOrder1 = new Order(new List<MenuItem> { menuItem1,menuItem3,menuItem2 }, 15);
            Order newOrder2 = new Order(new List<MenuItem> { menuItem2,menuItem3 }, 40);
            Order newOrder3 = new Order(new List<MenuItem> { menuItem3,menuItem1 }, 8);
            Order newOrder4 = new Order(new List<MenuItem> { menuItem4,menuItem4 }, 4);

            //Adds orders in the Orders list.         
            restaurant.CreateOrder(newOrder1);
            restaurant.CreateOrder(newOrder2);
            restaurant.CreateOrder(newOrder3);
            Console.WriteLine("------------------------------------------");

            //Shows all orders.
            Console.WriteLine("Aktuella beställningar:");
            restaurant.ShowOrders();
            Console.WriteLine("------------------------------------------");


            restaurant.ShowOrderCount(); //Shows how many orders that exists.
            restaurant.ShowNextOrder(); //Shows first order. 
            Console.WriteLine("");
            restaurant.HandleOrder();   //Removes the first order in the line.
            restaurant.ShowOrderCount(); 
            Console.WriteLine("------------------------------------------");


            restaurant.CreateOrder(newOrder4); //Creates new order. 
            Console.WriteLine(); 
            restaurant.ShowOrderCount();
            restaurant.HandleOrder();
            restaurant.HandleOrder();
            restaurant.ShowOrderCount();
            Console.WriteLine("------------------------------------------");


            restaurant.ShowNextOrder();
            Console.WriteLine("");
            restaurant.HandleOrder();
            restaurant.ShowOrderCount(); 

        }
    }
}
