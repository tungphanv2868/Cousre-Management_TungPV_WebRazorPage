﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Course = new HashSet<Course>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string MajorId { get; set; }

        public virtual Major Major { get; set; }
        public virtual ICollection<Course> Course { get; set; }
    }
}