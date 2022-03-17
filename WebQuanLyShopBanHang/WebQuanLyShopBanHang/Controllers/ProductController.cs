using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebQuanLyShopBanHang.Models;

namespace WebQuanLyShopBanHang.Controllers
{
    public class ProductController : Controller
    {
        private readonly Group3Context _context;
        public ProductController(Group3Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Details(int id)
        {
            var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
