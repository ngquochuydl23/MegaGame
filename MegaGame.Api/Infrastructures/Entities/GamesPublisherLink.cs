using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class GamesPublisherLink
{
    public int? GameId { get; set; }

    public int? PublisherId { get; set; }
}
