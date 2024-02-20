using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class WpClientesPotenciale
{
    public string InstanceId { get; set; } = null!;

    public string ClienteId { get; set; } = null!;

    public string ClienteNombre { get; set; } = null!;

    public string ClienteApellido { get; set; } = null!;

    public string ClienteSexo { get; set; } = null!;

    public string ClienteDni { get; set; } = null!;

    public string ClienteTelefonoTipo { get; set; } = null!;

    public string ClienteTelefonoCodigo { get; set; } = null!;

    public string ClienteTelefonoNumero { get; set; } = null!;

    public string ClienteEmail { get; set; } = null!;

    public string ClienteDedicacion { get; set; } = null!;

    public string ClienteTiempo { get; set; } = null!;

    public string ClienteTelAlternativoTipo { get; set; } = null!;

    public string ClienteTelAlternativoCodigo { get; set; } = null!;

    public string ClienteTelAlternativoNumero { get; set; } = null!;

    public string ClienteUbicacionLocalBarrio { get; set; } = null!;

    public string ClienteFechaAlta { get; set; } = null!;

    public string ClienteLocalidad { get; set; } = null!;
}
