using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Role
{
    public ulong Id { get; set; }

    public string Role1 { get; set; } = null!;

    public virtual ICollection<Origene> Origenes { get; set; } = new List<Origene>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
