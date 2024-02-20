using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class ServiciosCamino
{
    public ulong Id { get; set; }

    public int Orden { get; set; }

    public bool Activo { get; set; }

    public bool Bloqueante { get; set; }

    public ulong ServicioId { get; set; }

    public ulong CaminoId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Camino Camino { get; set; } = null!;

    public virtual Servicio Servicio { get; set; } = null!;
}
