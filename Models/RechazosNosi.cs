using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class RechazosNosi
{
    public ulong Id { get; set; }

    public int? Documento { get; set; }

    public string? Nombre { get; set; }

    public int? PeriodoConsulta { get; set; }

    public int? PeriodoCampaña { get; set; }

    public int? DocumentoAfip { get; set; }

    public string? RazonSocialAfip { get; set; }

    public double? ScoreNosis { get; set; }

    public bool? EsBancarizado { get; set; }

    public string? ActividadSector { get; set; }

    public double? QChequesRechazados { get; set; }

    public double? QChequesSinPagoMulta { get; set; }

    public double? Periodo24 { get; set; }

    public double? Periodo23 { get; set; }

    public double? Periodo22 { get; set; }

    public double? Periodo21 { get; set; }

    public double? Periodo20 { get; set; }

    public double? Periodo19 { get; set; }

    public double? Periodo18 { get; set; }

    public double? Periodo17 { get; set; }

    public double? Periodo16 { get; set; }

    public double? Periodo15 { get; set; }

    public double? Periodo14 { get; set; }

    public double? Periodo13 { get; set; }

    public double? Periodo12 { get; set; }

    public double? Periodo11 { get; set; }

    public double? Periodo10 { get; set; }

    public double? Periodo9 { get; set; }

    public double? Periodo8 { get; set; }

    public double? Periodo7 { get; set; }

    public double? Periodo6 { get; set; }

    public double? Periodo5 { get; set; }

    public double? Periodo4 { get; set; }

    public double? Periodo3 { get; set; }

    public double? Periodo2 { get; set; }

    public double? Periodo1 { get; set; }

    public string Ult2Meses { get; set; } = null!;

    public string QCheques { get; set; } = null!;
}
