using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Servicio
{
    public ulong Id { get; set; }

    public string Servicio1 { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public virtual ICollection<Auditoria> Auditoria { get; set; } = new List<Auditoria>();

    public virtual ICollection<Resultado> Resultados { get; set; } = new List<Resultado>();

    public virtual ICollection<ServiciosCamino> ServiciosCaminos { get; set; } = new List<ServiciosCamino>();

    public virtual ICollection<Variable> Variables { get; set; } = new List<Variable>();
}
