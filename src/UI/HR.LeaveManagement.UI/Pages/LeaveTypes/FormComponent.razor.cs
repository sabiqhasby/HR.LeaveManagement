using HR.LeaveManagement.UI.Models.LeaveTypes;
using Microsoft.AspNetCore.Components;

namespace HR.LeaveManagement.UI.Pages.LeaveTypes;

public partial class FormComponent : ComponentBase
{
    [Parameter]
    public bool Disabled { get; set; } = false;

    [Parameter]
    public LeaveTypeVM LeaveType { get; set; }

    [Parameter]
    public string ButtonText { get; set; } = "Save";

    [Parameter]
    public EventCallback OnValidSubmit { get; set; }
}