using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuanLyShopBanHang.ModelsView
{
    public class LoginViewModel
    {[Key]
    public int CustomerId { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập email")]
        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
    }
}
