
using HR.LeaveManagement.UI.Contracts;
using HR.LeaveManagement.UI.Models;
using Microsoft.AspNetCore.Components;


namespace HR.LeaveManagement.UI.Pages
{
   public partial class Login
   {
      public LoginVm Model { get; set; }

      [Inject]
      public NavigationManager NavigationManager { get; set; }
      public string Message { get; set; }

      [Inject]
      private IAuthenticationService AuthenticationService { get; set; }

      public Login()
      {

      }
      protected async Task HandleLogin()
      {
         if (await AuthenticationService.AuthenticateAsync(Model.Email, Model.Password))
         {
            NavigationManager.NavigateTo("/");
         }
         Message = "Username/Password combination is incorrect.";
      }
      protected override void OnInitialized()
      {
         Model = new LoginVm();
      }
      
      


   }
}