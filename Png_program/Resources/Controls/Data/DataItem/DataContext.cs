using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Png_program.Resources.Controls.Data.DataItem
{
    public class DataContext : DbContext, IDbModelCacheKeyProvider
    {
        string name;
        public DataContext(string name) : base("Data")
        {
            this.name = name;
        }
        public DbSet<DataItem> Data { get; set; }

        public string CacheKey { get { return name.ToString(); } }

    protected override void OnModelCreating(DbModelBuilder builder)
        {
            //MessageBox.Show(name);
            builder.Entity<DataItem>().ToTable(name);   


        }
    }
}
