﻿using System;
using System.Collections.Generic;

namespace Angular2Spa.Models
{
    public partial class EmployeeDirectory
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ReportsTo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public int? Extension { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Position { get; set; }

        public virtual EmployeeDirectory ReportsToNavigation { get; set; }
        public virtual ICollection<EmployeeDirectory> InverseReportsToNavigation { get; set; }
    }
}