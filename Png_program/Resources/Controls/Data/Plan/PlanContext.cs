using Png_program.Resources.Controls.Data.Plan;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.Data
{
    class PlanContext : DbContext
    {
        public PlanContext() : base("Data")
        {

        }
        public DbSet<PlanGGPZ> PlanGGPZ { get; set; }
        public DbSet<PlanMGPZ> PlanMGPZ { get; set; }
        public DbSet<PlanNGP> PlanNGP { get; set; }
        public DbSet<PlanYBGPZ> PlanYBGPZ { get; set; }
        public DbSet<PlanYPGPZ> PlanYPGPZ { get; set; }
        public DbSet<PlanVGPZ> PlanVGPZ { get; set; }
        public DbSet<PlanBGPK> PlanBGPK { get; set; }
        public DbSet<PlanNVGPK> PlanNVGPK { get; set; }
        

    }
}
