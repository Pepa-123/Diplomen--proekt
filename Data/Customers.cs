using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Data
{
    public class Customers:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        ICollection<ShoppingCandies > ShoppingCandies { get; set;}
       
    }
}
