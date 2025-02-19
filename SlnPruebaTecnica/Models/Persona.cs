using System;
using System.Collections.Generic;

namespace SlnPruebaTecnica.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateOnly? FechaNacimiento { get; set; }

    public int? IdResidencia { get; set; }

    public int? IdNacionalidad { get; set; }

    public virtual Nacionalidad? IdNacionalidadNavigation { get; set; }

    public virtual Residencium? IdResidenciaNavigation { get; set; }
}
