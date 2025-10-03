using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem2.Models.LeaveTypes
{
    public class LeaveTypeEditVM : BaseLeaveTypeVM
    {
        [Required]
        [Length(4, 150, ErrorMessage = "You have violated the LAW!!!")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 90)]
        [Display(Name = "Maiximum Number of Days")]
        public int NumberOfDays { get; set; }
    }
}
