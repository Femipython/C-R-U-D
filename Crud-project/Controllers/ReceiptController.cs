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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(NewReceiptClass nkt)
        {
            if (ModelState.IsValid)
            {
                _db.Add(nkt);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nkt);
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getreceiptdetails = await _db.ReceiptTable.FindAsync(id);
            return View(getreceiptdetails);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(NewReceiptClass rwq)
        {
            if (ModelState.IsValid)
            {
                _db.Update(rwq);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(rwq);
        }
        public async Task<ActionResult> Details (int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getreceiptdetails = await _db.ReceiptTable.FindAsync(id);
            return View(getreceiptdetails);
        }
        public async Task<ActionResult> Delete(int? id) 
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getreceiptdetails = await _db.ReceiptTable.FindAsync(id);
            return View(getreceiptdetails);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            var getreceiptdetails = await _db.ReceiptTable.FindAsync(id);
            _db.ReceiptTable.Remove(getreceiptdetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
