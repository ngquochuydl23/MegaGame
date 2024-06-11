using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class DevelopersGamesLink
{
    public int? DeveloperId { get; set; }

    public int? GameId { get; set; }
}
