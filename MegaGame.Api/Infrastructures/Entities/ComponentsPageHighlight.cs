using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class ComponentsPageHighlight
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? ButtonLabel { get; set; }

    public string? ButtonLink { get; set; }

    public string? Alignment { get; set; }
}
