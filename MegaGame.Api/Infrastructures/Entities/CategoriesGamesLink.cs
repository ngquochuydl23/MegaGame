using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class CategoriesGamesLink
{
    public int? CategoryId { get; set; }

    public int? GameId { get; set; }
}
