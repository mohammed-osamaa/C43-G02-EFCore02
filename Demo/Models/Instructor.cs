using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public int HourRate { get; set; }
        [InverseProperty(nameof(Department.Manager))]
        public Department ManagedDepartment { get; set; } = null!;

        [ForeignKey(nameof(HiredDepartment))]
        public int DeptId { get; set; }
        [InverseProperty(nameof(Department.Instructors))]
        public Department HiredDepartment { get; set; }= null!; 

    }
}
