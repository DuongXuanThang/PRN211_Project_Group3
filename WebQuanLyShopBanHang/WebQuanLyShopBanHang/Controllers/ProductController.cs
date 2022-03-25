using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
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
        public INotyfService _notyfService { get; }
        public ProductController(Group3Context context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        [Route("shop.html", Name = "ShopProduct")]
        public IActionResult Index(int? page)
        { //phan trang sap xep theo ngay tao
            try
            {
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
                var pageSize = 10;
                var lsProduct = _context.Products.AsNoTracking().
                    Include(x => x.Cat)
                    .OrderByDescending(x => x.DateCreated);
                PagedList<Product> models = new PagedList<Product>(lsProduct, pageNumber, pageSize);
                ViewBag.CurrentPage = pageNumber;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
           
        }
        [Route("/{Alias}", Name = "ListProduct")]
        public IActionResult List(string Alias,int page=1)
        {
            //phan trang
            try
            {
                var danhmuc = _context.Categories.AsNoTracking().SingleOrDefault();
                var pageSize = 10;
                var lsProduct = _context.Products.AsNoTracking().Where(x => x.CatId == danhmuc.CatId).
                    Include(x => x.Cat)
                    .OrderByDescending(x => x.DateCreated);
                PagedList<Product> models = new PagedList<Product>(lsProduct, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCat = danhmuc;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index","Home");
            }
           
        }
        [Route("/{Alias}-{id}.html",Name ="ProductDetails")]
        public IActionResult Details(int id)
        {
            try
            {
                var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);
                if (product == null)
                {
                    return RedirectToAction("Index");
                }
                var lsProductRelate = _context.Products.AsNoTracking()
                    .Where(x => x.CatId == product.CatId && x.ProductId != id && x.Active == true)
                    .Take(4).OrderByDescending(x=>x.DateCreated).ToList();
                ViewBag.SanPham = lsProductRelate;
                return View(product);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
           
        }
    }
}
