
using System.ComponentModel.DataAnnotations;


namespace Juan.ViewModels
{
    public class ForgetPasswordVM
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
