using Png_program.Resources.Controls.MainTabControls;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Png_program.Resources.DBs
{
    public class AppContexts
    {
        public static NewsViewModels NewsContext;

        public AppContexts()
        {
            NewsContext = new NewsViewModels(true);
        }
            
    }
}
