using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodefirstExample.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
    }

    public class StudentDBContext :DbContext
    {
        public StudentDBContext() : base("name=nvcuong_connectionString")
        {
            //làm trò khởi tạo
        }
        public DbSet<Student> Students { get; set; }
    }
}