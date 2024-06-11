using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class OrdersGame
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? GameId { get; set; }
}
