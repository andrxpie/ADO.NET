using Entity_Framework_Intro;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Intro
{
    // Dependent entity
    internal class Resume
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public int Experience { get; set; }
        public bool Certified { get; set; }
        public string? Description { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
