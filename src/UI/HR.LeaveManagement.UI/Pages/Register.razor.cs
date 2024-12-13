using HR.LeaveManagement.UI.Contracts;
using HR.LeaveManagement.UI.Models;
using Microsoft.AspNetCore.Components;

namespace HR.LeaveManagement.UI.Pages;

public partial class Register
{
    protected RegisterVm Model { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    public string Message { get; set; } = string.Empty;

    [Inject]
    public IAuthenticationService AuthenticationService { get; set; }

    protected override void OnInitialized()
    {
        Model = new RegisterVm();
    }

    protected async Task HandleRegister()
    {
        var result =
            await AuthenticationService.RegisterAsync(Model.FirstName, Model.LastName, Model.UserName, Model.Email, Model.Password);
        if (result) NavigationManager.NavigateTo("/");
        Message = "Something went wrong, please try again.";
    }
}