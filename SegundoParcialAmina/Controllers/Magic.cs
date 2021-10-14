using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SegundoParcialAmina.Data;
using SegundoParcialAmina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAmina.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Magic : ControllerBase
    {
        private readonly AppDbContext _context;
        public Magic(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<Suerte>> GetCancion()
        {

            var list = await _context.Suerte.ToListAsync();

            var max = list.Count;
            int index = new Random().Next(0, max);

            var suerte = list[index];

            if (suerte == null)
            {
                return NoContent();
            }

            return suerte;
        }


    }
}
