using LeaveManagementSystem2.Models.LeaveRequests;
using LeaveManagementSystem2.Services.LeaveRequests;
using LeaveManagementSystem2.Services.LeaveTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LeaveManagementSystem2.Controllers
{
    [Authorize]
    public class LeaveRequestsController(ILeaveTypesService _leaveTypesService, ILeaveRequestsService _leaveRequestsService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = await _leaveRequestsService.GetEmployeeLeaveRequests();
            return View(model);
        }

        public async Task<IActionResult> Create()
        {
            var leaveTypes = await _leaveTypesService.GetAll();
            var leaveTypesList = new SelectList(leaveTypes, "Id", "Name");
            var model = new LeaveRequestCreateVM
            {
                StartDate = DateOnly.FromDateTime(DateTime.Now),
                EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                LeaveTypes = leaveTypesList
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveRequestCreateVM model)
        {
            if (await _leaveRequestsService.RequestDatesExceedAllocation(model))
            {
                ModelState.AddModelError(string.Empty, "You have exceeded your allocations");
                ModelState.AddModelError(nameof(model.EndDate), "The number of days requested is invalid.");
            }

            if (ModelState.IsValid)
            {
                await _leaveRequestsService.CreateLeaveRequest(model);
                return RedirectToAction(nameof(Index));
            }
            var leaveTypes = await _leaveTypesService.GetAll();
            var leaveTypesList = new SelectList(leaveTypes, "Id", "Name");
            model.LeaveTypes = leaveTypesList;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cancel(int id)
        {
            await _leaveRequestsService.CancelLeaveRequest(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ListRequests()
        {
            return View();
        }
        public async Task<IActionResult> Review(int leaveRequestId)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Review()
        {
            return View();
        }
    }
}
