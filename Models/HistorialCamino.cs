using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class HistorialCamino
{
    public ulong Id { get; set; }

    public string Data { get; set; } = null!;

    public ulong CaminoId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Camino Camino { get; set; } = null!;

    public virtual ICollection<ConsultasHistorialCamino> ConsultasHistorialCaminos { get; set; } = new List<ConsultasHistorialCamino>();
}
