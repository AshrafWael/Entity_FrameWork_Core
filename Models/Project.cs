﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
       public Employee Employee { get; set; }
       public ICollection<Department> Departments { get; set; }
    }
}
