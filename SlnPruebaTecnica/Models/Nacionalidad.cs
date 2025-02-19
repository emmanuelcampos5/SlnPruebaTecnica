using System;
using System.Collections.Generic;

namespace SlnPruebaTecnica.Models;

public partial class Nacionalidad
{
    public int IdNacionalidad { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
