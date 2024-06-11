using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class UpUser
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Provider { get; set; }

    public string? Password { get; set; }

    public string? ResetPasswordToken { get; set; }

    public string? ConfirmationToken { get; set; }

    public bool? Confirmed { get; set; }

    public bool? Blocked { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CreatedById { get; set; }

    public int? UpdatedById { get; set; }
}
