using System;
using System.Collections.Generic;

namespace ClothingStore.Models;

public partial class DiscountCoupon
{
    public int CouponId { get; set; }

    public string Code { get; set; } = null!;

    public decimal? DiscountPercent { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
