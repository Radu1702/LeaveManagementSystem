using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem2.Data
{
    public class Period : BaseEntity 
    {
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }
    }
}
