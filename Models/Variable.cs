using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Variable
{
    public ulong Id { get; set; }

    public string Variable1 { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public ulong ServicioId { get; set; }

    public virtual Servicio Servicio { get; set; } = null!;

    public virtual ICollection<VariablesCamino> VariablesCaminos { get; set; } = new List<VariablesCamino>();
}
