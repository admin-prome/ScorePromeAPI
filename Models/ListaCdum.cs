using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class ListaCdum
{
    public ulong Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Cda { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
