using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem2.Data
{
    public class LeaveType : BaseEntity
    {
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; } = string.Empty;
        public int NumberOfDays { get; set; }
    }
}
