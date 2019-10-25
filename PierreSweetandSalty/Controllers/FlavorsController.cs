using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PierreSweetandSalty.Models;
using PierreSweetandSalty.Data;

namespace PierreSweetandSalty.Controllers
{
    public class FlavorsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FlavorsController(ApplicationDbContext db)
        {
            _db = db;
        }

    }
}