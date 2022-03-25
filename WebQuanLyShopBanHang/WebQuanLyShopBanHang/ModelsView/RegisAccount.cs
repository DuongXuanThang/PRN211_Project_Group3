using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuanLyShopBanHang.ModelsView
{
    public class RegisAccount
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập email")]
        [Display(Name = "Email")]
        [Remote(action: "ValidateEmail",controller:"Accounts")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập điện thoại")]
        [Display(Name = "điện thoại")]
        [Remote(action: "ValidatePhone", controller: "Accounts")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập lại mật khẩu")]
        [Compare("Password",ErrorMessage ="Vui lòng nhập mật khẩu giống nhau")]
        public string ConfirmPassword { get; set; }

    }
}
