using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models;

public class Regmodel
{
    [Required]
    [Display(Name="Email")]
    public string Email { get; set; }
    
    [Required]
    [Display(Name = "Year of birth")]
    public int Year { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }
    
    [Required]
    [Compare("Password", ErrorMessage = "Passwords dont match")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm password ")]
    public string PasswordConfirm { get; set; }
}