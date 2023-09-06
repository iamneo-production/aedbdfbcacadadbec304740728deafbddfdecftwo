using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models; 

namespace dotnetapp.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseTrackerController : ControllerBase
    {
        private readonly ExpenseTrackerApiDbContext _context;

        public ExpenseTrackerController(ExpenseTrackerApiDbContext context)
        {
            _context = context;
        }

        
    }
}
