using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.DatabaseContext.Repositories;

public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
{
    public LeaveRequestRepository(HrDatabaseContext context) : base(context)
    {

    }

    public async Task<LeaveRequest> GetLeaveRequestWithDetails(int id)
    {
        var leaveRequest = await _context.LeaveRequests
        .Include(q => q.LeaveType) //inner join
        .FirstOrDefaultAsync(q => q.Id == id);
        return leaveRequest;
    }

    public async Task<List<LeaveRequest>> GetLeaveRequestWithDetails()
    {
        var leaveRequest = await _context.LeaveRequests
        .Include(q => q.LeaveType) //inner join
        .ToListAsync();
        return leaveRequest;
    }

    public async Task<List<LeaveRequest>> GetLeaveRequestWithDetailsAsync(string userId)
    {
        var leaveRequests = await _context.LeaveRequests.Where(q => q.RequestingEmployeeId == userId)
        .Include(q => q.LeaveType) //inner join
        .ToListAsync();
        return leaveRequests;
    }

}

