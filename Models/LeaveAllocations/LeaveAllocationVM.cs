using LeaveManagementSystem2.Models.LeaveTypes;
using LeaveManagementSystem2.Models.Periods;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem2.Models.LeaveAllocations
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }

        [Display(Name = "Number Of Days")]
        public int Days { get; set; }

        [Display(Name = "Allocation Period")]
        public PeriodVM Period { get; set; } = new PeriodVM();

        public LeaveTypeReadOnlyVM? LeaveType { get; set; } = new LeaveTypeReadOnlyVM();
    }
}
