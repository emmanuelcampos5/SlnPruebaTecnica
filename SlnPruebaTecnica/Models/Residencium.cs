using System;
using System.Collections.Generic;

namespace SlnPruebaTecnica.Models;

public partial class Residencium
{
    public int IdResidencia { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
