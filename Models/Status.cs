using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Status
{
    public ulong Id { get; set; }

    public string Nombre { get; set; } = null!;

    public bool ActivoConsulta { get; set; }

    public virtual ICollection<Consulta> Consulta { get; set; } = new List<Consulta>();

    public virtual ICollection<Mensaje> Mensajes { get; set; } = new List<Mensaje>();

    public virtual ICollection<Resultado> Resultados { get; set; } = new List<Resultado>();
}
