namespace WebApplication1.Data
{
    public class Candies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public int Size { get; set; }
        public int ImageURL { get; set; }
        public int Price { get; set; }
        public int RegisterOn { get; set; }
        ICollection<ShoppingCandies> ShoppingCandies { get; set; }

    }
}
