using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Order_CRUD.Models;

namespace Order_CRUD.Controllers
{
    public class OrdersController : Controller
    {

        private readonly DataDbContext _context;
        public OrdersController(DataDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.orders.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(orders ord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ord);
                await _context.SaveChangesAsync();
                return View();

            }

            return View(ord);
        }

    }
}
