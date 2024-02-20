using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class RefinanciacionMenos2Anio
{
    public ulong Id { get; set; }

    public int? Documento { get; set; }

    public int? Solicitud { get; set; }

    public string? Tipo { get; set; }

    public string? Subtipo { get; set; }
}
