using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Error
{
    public ulong Id { get; set; }

    public string Error1 { get; set; } = null!;

    public virtual ICollection<Resultado> Resultados { get; set; } = new List<Resultado>();
}
