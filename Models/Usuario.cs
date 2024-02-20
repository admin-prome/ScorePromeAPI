using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Usuario
{
    public ulong Id { get; set; }

    public string Name { get; set; } = null!;

    public int Dni { get; set; }

    public string Email { get; set; } = null!;

    public bool Activo { get; set; }

    public DateTime? EmailVerifiedAt { get; set; }

    public string Password { get; set; } = null!;

    public ulong RoleId { get; set; }

    public string? RememberToken { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Auditoria> AuditoriaUsuarioEdits { get; set; } = new List<Auditoria>();

    public virtual ICollection<Auditoria> AuditoriaUsuarios { get; set; } = new List<Auditoria>();

    public virtual Role Role { get; set; } = null!;
}
