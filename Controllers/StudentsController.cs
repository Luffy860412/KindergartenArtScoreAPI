// Controllers/StudentsController.cs
using Microsoft.AspNetCore.Mvc;
using KindergartenArtScoreAPI.Models; // 請根據您的專案調整命名空間
using System.Collections.Generic;
using System.Linq;
using KindergartenArtScoreAPI.Data;  // 加入這行命名空間宣告

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly StudentDbContext _context;

    public StudentsController(StudentDbContext context)
    {
        _context = context;
    }

    // GET: api/Students
    [HttpGet]
    public ActionResult<IEnumerable<Student>> GetStudents()
    {
        return _context.Students.ToList();
    }

    // GET: api/Students/5
    [HttpGet("{id}")]
    public ActionResult<Student> GetStudent(int id)
    {
        var student = _context.Students.Find(id);

        if (student == null)
        {
            return NotFound();
        }

        return student;
    }

    // POST: api/Students
    [HttpPost]
    public ActionResult<Student> CreateStudent([FromBody] Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, new { message = "學生新增成功", id = student.Id });
    }

    // PUT: api/Students/5
    [HttpPut("{id}")]
    public IActionResult UpdateStudent(int id, [FromBody] Student student)
    {
        if (id != student.Id)
        {
            return BadRequest();
        }

        var existingStudent = _context.Students.Find(id);
        if (existingStudent == null)
        {
            return NotFound();
        }

        existingStudent.Name = student.Name;
        existingStudent.ArtScore = student.ArtScore;
        existingStudent.ClassName = student.ClassName;

        _context.SaveChanges();

        return Ok(new { message = "學生資料更新成功" });
    }

    // DELETE: api/Students/5
    [HttpDelete("{id}")]
    public IActionResult DeleteStudent(int id)
    {
        var student = _context.Students.Find(id);
        if (student == null)
        {
            return NotFound();
        }

        _context.Students.Remove(student);
        _context.SaveChanges();

        return Ok(new { message = "學生刪除成功" });
    }
}