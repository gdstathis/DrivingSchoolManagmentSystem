﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolManagmentSystem.Models
{
    internal class Customer
    {
         public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FathersName { get; set; }

        public string MothersName { get; set; }
        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }


        
    }
}
