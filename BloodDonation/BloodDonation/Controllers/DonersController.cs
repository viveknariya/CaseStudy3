using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BloodDonation.Models;
using Microsoft.Extensions.Configuration;

namespace BloodDonation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonersController : ControllerBase
    {
        private BloodDonationContext _context =  new BloodDonationContext();

        private readonly IConfiguration _config;

        public DonersController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public IActionResult GetDoner()
        {
            return Ok(_context.Doner);
        }


        [HttpPost]
        public IActionResult PostDoner(Doner doner)
        {
            _context.Doner.Add(doner);
            _context.SaveChangesAsync();

            return Ok(doner);
        }

    }
}
