using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class GamesDevelopersLink
{
    public int? GameId { get; set; }

    public int? DeveloperId { get; set; }
}
