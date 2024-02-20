using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Accione
{
    public ulong Id { get; set; }

    public string Accion { get; set; } = null!;

    public virtual ICollection<Auditoria> Auditoria { get; set; } = new List<Auditoria>();
}
