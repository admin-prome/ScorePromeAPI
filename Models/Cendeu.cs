using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Cendeu
{
    public ulong Id { get; set; }

    public int? Documento { get; set; }

    public int? FechaInformacion { get; set; }

    public short? Situacion { get; set; }
}
