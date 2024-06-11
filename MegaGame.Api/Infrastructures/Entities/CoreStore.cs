using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class CoreStore
{
    public int Id { get; set; }

    public string? Key { get; set; }

    public string? Value { get; set; }

    public string? Type { get; set; }

    public string? Environment { get; set; }

    public string? Tag { get; set; }
}
