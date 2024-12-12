using System.ComponentModel.DataAnnotations;

namespace HR.LeaveManagement.UI.Models
{
   public class LoginVm
   {
      [Required]
      public string Email { get; set; } = string.Empty;
      [Required]
      public string Password { get; set; } = string.Empty;
   }
}
