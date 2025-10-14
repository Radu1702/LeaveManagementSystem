using AutoMapper;
using LeaveManagementSystem2.Models.LeaveRequests;

namespace LeaveManagementSystem2.MappingProfiles
{
    public class LeaveRequestAutoMapperProfile : Profile
    {
        public LeaveRequestAutoMapperProfile()
        {
            CreateMap<LeaveRequestCreateVM, LeaveRequest>();
        }
    }
}
