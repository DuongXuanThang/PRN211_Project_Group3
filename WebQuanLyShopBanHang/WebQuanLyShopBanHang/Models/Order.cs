using System;
using System.Collections.Generic;

#nullable disable

namespace WebQuanLyShopBanHang.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool Deleted { get; set; }
        public int TotalMoney { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
