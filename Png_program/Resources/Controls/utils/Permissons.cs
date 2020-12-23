using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.utils
{
    public enum Permissons 
    {
        ГГПЗ, 
        МГПЗ, 
        ВГПЗ, 
        НВГПЗ, 
        БГПЗ, 
        ЮБГПЗ, 
        НГП, 
        ЮПГПЗ, 
        ХКС, 
        ТКС, 
        ВяКС, 
        БКС, 
        ВарКС,
        ВГПП,
        НягГП,
        БГПК,
        НВГПК
    }

    public static class PermissionHelper
    {
        public static Dictionary<Permissons, string> NamedPermissions = new Dictionary<Permissons, string>()
        {
            
            
            {Permissons.ГГПЗ,"Доступ к ГГПЗ"},
            {Permissons.МГПЗ,"Доступ к МГПЗ"},
            {Permissons.ВГПЗ,"Доступ к ВГПЗ"},
            {Permissons.НВГПЗ,"Доступ к НВГПЗ"},
            {Permissons.БГПЗ,"Доступ к БГПЗ"},
            {Permissons.ЮБГПЗ,"Доступ к ЮБГПЗ"},
            {Permissons.НГП,"Доступ к НГП"},
            {Permissons.ЮПГПЗ,"Доступ к ЮПГПЗ"},
            {Permissons.ХКС,"Доступ к ХКС"},
            {Permissons.ТКС,"Доступ к ТКС"},
            {Permissons.ВяКС,"Доступ к ВяКС"},
            {Permissons.БКС,"Доступ к БКС"},
            {Permissons.ВарКС,"Доступ к ВарКС"},
            {Permissons.ВГПП,"Доступ к ГГПЗ"},
            {Permissons.НягГП,"Доступ к НягГП"},
            {Permissons.БГПК,"Доступ к БГПК"},
            {Permissons.НВГПК,"Доступ к НВГПК"}
        };
    }
}
