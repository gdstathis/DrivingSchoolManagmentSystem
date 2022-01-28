using DrivingSchoolManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolManagmentSystem
{
    internal class DrivingSchoolContext :DbContext
    {

        public DrivingSchoolContext() : base(@"Data Source=.;Initial Catalog=DrivingManagmentSchool;Trusted_Connection=True;")
        {

        }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
