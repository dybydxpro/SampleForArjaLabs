using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleForArjaLabs.Models;

namespace SampleForArjaLabs.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class ResponceController : ControllerBase
    {
        private readonly AppDatabaseContext _db;

        public ResponceController(AppDatabaseContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<ActionResult<List<Responce>>> Post(Responce res)
        {
            _db.Responces.Add(res);
            await _db.SaveChangesAsync();
            return Ok(res.RequestData);
        }
    }
}
