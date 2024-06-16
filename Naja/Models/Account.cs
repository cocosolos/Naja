using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class Account
{
    public ICollection<Naja.Models.External.Char> Characters { get; set; } = new List<Naja.Models.External.Char>();
}
