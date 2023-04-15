﻿using System;
using System.Collections.Generic;

namespace mojoin.Models;

public partial class City
{
    public int CityId { get; set; }

    public string? CityName { get; set; }

    public virtual ICollection<District> Districts { get; set; } = new List<District>();
}
