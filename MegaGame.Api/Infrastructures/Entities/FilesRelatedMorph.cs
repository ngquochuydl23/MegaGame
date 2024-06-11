using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class FilesRelatedMorph
{
    public int? FileId { get; set; }

    public int? RelatedId { get; set; }

    public string? RelatedType { get; set; }

    public string? Field { get; set; }

    public int? Order { get; set; }
}
