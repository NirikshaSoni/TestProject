using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
namespace TestMvc.Models
{
    public class OrganizeContext : DbContext
    {
        public OrganizeContext():base("name=DbConnectionString")
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
       
    }
}