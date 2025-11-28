using System;
using System.Collections.Generic;

namespace ClothingStore.Models;

public partial class Report
{
    public int ReportId { get; set; }

    public DateOnly? ReportDate { get; set; }

    public decimal? TotalRevenue { get; set; }
}
