using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IdentityApp{

    public class CreateViewModel 
    {   
         [Required]
        public string? UserName { get; set; }


        [Required]
        public string? FullName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
         public string Password { get; set; } = null!;

         
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="Parolanız Eşleşmiyor")]
        public string? ConfirmPassword { get; set; }
    }


}