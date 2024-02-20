using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Morosos90
{
    public ulong Id { get; set; }

    public int? Documento { get; set; }

    public int? MaxDiasAtr { get; set; }

    public int? TmcmMeses { get; set; }

    public DateOnly FechaProceso { get; set; }
}
