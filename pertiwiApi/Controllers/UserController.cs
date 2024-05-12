using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pertiwiApi.Models;

namespace pertiwiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class UserController : ControllerBase
    {
        private readonly MyDbContext _MyDbContext;

        public UserController (MyDbContext MyDbContext)
        {
            _MyDbContext = MyDbContext;
        }


        // Untuk Menampilkan Data 

        [HttpGet]

        public async Task <ActionResult<IEnumerable<tbl_users>>> GetUser()
        {
            if (_MyDbContext.tbl_users == null)
            {
                return NotFound();
            }

            return await _MyDbContext.tbl_users.ToListAsync();
        }

        // Untuk Login

        [HttpGet("ID")]
        public async Task<ActionResult<tbl_users>> GetUserById(int Id)
        {
            if (_MyDbContext.tbl_users == null)
            {
                return NotFound();
            }

            var user = await _MyDbContext.tbl_users.FindAsync(Id);

            if (user == null) 
            {
                return NotFound();
            }

            return user;
        }


        [HttpGet("username")]
        public async Task<ActionResult<tbl_users>> getLogin(string username, string password)
        {
            if (_MyDbContext.tbl_users == null)
            {
                return NotFound();
            }

            var user = await _MyDbContext.tbl_users.Where(x => x.username == username).Where(y => y.password == password).FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }


        //Create Data 
        [HttpPost]

        public async Task<ActionResult<tbl_users>> saveUser(tbl_users user)
        {
            _MyDbContext.Add(user);

            await _MyDbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
