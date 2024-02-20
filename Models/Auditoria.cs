using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class Auditoria
{
    public ulong Id { get; set; }

    public ulong UsuarioId { get; set; }

    public ulong AccionId { get; set; }

    public ulong? ServicioId { get; set; }

    public ulong? UsuarioEditId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Accione Accion { get; set; } = null!;

    public virtual Servicio? Servicio { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;

    public virtual Usuario? UsuarioEdit { get; set; }
}
