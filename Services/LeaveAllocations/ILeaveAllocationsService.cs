
using LeaveManagementSystem2.Models.LeaveAllocations;

namespace LeaveManagementSystem2.Services.LeaveAllocations
{
    public interface  ILeaveAllocationsService
    {
        Task AllocateLeave(string employeeId);
        Task EditAllocation(LeaveAllocationEditVM allocationEditVM);
        Task<EmployeeAllocationVM> GetEmployeeAllocation(string? userId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int? allocationId);
        Task<List<EmployeeListVM>> GetEmployees();
    }
}
