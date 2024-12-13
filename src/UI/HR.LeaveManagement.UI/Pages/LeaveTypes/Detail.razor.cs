using HR.LeaveManagement.UI.Contracts;
using HR.LeaveManagement.UI.Models.LeaveTypes;
using Microsoft.AspNetCore.Components;

namespace HR.LeaveManagement.UI.Pages.LeaveTypes;

public partial class Detail : ComponentBase
{
    [Inject]
    private ILeaveTypeService _client { get; set; }

    [Parameter]
    public int Id { get; set; }

    private LeaveTypeVM _leaveType = new();

    protected override async Task OnParametersSetAsync()
    {
        _leaveType = await _client.GetLeaveTypeDetails(Id);
    }
}