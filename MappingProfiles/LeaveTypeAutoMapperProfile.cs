using AutoMapper;
using LeaveManagementSystem2.Data;
using LeaveManagementSystem2.Models.LeaveTypes;

namespace LeaveManagementSystem2.MappingProfiles
{
    public class LeaveTypeAutoMapperProfile : Profile
    {
        public LeaveTypeAutoMapperProfile()
        {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();

        }
    }
}
