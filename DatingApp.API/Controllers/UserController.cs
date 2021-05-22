using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace DatingApp.API.Controller
{
[Route("[Controller]")]
[ApiController]
public class UserController: ControllerBase
{

private readonly DatingAppContext _context;
public UserController(DatingAppContext context)
{
    _context = context;
}


[HttpGet]
public async Task<IActionResult> GetUsers()
{

    return  Ok(await _context.Users.ToListAsync());
} 

[HttpGet("{id}")]
public async Task<IActionResult> GetUserDetails(int id)
{

    return  Ok( await _context.Users.Where(u => u.Id==id).FirstOrDefaultAsync());
} 


}
    
}