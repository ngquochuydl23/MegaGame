using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class GamesCategoriesLink
{
    public int? GameId { get; set; }

    public int? CategoryId { get; set; }
}
