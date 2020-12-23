using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.Data
{
    public class ImportContext : DbContext
    {
        public ImportContext() : base("Data")
        {

        }
        public DbSet<ImportData> ImportDatas { get; set; }
        
    }
}
