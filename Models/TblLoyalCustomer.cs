﻿using System;
using System.Collections.Generic;

namespace CapricciosaPizza.Models;
// class with reverse engineering
public partial class TblLoyalCustomer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }
}
