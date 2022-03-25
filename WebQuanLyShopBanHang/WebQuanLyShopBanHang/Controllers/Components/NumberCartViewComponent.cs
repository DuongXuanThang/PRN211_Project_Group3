﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebQuanLyShopBanHang.Extension;
using WebQuanLyShopBanHang.ModelsView;

namespace WebQuanLyShopBanHang.Controllers.Components
{
    public class NumberCartViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
          
            return View(cart);
        }
    }
}
