﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MLP.Models
{
    public class Student
    {
        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Image { get; set; }

        public string About { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Cnic { get; set; }

        public string City { get; set; }

        public string FacebookUrl { get; set; }

        public string TwitterName { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}