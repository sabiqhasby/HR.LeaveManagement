using HR.LeaveManagement.UI.Contracts;
using HR.LeaveManagement.UI.Services.Base;

namespace HR.LeaveManagement.UI.Services;

public class LeaveRequestService : BaseHttpService, ILeaveRequestService
{
    public LeaveRequestService(IClient client) : base(client)
    {
    }
}
