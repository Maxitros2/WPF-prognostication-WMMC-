using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.MainTabControls
{
    class NewsContext : DbContext
    {
        public NewsContext() : base("NewsTab")
        {
           
        }
        public DbSet<NewsData> NewsDatas { get; set; }
    }
}
