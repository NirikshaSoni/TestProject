using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
namespace TestMvc.Models
{
    public class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }

        public virtual  ICollection<Employee> Employees { get; set; }
       
    }
}