using HR.LeaveManagement.UI.Contracts;
using HR.LeaveManagement.UI.Services.Base;

namespace HR.LeaveManagement.UI.Services;

public class LeaveAllocationService : BaseHttpService, ILeaveAllocationService
{
    public LeaveAllocationService(IClient client) : base(client)
    {
    }
}