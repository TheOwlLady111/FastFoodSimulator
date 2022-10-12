namespace FastFoodSimulator.Data
{
    public class Order
    {
        private static int _id = 1;
        private static int _receipt = 1;
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int Receipt { get; set; }

        public Order(int customerId)
        {
            Id = _id;
            Receipt = _receipt;
            CustomerId = customerId;

            _id++;
            _receipt++;
        }
    }
}
