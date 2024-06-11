using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class PlatformsGamesLink
{
    public int? PlatformId { get; set; }

    public int? GameId { get; set; }
}
