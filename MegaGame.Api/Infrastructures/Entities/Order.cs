using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class Order
{
    public int Id { get; set; }

    public int? User { get; set; }

    public long TotalInCents { get; set; }

    public string? PaymentIntentId { get; set; }

    public string? CardBrand { get; set; }

    public string? CardLast4 { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
