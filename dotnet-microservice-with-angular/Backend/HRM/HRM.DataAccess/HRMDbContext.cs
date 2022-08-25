using HRM.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DataAccess
{
    public class HRMDbContext: DbContext
    {
        public HRMDbContext(DbContextOptions<HRMDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Payments { get; set; }
    }
}
