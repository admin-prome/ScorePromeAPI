using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Motivo
{
    public ulong Id { get; set; }

    public string Motivo1 { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Mensaje> Mensajes { get; set; } = new List<Mensaje>();
}
