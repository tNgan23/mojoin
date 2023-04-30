﻿using System;
using System.Collections.Generic;

namespace mojoin.Models;

public partial class User
{
    public int UserId { get; set; }

    public int RolesId { get; set; }

    public string? Fullname { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? Sex { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public string? Password { get; set; }

    public string? Avatar { get; set; }

    public bool? IsActive { get; set; }

    public string? InfoZalo { get; set; }

    public string? InfoFacebook { get; set; }

    public int? SupportUserId { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual Role Roles { get; set; } = null!;

    public virtual ICollection<RoomFavorite> RoomFavorites { get; set; } = new List<RoomFavorite>();

    public virtual ICollection<RoomRating> RoomRatings { get; set; } = new List<RoomRating>();

    public virtual ICollection<RoomReport> RoomReports { get; set; } = new List<RoomReport>();
}
