using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class ListaDemandum
{
    public ulong Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
