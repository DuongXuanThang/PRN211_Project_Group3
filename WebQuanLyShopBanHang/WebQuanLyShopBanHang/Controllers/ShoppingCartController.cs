using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebQuanLyShopBanHang.Extension;
using WebQuanLyShopBanHang.Models;
using WebQuanLyShopBanHang.ModelsView;

namespace WebQuanLyShopBanHang.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly Group3Context _context;
        public INotyfService _notyfService { get; }
        public ShoppingCartController(Group3Context context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public List<CartItem> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if(gh == default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }
        [HttpPost]
        [Route("api/cart/add")]
        public IActionResult AddtoCart(int productId, int? amount)
        {
            List<CartItem> gioHang = GioHang;
            try
            {
              
                //them san pham vao gio hang
                CartItem item = GioHang.SingleOrDefault(p => p.product.ProductId == productId);
                if (item != null) //da co--> them so luong
                {
                    item.amount = item.amount + amount.Value;
                    HttpContext.Session.Set<List<CartItem>>("GioHang", gioHang);
                }
                else
                {
                    Product hh = _context.Products.SingleOrDefault(p => p.ProductId == productId);
                    item = new CartItem
                    {
                        amount = amount.HasValue ? amount.Value : 1,
                        product = hh
                    };
                    gioHang.Add(item);//them vao gio
                }
                //luu lai session
                HttpContext.Session.Set<List<CartItem>>("GioHang", gioHang);
                _notyfService.Success("Thêm sản phẩm thành công");
                return Json(new { success = true });
               
            }
            catch(Exception ex)
            {
                return Json(new { success = false });
            }
            
        }
        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int productId, int? amount)
        {
            //lay gio hang de xu ly
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            try
            {
                if (cart != null) {
                    CartItem item = GioHang.SingleOrDefault(p => p.product.ProductId == productId);
                    if (item!=null && amount.HasValue)
                    {
                        item.amount = amount.Value;
                    }
                    //luu lai session
                    HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
                }

                return Json(new { success = true });

            }
            catch
            {
                return Json(new { success = false });
            }
        }
        [HttpPost]
        [Route("api/cart/remove")]
        public IActionResult Remove(int productId)
        {
            try
            {
                List<CartItem> gioHang = GioHang;
             
                CartItem item = GioHang.SingleOrDefault(p => p.product.ProductId == productId);
              
                    if (item !=null)
                    {
                        gioHang.Remove(item);
                    }
                //luu lai session
                HttpContext.Session.Set<List<CartItem>>("GioHang", gioHang);
                return Json(new { success = true });

            }
            catch
            {
                return Json(new { success = false });
            }

        }

        [Route("Cart.html", Name = "Cart")]
        public IActionResult Index()
        {
         return View(GioHang);
          }
    }
}
