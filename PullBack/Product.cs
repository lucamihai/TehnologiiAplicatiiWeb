namespace PullBack
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        //public decimal Name { get; set; }
        //public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
