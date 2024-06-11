using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class GamesPlatformsLink
{
    public int? GameId { get; set; }

    public int? PlatformId { get; set; }
}
