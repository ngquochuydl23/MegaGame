using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class ComponentsPageRibbon
{
    public int Id { get; set; }

    public string? Text { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }
}
