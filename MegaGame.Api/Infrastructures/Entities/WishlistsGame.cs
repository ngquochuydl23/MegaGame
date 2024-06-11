using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class WishlistsGame
{
    public int Id { get; set; }

    public int? WishlistId { get; set; }

    public int? GameId { get; set; }
}
