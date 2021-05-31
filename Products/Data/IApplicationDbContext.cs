﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Entities.Product> Products { get; set; }
        Task<int> SaveChanges();
    }
}
