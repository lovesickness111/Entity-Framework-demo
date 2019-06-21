using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentManagement.Controllers
{
    [RoutePrefix("student")]
    public class StudentController : ApiController
    {
        public static List<Student> students = new List<Student>() { new Student { Id = 1, StudentCode = "15022865", StudentName = "Nguyễn Việt Cường" }, new Student { Id = 2, StudentCode = "15022879", StudentName = "Phạm Thanh Tùng" } };

        /// <summary>
        /// lấy danh sách học sinh
        /// </summary>
        /// <returns></returns>
        [Route("list")]
        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }
        /// <summary>
        /// lấy chi tiết học sinh theo id
        /// </summary>
        /// <param name="id">id học sinh</param>
        /// <returns></returns>
        /// 
        [Route("{id}")]
        public IHttpActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault((p) => p.Id == id);
            if (students == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
        /// <summary>
        /// thêm mới sinh viên
        /// </summary>
        /// <param name="student">đối tượng sinh viên</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public IHttpActionResult CreateStudent([FromBody]Student student)
        {
            try
            {
                students.Add(student);
                return Ok(student);

            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
        /// <summary>
        /// sửa thông tin sinh viên
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Update")]
        public IHttpActionResult UpdateStudent(Student student)
        {
            try
            {
                // xóa phần tử đã có
                var studentOld = students.FirstOrDefault((p) => p.Id == student.Id);
                students.Remove(studentOld);
                // thêm vào mảng
                students.Add(student);
                return Ok(student);

            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
        /// <summary>
        /// xóa thông tin sinh viên
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault((p) => p.Id == id);
            if (students == null)
            {
                return NotFound();
            }else
            {
                students.Remove(student);
            }
            return Ok(student);
        }
    }
}
