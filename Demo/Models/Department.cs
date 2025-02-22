using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly HireDate { get; set; }

        //Navigation Property
        public Student Student { get; set; } = null!;

        [ForeignKey(nameof(Manager))]
        public int ManagerId { get; set; }

        [InverseProperty(nameof(Instructor.ManagedDepartment))]
        public Instructor Manager { get; set; } = null!;

        [InverseProperty(nameof(Instructor.HiredDepartment))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
