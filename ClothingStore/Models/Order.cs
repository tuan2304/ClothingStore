using System;
using System.Collections.Generic;

namespace ClothingStore.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? UserId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? CouponId { get; set; }

    public string? PaymentMethod { get; set; }

    public string? Status { get; set; }

    public virtual DiscountCoupon? Coupon { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual User? User { get; set; }
}
