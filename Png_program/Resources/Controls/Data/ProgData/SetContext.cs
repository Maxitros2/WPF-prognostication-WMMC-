using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.Data.ProgData
{
    public class SetContext : DbContext
    {
        public SetContext() : base("Settings")
        {

        }
        public DbSet<SetData> SetDatas { get; set; }
    }
}
