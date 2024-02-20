using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class VariablesCamino
{
    public ulong Id { get; set; }

    public string Valor { get; set; } = null!;

    public string Activa { get; set; } = null!;

    public string? Operador { get; set; }

    public ulong CaminoId { get; set; }

    public ulong VariableId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Camino Camino { get; set; } = null!;

    public virtual Variable Variable { get; set; } = null!;
}
