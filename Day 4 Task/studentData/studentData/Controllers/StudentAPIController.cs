using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using studentData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace studentData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly MyDbContext context;

        public StudentAPIController(MyDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("GetStudents")]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var data = await context.Students.ToListAsync();
            return Ok(data);
        }

        //[HttpGet("{id}")]
        [HttpGet]
        [Route("GetStudentById")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var student = await context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }

        [HttpPost]
        [Route("ADD")]
        public async Task<ActionResult<Student>> ADDStudent(Student std)
        {
            await context.Students.AddAsync(std);
            await context.SaveChangesAsync();
            return Ok(std);
        }

        //[HttpPut("{id}")]
        [HttpPut]
        [Route("UpdateStudentById")]
        public async Task<ActionResult<Student>> UpdateStudentById(int id, Student std)
        {          
            if (id != std.Id)
            {
                return BadRequest();
            }
            context.Entry(std).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(std);
        }

        //[HttpDelete("{id}")]
        [HttpDelete]
        [Route("DeleteStudentById")]
        public async Task<ActionResult<Student>> DeleteStudentById(int id)
        {
            var std = await context.Students.FindAsync(id);
            if(std== null)
            {
                return NotFound();
            }
            context.Students.Remove(std);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
