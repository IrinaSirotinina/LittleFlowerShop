using Microsoft.AspNetCore.Identity;

namespace FlowerShop
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get;  set; }
        
    }
}