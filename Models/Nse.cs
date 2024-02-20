using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Nse
{
    public ulong Id { get; set; }

    public string Nivel { get; set; } = null!;

    public double IngresoMin { get; set; }

    public bool? Habilitado { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public double? IngresoPromedio { get; set; }

    public double? IngresoMaximo { get; set; }
}
