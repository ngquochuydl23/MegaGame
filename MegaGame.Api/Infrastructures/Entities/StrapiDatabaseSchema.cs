using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class StrapiDatabaseSchema
{
    public int Id { get; set; }

    public string? Schema { get; set; }

    public DateTime? Time { get; set; }

    public string? Hash { get; set; }
}
