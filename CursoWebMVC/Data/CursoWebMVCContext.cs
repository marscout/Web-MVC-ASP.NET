﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoWebMVC.Models
{
    public class CursoWebMVCContext : DbContext
    {
        public CursoWebMVCContext (DbContextOptions<CursoWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SelesRecords{ get; set; }
    }
}
