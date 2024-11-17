namespace Generic_Collections
{
    public class Order
    {
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;
        
        //Expose the private fields to public properties so we can use them in other classes. 
        public int OrderId
        {
            get { return _orderId; }
        }
        public int TableNumber
        {
            get { return _tableNumber; }
        }
        public List<MenuItem> OrderItems
        {
            get { return _orderItems; }
        }
        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }
        //Can use this to show one or multiple orders. 
        public void ShowOrder()
        {
            Console.WriteLine($"Order {_orderId}:");
            foreach (var order in OrderItems)
            {
                Console.WriteLine($"{order.Name}\nSumma: {order.Price:C}\nTill bord nummer {_tableNumber}\n");
            }
        }
        
    }
}
