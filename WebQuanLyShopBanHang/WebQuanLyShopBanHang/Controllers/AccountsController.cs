using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebQuanLyShopBanHang.Helper;
using WebQuanLyShopBanHang.Models;
using WebQuanLyShopBanHang.ModelsView;

namespace WebQuanLyShopBanHang.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        private readonly Group3Context _context;
        public INotyfService _notyfService { get; }
        public AccountsController(Group3Context context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public IActionResult ValidatePhone(string Phone)
        {
            try
            {
                var kh = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Phone.ToLower() == Phone.ToLower());
                if (kh != null)
                    return Json(data: "Số điện thoại: " + Phone + "Đã được dùng");
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }
        public IActionResult ValidateEmail(string Email)
        {
            try
            {
                var kh = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == Email.ToLower());
                if (kh != null)
                    return Json(data: "Email: " + Email + "Đã được dùng");
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }
        [AllowAnonymous]
        [Route("tai-khoan-cua-toi.html", Name = "DashBroad")]
        public IActionResult DashBroad()
        {
            return View();
           
        }
       
        [HttpGet]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public IActionResult DangKyTaiKhoan()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public async Task<IActionResult> DangKyTaiKhoan(RegisAccount account)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   
                    Customer tk = new Customer
                    {
                        FullName = account.FullName,
                        Phone = account.Phone.Trim().ToLower(),
                        Email = account.Email.Trim().ToLower(),
                        Password = account.Password,
                        Active = true,
                        Salt = "",
                        CreateDate=DateTime.Now
                    };
                    try
                    {
                        _context.Add(tk);
                        await _context.SaveChangesAsync();
                        //Luu ma khach hang
                        HttpContext.Session.SetString("UserName", tk.Email);
                        HttpContext.Session.SetString("CustomerId", tk.CustomerId.ToString());
                        var taikhoanID = HttpContext.Session.GetString("CustomerId");
                        //identity
                        _notyfService.Success("Đăng ký thành công");
                        return RedirectToAction("Index", "Home");
                       
                    }
                    catch
                    {
                        return RedirectToAction("DangKyTaiKhoan", "Accounts");
                    }
                }
                else
                {
                    _notyfService.Error("Đăng ký thất bại");
                    return View(account);
                }
                }
            catch
            {
                return View(account);
            }
        }
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public IActionResult Login(string returnUrl = null)
        {
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            if (taikhoanID != null)
            {
                return RedirectToAction("DashBroad", "Accounts");
            }
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public async Task<IActionResult> Login(LoginViewModel customer, string returnUrl = null)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isEmail = Utilities.IsValidEmail(customer.UserName);
                    if (!isEmail) return View(customer);
                    Customer kh = _context.Customers.Where(x => x.Email.Trim() == customer.UserName.Trim() && x.Password == customer.Password).FirstOrDefault();
                    if (kh != null)
                    {
                        HttpContext.Session.SetString("UserName", customer.UserName);
                        HttpContext.Session.SetInt32("CustomerId", customer.CustomerId);
                        _notyfService.Success("Đăng nhập thành công");
                        return RedirectToAction("Index","Home");
                    }
                    else
                    {
                        _notyfService.Error("Đăng nhập thất bại");
                        return View(customer);
                       
                    }
                }

            }
            catch
            {
               
                return RedirectToAction("DangKyTaiKhoan", "Accounts");
            }
            return View(customer);
        }
    }
}
