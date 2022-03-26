using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebQuanLyShopBanHang.Models;

namespace WebQuanLyShopBanHang.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Group3Context _context;
        public HomeController(ILogger<HomeController> logger, Group3Context context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lsProductRelate = _context.Products.AsNoTracking()
                    .Include(x => x.Cat)
                   .OrderByDescending(x => x.DateCreated).Take(8);
            ViewBag.SanPham = lsProductRelate;
            return View(lsProductRelate);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
