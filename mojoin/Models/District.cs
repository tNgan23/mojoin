﻿using System;
using System.Collections.Generic;

namespace mojoin.Models;

public partial class District
{
    public int DistrictId { get; set; }

    public string? DistrictName { get; set; }

    public int? CityId { get; set; }

    public virtual City? City { get; set; }

    public virtual ICollection<Ward> Wards { get; set; } = new List<Ward>();
}
