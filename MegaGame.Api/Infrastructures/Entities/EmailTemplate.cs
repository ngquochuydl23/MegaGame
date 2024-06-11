using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class EmailTemplate
{
    public int Id { get; set; }

    public string? Design { get; set; }

    public string? Name { get; set; }

    public string? Subject { get; set; }

    public string? BodyHtml { get; set; }

    public string? BodyText { get; set; }

    public bool? Enabled { get; set; }

    public string? Tags { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
