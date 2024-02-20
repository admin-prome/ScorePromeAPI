using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class ScoresComportamiento
{
    public ulong Id { get; set; }

    public int? Documento { get; set; }

    public DateOnly? MesPivot { get; set; }

    public DateOnly? MinFechaOtorgamiento { get; set; }

    public short? PlazoT { get; set; }

    public decimal? AvancePromedioPonderada { get; set; }

    public short? PorcPlazoPonderado3 { get; set; }

    public short? M0 { get; set; }

    public short? MesesAntiguedadL4 { get; set; }

    public decimal? Cuota { get; set; }

    public decimal? SaldoMedioCah { get; set; }

    public decimal? SaldoFinalCah { get; set; }

    public short? CantTdaL4m { get; set; }

    public short? VecesTmvNotmcL4m3 { get; set; }

    public short? MaxDiasAtraM42 { get; set; }

    public short? PropCuotaCahSm2 { get; set; }

    public string? EstadoCivil { get; set; }

    public short? MesesAntCliente3 { get; set; }

    public short? ScoreExcl { get; set; }

    public decimal? Score { get; set; }

    public string? NivelRiesgo { get; set; }

    public decimal? TempPondPorcAvance { get; set; }
}
