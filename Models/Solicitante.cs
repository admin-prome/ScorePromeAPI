using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Solicitante
{
    public ulong Id { get; set; }

    public int Dni { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Consulta> Consulta { get; set; } = new List<Consulta>();
}
