using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class NosisLote
{
    public ulong Id { get; set; }

    public string Url { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Documento { get; set; }

    public virtual ICollection<ErrorNosisLote> ErrorNosisLotes { get; set; } = new List<ErrorNosisLote>();
}
