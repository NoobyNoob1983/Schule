using System;
using System.Collections.Generic;

namespace DBFirst_Mitarbeiter.Models
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProjectRole { get; set; }
        public int? ProjectId { get; set; }

        public virtual Projects Project { get; set; }
    }
}
