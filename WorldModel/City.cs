using System;
using System.Collections.Generic;

namespace WorldModel;

public partial class City
{
    public int Id { get; set; }

    public int CountryId { get; set; }

    public string Name { get; set; } = null!;

    public int Population { get; set; }

    public double Lat { get; set; }

    public double Lng { get; set; }

    public virtual Country Country { get; set; } = null!;
}
