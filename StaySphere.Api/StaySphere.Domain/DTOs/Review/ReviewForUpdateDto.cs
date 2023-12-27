﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaySphere.Domain.DTOs.Review
{
    public record ReviewForUpdateDto(
        int Id,
        int BookingId,
        string Comment);
    
}
