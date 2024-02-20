using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class ConsultaNosi
{
    public ulong Id { get; set; }

    public string Dni { get; set; } = null!;

    public string Raw { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Sexo { get; set; }

    public ulong? IdNosisLote { get; set; }
}
