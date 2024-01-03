using Microsoft.AspNetCore.Mvc;
using Apitask.Server.Data;
using Apitask.Shared;

namespace Apitask.Server.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        AppDbContext _appDbContext;

       public StudentController(AppDbContext appDbContext)
        {
            _appDbContext= appDbContext;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        [HttpGet]
        [Route("/Pass")]
        public IEnumerable<Student> GetPassStudent()
        {
            return _appDbContext.Students.ToList();

       
        }

     
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            try
            {
                _appDbContext.Students.Add(student);
                _appDbContext.SaveChanges();
             
                return Ok("Message:Save successfuly");
            }
            catch
            {
                return BadRequest();
            }
        }

      
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {


        }
    }
}
