using AutoMapper;
using LeaveManagementSystem2.Models.LeaveAllocations;
using LeaveManagementSystem2.Models.LeaveTypes;
using LeaveManagementSystem2.Models.Periods;

namespace LeaveManagementSystem2.MappingProfiles
{
    public class LeaveAllocationAutoMapperProfile : Profile
    {
        public LeaveAllocationAutoMapperProfile()
        {
            CreateMap<LeaveAllocation, LeaveAllocationVM>();
            CreateMap<ApplicationUser, EmployeeListVM> ();
            CreateMap<Period, PeriodVM>();
        }
    }
}
