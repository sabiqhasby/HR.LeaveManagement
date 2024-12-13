using HR.LeaveManagement.UI.Contracts;
using HR.LeaveManagement.UI.Models.LeaveTypes;
using Microsoft.AspNetCore.Components;

namespace HR.LeaveManagement.UI.Pages.LeaveTypes;

public partial class Edit
{
    [Inject]
    private ILeaveTypeService _client { get; set; }

    [Inject]
    private NavigationManager _navManager { get; set; }

    [Parameter]
    public int id { get; set; }

    public string Message { get; private set; }

    private LeaveTypeVM leaveType = new();

    protected override async Task OnParametersSetAsync()
    {
        leaveType = await _client.GetLeaveTypeDetails(id);
    }

    private async Task EditLeaveType()
    {
        var response = await _client.UpdateLeaveType(id, leaveType);
        if (response.Success) _navManager.NavigateTo("/leavetypes/");
        Message = response.Message;
    }
}