using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class MorososVigente
{
    public ulong Id { get; set; }

    public string? Zona { get; set; }

    public short? FilialBpba { get; set; }

    public int? FilialProme { get; set; }

    public string? Sucursal { get; set; }

    public int? DocEcEval { get; set; }

    public string? NombreEcEval { get; set; }

    public int? DocEcAdmin { get; set; }

    public string? NombreEcAdmin { get; set; }

    public int? DocEcAsigna { get; set; }

    public string? NombreEcAsigna { get; set; }

    public int? Solicitud { get; set; }

    public int? NroDocCliente { get; set; }

    public string? NombreCliente { get; set; }

    public string? TelefonoBpba { get; set; }

    public string? TelefonoCrm { get; set; }

    public decimal? SaldoCuenta { get; set; }

    public DateOnly? FechaUltimoMov { get; set; }

    public short? FechaCompromiso { get; set; }

    public DateOnly? FechaOtorgamiento { get; set; }

    public DateOnly? FechaApertura { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public short? CantidadCuotas { get; set; }

    public decimal? TotalCuota { get; set; }

    public decimal? DeudaExigible { get; set; }

    public short? DiasAtraso { get; set; }

    public DateOnly? FechaProxLiq { get; set; }

    public decimal? SaldoPrestamo { get; set; }

    public decimal? MontoOtorgado { get; set; }

    public short? Plazo { get; set; }

    public decimal? Tasa { get; set; }

    public decimal? DeudaCubierta { get; set; }

    public DateOnly? FechaVtaTarjeta { get; set; }

    public decimal? SaldoDeudaTarjeta { get; set; }

    public decimal? ImporteMinTarjeta { get; set; }

    public decimal? AcumPagosTarjeta { get; set; }

    public string? TipoCredito { get; set; }

    public string? SubTipoCredito { get; set; }

    public long? NroCtaSur { get; set; }

    public short? TipCtaSur { get; set; }
}
