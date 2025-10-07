
using LeaveManagementSystem2.Models.LeaveAllocations;

namespace LeaveManagementSystem2.Services.LeaveAllocations
{
    public interface  ILeaveAllocationsService
    {
        Task AllocateLeave(string employeeId);
        Task<List<LeaveAllocation>> GetAllocations();
        Task<EmployeeAllocationVM> GetEmployeeAllocation();
    }
}
