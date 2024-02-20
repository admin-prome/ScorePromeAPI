using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Operadore
{
    public ulong Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
