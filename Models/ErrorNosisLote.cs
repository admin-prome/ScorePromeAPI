using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class ErrorNosisLote
{
    public ulong Id { get; set; }

    public ulong IdNosisLote { get; set; }

    public string Estado { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Sexo { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string Novedad { get; set; } = null!;

    public string Transaccion { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual NosisLote IdNosisLoteNavigation { get; set; } = null!;
}
