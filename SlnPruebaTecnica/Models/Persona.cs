using System;
using System.Collections.Generic;

namespace SlnPruebaTecnica.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public string Residencia { get; set; } = null!;

    public string Nacionalidad { get; set; } = null!;
}
