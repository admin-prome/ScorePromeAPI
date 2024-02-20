using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Consulta
{
    public ulong Id { get; set; }

    public string Path { get; set; } = null!;

    public ulong SolicitanteId { get; set; }

    public ulong OrigenId { get; set; }

    public ulong? StatusId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Cda { get; set; }

    public ulong? IdListaCda { get; set; }

    public string? Manager { get; set; }

    public string? EstadoManager { get; set; }

    public string? Ticket { get; set; }

    public string? Veraz { get; set; }

    public virtual ICollection<ConsultasHistorialCamino> ConsultasHistorialCaminos { get; set; } = new List<ConsultasHistorialCamino>();

    public virtual Origene Origen { get; set; } = null!;

    public virtual ICollection<Ovale> Ovales { get; set; } = new List<Ovale>();

    public virtual ICollection<Resultado> Resultados { get; set; } = new List<Resultado>();

    public virtual Solicitante Solicitante { get; set; } = null!;

    public virtual Status? Status { get; set; }

    public virtual ICollection<Veraz> Verazs { get; set; } = new List<Veraz>();
}
