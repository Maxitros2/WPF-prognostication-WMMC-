using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.Data.ProgData
{
    public class LocalConfigWorker
    {
        public static string local = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Local", "PNG");
        public static string localset = Path.Combine(local, "set.txt");
        public static string rep = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public static string repset = Path.Combine(rep,"set.txt");
        MainWindow mainWindow;
        public void tryGetUpdate(MainWindow mainWindow)
        {
            Directory.CreateDirectory(local);            
            this.mainWindow = mainWindow;
        }
    }
}
