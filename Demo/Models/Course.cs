using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Course
    {
        [Key]
        public int CsId { get; set; }
        [Required]
        [MaxLength(50 , ErrorMessage = "Name Must not increase 50 Char .")]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        [StringLength(100 , MinimumLength =25)]
        public string Description { get; set; }
        [DataType(DataType.Time)]
        public DateTime Duration { get; set; }
        [ForeignKey(nameof(Topic))]
        public int Top_Id { get; set; }
        public Topic Topic { get; set; } = null!;
    }
}
