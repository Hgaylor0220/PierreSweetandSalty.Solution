using Microsoft.AspNetCore.Mvc;
using PierreSweetandSalty.Data;
using PierreSweetandSalty.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierreSweetandSalty.Controllers
{
    [Authorize]
    public class TreatsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager <ApplicationUser> _userManager;

        public TreatsController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
    }
}