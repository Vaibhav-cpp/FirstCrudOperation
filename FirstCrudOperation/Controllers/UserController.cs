using Microsoft.AspNetCore.Http;        
using Microsoft.AspNetCore.Mvc;
using FirstCrudOperation.Models;

namespace FirstCrudOperation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        // Constructor to inject the ApplicationDbContext
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Get: api/User/GetAllUsers
        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            //Fetch All users from the database using Entity Framework Core
            var users = _context.Users.ToList();
            //It will return 200 ok with user list
            return Ok(users);
        }

        [HttpGet("GetUserById/{id:int}")]
        public IActionResult GetUserById(int id)
        {   //we can find user with the help of Find method of DbSet. It will return null if user not found.
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound(); //404
            }
            return Ok(user); //200
        }

        //Post: api/User/CreateUser
        [HttpPost("CreateUser")]
        public IActionResult CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        //Put: api/User/2/UpdateUser
        [HttpPut("UpdateUser/{id}")]
        public IActionResult UpdateUser(int id, User user)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var existingUser = _context.Users.Find(id);
            if (existingUser == null)
            {
                return NotFound();
            }
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            existingUser.Password = user.Password;
            _context.SaveChanges();
            return Ok(user);
        }

        //Delete: api/User/2/DeleteUser
        [HttpDelete("DeleteUser/{id:int}")]
        public IActionResult DeleteUser(int id)
        {
            var existingUser = _context.Users.Find(id);
            if (existingUser == null)
            {
                return NotFound();//404
            }
            _context.Users.Remove(existingUser);
            _context.SaveChanges();
            return Ok("Deleted Successfully");
        }
    }
}
