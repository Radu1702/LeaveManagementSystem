using AutoMapper;
using LeaveManagementSystem2.Models.LeaveRequests;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LeaveManagementSystem2.Services.LeaveRequests
{
    public class LeaveRequestsService(IMapper _mapper, UserManager<ApplicationUser> _userManager, IHttpContextAccessor _httpContextAccessor, ApplicationDbContext _context) : ILeaveRequestsService
    {
        public async Task CancelLeaveRequest(int leaveRequestId)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(leaveRequestId);
            leaveRequest.LeaveRequestStatusId = (int)LeaveRequestStatusEnum.Canceled;

            var numberOfDays = leaveRequest.EndDate.DayNumber - leaveRequest.StartDate.DayNumber;
            var allocation = await _context.LeaveAllocations
                .FirstAsync(q => q.LeaveTypeId == leaveRequestId && q.EmployeeId == leaveRequest.EmployeeId);

            allocation.Days += numberOfDays;

            await _context.SaveChangesAsync();
            
        }

        public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var leaveRequest = _mapper.Map<LeaveRequest>(model);

            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
            leaveRequest.EmployeeId = user.Id;

            leaveRequest.LeaveRequestStatusId = (int)LeaveRequestStatusEnum.Pending;

            _context.Add(leaveRequest);
            await _context.SaveChangesAsync();

            var numberOfDays = model.EndDate.DayNumber - model.StartDate.DayNumber;
            var allocationToDeduct = await _context.LeaveAllocations.FirstAsync(q => q.LeaveTypeId == model.LeaveTypeId  && q.EmployeeId == user.Id);

            allocationToDeduct.Days -= numberOfDays;

            await _context.SaveChangesAsync();
        }

        public Task<EmployeeLeaveRequestListVM> AdminGetAllLeaveRequests()
        {
            throw new NotImplementedException();
        }

        public async Task<List<LeaveRequestReadOnlyVM>> GetEmployeeLeaveRequests()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
            var leaveRequests = await _context.LeaveRequests
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == user.Id)
                .ToListAsync();
            var model = leaveRequests.Select(q => new LeaveRequestReadOnlyVM
            {
                StartDate = q.StartDate,
                EndDate = q.EndDate,
                Id = q.Id,
                LeaveType = q.LeaveType.Name,
                LeaveRequestStatus = (LeaveRequestStatusEnum)q.LeaveRequestStatusId,
                NumberOfDays = q.EndDate.DayNumber - q.StartDate.DayNumber
            }).ToList();

            return model;
        }

        public async Task<bool> RequestDatesExceedAllocation(LeaveRequestCreateVM model)
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
            var numberOfDays = model.EndDate.DayNumber - model.StartDate.DayNumber;
            var allocationToDeduct = await _context.LeaveAllocations
                .FirstAsync(q => q.LeaveTypeId == model.LeaveTypeId && q.EmployeeId == user.Id);

            return allocationToDeduct.Days < numberOfDays;
        }

        public Task ReviewLeaveRequest(ReviewLeaveRequestVM model)
        {
            throw new NotImplementedException();
        }
    }
}
