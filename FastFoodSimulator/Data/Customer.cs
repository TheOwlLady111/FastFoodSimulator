namespace FastFoodSimulator.Data
{
    public class Customer
    {
        private static int _id = 1;
        public int Id { get; set; }
        public Order CustomerOrder { get; set; }

        public Customer()
        {
            Id = _id;
            _id++;
        }

    }
}
