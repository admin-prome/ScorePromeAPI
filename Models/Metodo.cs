using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Metodo
{
    public ulong Id { get; set; }

    public string Metodo1 { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
