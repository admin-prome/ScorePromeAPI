using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Veraz
{
    public ulong Id { get; set; }

    public string Xml { get; set; } = null!;

    public double Cuota { get; set; }

    public string Categoria { get; set; } = null!;

    public int Documento { get; set; }

    public string Nombre { get; set; } = null!;

    public double Oferta { get; set; }

    public double PrestamoMaximo { get; set; }

    public string Sexo { get; set; } = null!;

    public string Visita { get; set; } = null!;

    public string Html { get; set; } = null!;

    public string? PathPdf { get; set; }

    public string? PathHtml { get; set; }

    public ulong ConsultaId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Consulta Consulta { get; set; } = null!;
}
