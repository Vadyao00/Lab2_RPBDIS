﻿using System;
using System.Collections.Generic;

namespace Lab2.Models;

public partial class Actor
{
    public Guid ActorId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
