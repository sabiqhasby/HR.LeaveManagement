using HR.LeaveManagement.UI.Contracts;
using HR.LeaveManagement.UI.Models.LeaveTypes;
using Microsoft.AspNetCore.Components;

namespace HR.LeaveManagement.UI.Pages.LeaveTypes;

public partial class Create : ComponentBase
{
    [Inject]
    private NavigationManager NavigationManager { get; set; }

    [Inject]
    private ILeaveTypeService _client { get; set; }

    private string Message { get; set; } = string.Empty;

    private LeaveTypeVM _leaveType = new();

    private async Task CreateLeaveType()
    {
        var response = await _client.CreateLeaveType(_leaveType);
        if (response.Success) NavigationManager.NavigateTo("/leavetypes");

        Message = response.Message;
    }
}