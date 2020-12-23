using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.utils
{
    public interface ICloseable
    {
        void CloseToEdit();
        void SaveChanges();
        void OpenToEdit();
    }
}
