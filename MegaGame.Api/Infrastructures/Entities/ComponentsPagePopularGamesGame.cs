using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class ComponentsPagePopularGamesGame
{
    public int Id { get; set; }

    public int? ComponentsPagePopularGameId { get; set; }

    public int? GameId { get; set; }
}
