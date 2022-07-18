using System.ComponentModel.DataAnnotations;

namespace ShowHouse.MVC.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password don't match")]
        public string RePassword { get; set; }
    }
}