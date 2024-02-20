using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class SmvmMinMax
{
    public ulong Id { get; set; }

    public string Bancarizado { get; set; } = null!;

    public int ScoreMin { get; set; }

    public int ScoreMax { get; set; }

    public double NSmvmMin { get; set; }

    public double NSmvmMax { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
