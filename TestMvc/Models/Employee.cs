using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TestMvc.Models
{
    public class Employee
    {
       
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string Qualification { get; set; }
        [Required]
        public string ContactNumber { get; set; }
     
        public int DepartmentID { get; set; }
       public virtual Department Department { get; set; }
    }
}