using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class ConsultasHistorialCamino
{
    public ulong Id { get; set; }

    public ulong HistorialCaminoId { get; set; }

    public ulong ConsultaId { get; set; }

    public virtual Consulta Consulta { get; set; } = null!;

    public virtual HistorialCamino HistorialCamino { get; set; } = null!;
}
