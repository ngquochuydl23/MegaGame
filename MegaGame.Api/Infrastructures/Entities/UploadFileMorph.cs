using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class UploadFileMorph
{
    public int Id { get; set; }

    public int? UploadFileId { get; set; }

    public int? RelatedId { get; set; }

    public string? RelatedType { get; set; }

    public string? Field { get; set; }

    public int? Order { get; set; }
}
