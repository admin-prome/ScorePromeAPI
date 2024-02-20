using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Resultado
{
    public ulong Id { get; set; }

    public string Motivo { get; set; } = null!;

    public ulong StatusId { get; set; }

    public ulong ServicioId { get; set; }

    public ulong ConsultaId { get; set; }

    public ulong? ErrorId { get; set; }

    public string? Valor { get; set; }

    public virtual Consulta Consulta { get; set; } = null!;

    public virtual Error? Error { get; set; }

    public virtual Servicio Servicio { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
