using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class GamesPlatformsPlatformsGame
{
    public int Id { get; set; }

    public int? GameId { get; set; }

    public int? PlatformId { get; set; }
}
