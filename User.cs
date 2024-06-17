namespace Assignment002
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class User : IdentityUser
    {
        // Navigation property
        public ICollection<Book> BooksBorrowed { get; set; }
    }

}
