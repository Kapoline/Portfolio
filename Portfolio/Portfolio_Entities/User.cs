using Microsoft.AspNetCore.Identity;

namespace Portfolio_Entities;

public class User: IdentityUser
{
    public int Year { get; set; }
}