namespace Generic_Collections
{
    public class Restaurant
    {
        List<MenuItem> Menu = new List<MenuItem>();

        Queue<Order> Orders = new Queue<Order>();

        //Adds items to Menu
        public void AddToMenu(MenuItem menuItem)
        {          
            Menu.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} har lagts till i menyn.");            
        }
        //Shows the whole menu. 
        public void ShowMenu()
        {
            Console.WriteLine("Meny:");
            foreach (MenuItem item in Menu)
            {
                Console.WriteLine($"{item.Id}. {item.Name} - {item.Price:C}");
            }
        }
        //Adds orders to the queue. 
        public void CreateOrder(Order order)
        {
            Orders.Enqueue(order);
            Console.WriteLine($"Beställning {order.OrderId} har lagts till");
        }
        //Removes orders from the queue. 
        public void HandleOrder()
        {
            Console.WriteLine("Order " + Orders.Dequeue().OrderId + " är färdig.");
            Console.WriteLine();
        }
        //Shows all the orders.
        public void ShowOrders()
        {
            foreach (var order in Orders)
            {
                Console.WriteLine(order + "\n");
            }
        }
        //Shows the next order in the queue 
        public void ShowNextOrder()
        {          
            if(Orders.Count > 0)
            {
                Console.WriteLine("Nästa order i kön:");
                Console.WriteLine(Orders.Peek()); 
            }         
        }
        //Shows how many orders there are and if there are none left. 
        public void ShowOrderCount()
        {
            if (Orders.Count == 1)
            {
                Console.WriteLine($"Det är {Orders.Count} order i kön");
            }
            else if (Orders.Count >= 2)
            {
                Console.WriteLine($"Det är {Orders.Count} ordrar i kön.");
                Console.WriteLine();
            }

            if(Orders.Count == 0)
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu."); 
            }

        }
    }
}
