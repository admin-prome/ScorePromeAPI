using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Ovale
{
    public ulong Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Dni { get; set; }

    public string Sexo { get; set; } = null!;

    public string? Actividad { get; set; }

    public string? Localidad { get; set; }

    public string? TipoTelefono { get; set; }

    public string? CodigoArea { get; set; }

    public string? Telefono { get; set; }

    public string? Mail { get; set; }

    public decimal Monto { get; set; }

    public decimal Cuota { get; set; }

    public string? HorarioLlamada { get; set; }

    public ulong ConsultaId { get; set; }

    public string? Crm { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Categoria { get; set; }

    public virtual Consulta Consulta { get; set; } = null!;
}
