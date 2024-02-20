using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Origene
{
    public ulong Id { get; set; }

    public string Origen { get; set; } = null!;

    public string Token { get; set; } = null!;

    public bool Activo { get; set; }

    public ulong RoleId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Camino> Caminos { get; set; } = new List<Camino>();

    public virtual ICollection<Consulta> Consulta { get; set; } = new List<Consulta>();

    public virtual ICollection<Mensaje> Mensajes { get; set; } = new List<Mensaje>();

    public virtual Role Role { get; set; } = null!;
}
