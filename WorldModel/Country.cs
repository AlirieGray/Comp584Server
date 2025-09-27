using System;
using System.Collections.Generic;

namespace WorldModel;

public partial class Country
{
    public int Id { get; set; }

    public string Iso2 { get; set; } = null!;

    public string Iso3 { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
