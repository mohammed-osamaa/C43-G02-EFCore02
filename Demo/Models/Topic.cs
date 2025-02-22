using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> course { get; set; } = new HashSet<Course>();

    }
}
