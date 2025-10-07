using LeaveManagementSystem2.Services.LeaveAllocations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem2.Controllers
{
    [Authorize]
    public class LeaveAllocationController(ILeaveAllocationsService _leaveAllocationsService) : Controller
    {
        [Authorize(Roles.Administrator)]
        public async Task<IActionResult> Index()
        {
            var employeeVm = await _leaveAllocationsService.GetEmployeeAllocation();
            return View(employeeVm);
        }
        public async Task<IActionResult> Details()
        {
            var employeeVm = await _leaveAllocationsService.GetEmployeeAllocation();
            return View(employeeVm);
        }
    }
}
