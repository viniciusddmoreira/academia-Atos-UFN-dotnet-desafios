using System;
using System.Collections.Generic;

namespace EntityFrameworkDatabaseFirst;

public partial class Pessoa
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Email> Emails { get; } = new List<Email>();
}
