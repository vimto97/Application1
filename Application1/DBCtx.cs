
using Application1.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Application1
{
    public class DBCtx : System.Data.Entity.DbContext
    {
        public DBCtx(DbContextOptions<DBCtx> options) : base(options)
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<Devices> Device { get; set; }
    }
}
