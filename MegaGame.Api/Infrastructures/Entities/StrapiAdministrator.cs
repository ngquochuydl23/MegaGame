using System;
using System.Collections.Generic;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class StrapiAdministrator
{
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Username { get; set; }

    public string Email { get; set; } = null!;

    public string? Password { get; set; }

    public string? ResetPasswordToken { get; set; }

    public string? RegistrationToken { get; set; }

    public bool? IsActive { get; set; }

    public bool? Blocked { get; set; }

    public string? PreferedLanguage { get; set; }
}
