using System;
using System.Collections.Generic;

namespace asp_lez02_EF_libreria.Models;

public partial class Libro
{
    public int LibroId { get; set; }

    public string? Codice { get; set; } = null!;

    public string Titolo { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string? Autore { get; set; }

    public decimal Prezzo { get; set; }

    public int? Quantita { get; set; }
}
