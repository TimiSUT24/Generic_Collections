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
        //loops through _orderItems and returns the whole order 
        public override string ToString()
        {
            string items = "";
            decimal totalCost = 0;
            foreach (var item in _orderItems)
            {
                items += $"1 st {item.Name}\n";
                totalCost += item.Price;
            }
            return $"Order {OrderId}:\n{items}Summa: {totalCost:F2} kr\nTill bord nummer {_tableNumber}";
        }

    }
}
