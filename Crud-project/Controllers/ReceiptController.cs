using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crud_project.Models;
using Microsoft.EntityFrameworkCore;


namespace Crud_project.Controllers
{
    public class ReceiptController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ReceiptController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displaydata = _db.ReceiptTable.ToList();
            return View(displaydata);
        }
    }
}
