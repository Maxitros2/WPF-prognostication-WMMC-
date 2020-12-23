using Png_program.Resources.Controls.MainTabControls;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.AuthControls
{
    class UserContext : DbContext
    {
        public UserContext() : base("Users")
        {

        }
        public DbSet<UserData> UserDatas { get; set; }
    }
}
