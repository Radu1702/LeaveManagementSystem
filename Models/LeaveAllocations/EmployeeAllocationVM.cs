using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem2.Models.LeaveAllocations
{
    public class EmployeeAllocationVM
    {
        public string Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }

        [Display(Name = "Email Adress")]
        public string Email { get; set; }

        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }
}
