using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class RecommendedsComponent
{
    public int Id { get; set; }

    public string Field { get; set; } = null!;

    public int Order { get; set; }

    public string ComponentType { get; set; } = null!;

    public int ComponentId { get; set; }

    public int RecommendedId { get; set; }
}
