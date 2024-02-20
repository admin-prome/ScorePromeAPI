using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Mensaje
{
    public ulong Id { get; set; }

    public string Mensaje1 { get; set; } = null!;

    public string MensajeMail { get; set; } = null!;

    public ulong OrigenId { get; set; }

    public ulong? MotivoId { get; set; }

    public ulong StatusId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Motivo? Motivo { get; set; }

    public virtual Origene Origen { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
