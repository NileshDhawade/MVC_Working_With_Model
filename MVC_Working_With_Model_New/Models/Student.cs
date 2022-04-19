using System.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVC_Working_With_Model_New.Models;
//using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore;
using Microsoft.SqlServer;
using System.Data.SqlClient;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace MVC_Working_With_Model_New.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Student Id")]
        public int rollno { get; set; }



        [DisplayName("Student name")]
        //[Required]
        [DataType(DataType.Text)]
        [MaxLength(10)]
        [MinLength(1)]
        [Required(ErrorMessage ="Name is Required")]
        public string name { get; set; }



        [Required]
        [DisplayName("Student Percentage")]
        public decimal percentage { get; set; }
    }
    public class ProductContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

}
