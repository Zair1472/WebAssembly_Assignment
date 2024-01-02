using Microsoft.AspNetCore.Mvc;
using WebAssembly_Assignment.Server.Data;
using WebAssembly_Assignment.Shared;

namespace WebAssembly_Assignment.Server.Controllers
{
    
        [Route("api/v1/[controller]")]
        [ApiController]
        public class DonationController : ControllerBase
        {

            AppDbContext _appDbContext;

            public DonationController(AppDbContext appDbContext)
            {
                _appDbContext = appDbContext;
            }

            [HttpGet("{id}")]
            public string Get(int id)
            {
                return "value";
            }


            [HttpPost]
            public IActionResult Post([FromBody] Donation donation)
            {
                try
                {
                    _appDbContext.Donations.Add(donation);
                    _appDbContext.SaveChanges();

                    return Ok("Message:Save Successfuly");
                }
                catch
                {
                    return BadRequest();
                }
            }


            [HttpPut("{Id}")]
            public void Put(int Id, [FromBody] string value)
            {
            }


        }
    }
