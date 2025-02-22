using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    [Table("Students")]
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("First Name" , TypeName = "varchar")]
        [StringLength(50 , MinimumLength = 3)]
        public required string FName { get; set; }
        [Column("Last Name", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string? LName { get; set; }
        public string? Address { get; set; }
        [Range(18 , 49)]
        public int Age { get; set; }

        //navigation Property And FK
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
    }
}
