using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class MotorpromeResult
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Sexo { get; set; }

    public int? Dni { get; set; }

    public string? Status { get; set; }

    public int? ConsultaId { get; set; }

    public string? Mensaje { get; set; }

    public string? MensajeMail { get; set; }

    public string? Motivo { get; set; }

    public int? PrestamoMaximo { get; set; }

    public int? Oferta { get; set; }

    public string? Visita { get; set; }

    public int? Cuota { get; set; }

    public string? Message { get; set; }

    public string? CampaignFile { get; set; }

    public int Code { get; set; }

    public DateTime CreatedOn { get; set; }
}
