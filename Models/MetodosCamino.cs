using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class MetodosCamino
{
    public bool Final { get; set; }

    public ulong CaminoId { get; set; }

    public ulong ServicioId { get; set; }

    public ulong MetodoId { get; set; }

    public ulong StatusId { get; set; }

    public virtual Camino Camino { get; set; } = null!;

    public virtual Metodo Metodo { get; set; } = null!;

    public virtual Servicio Servicio { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
