using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Camino
{
    public ulong Id { get; set; }

    public string Camino1 { get; set; } = null!;

    public bool Default { get; set; }

    public bool Activo { get; set; }

    public ulong OrigenId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<HistorialCamino> HistorialCaminos { get; set; } = new List<HistorialCamino>();

    public virtual Origene Origen { get; set; } = null!;

    public virtual ICollection<ServiciosCamino> ServiciosCaminos { get; set; } = new List<ServiciosCamino>();

    public virtual ICollection<VariablesCamino> VariablesCaminos { get; set; } = new List<VariablesCamino>();
}
