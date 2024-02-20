using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Dmp
{
    public ulong Id { get; set; }

    public string Bancarizado { get; set; } = null!;

    public int ScoreMin { get; set; }

    public int ScoreMax { get; set; }

    public int PorcentEndeudamiento { get; set; }
}
