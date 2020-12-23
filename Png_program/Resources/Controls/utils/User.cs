using Png_program.Resources.Controls.MainTabControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Png_program.Resources.Controls.utils
{
    public class User
    {
        public string Login;
        public string Name1;
        public string Name2;
        public string Name3;
        public string PassHash;
        public List<Permissons> UserPermissons;
        public static User ParseData(UserData userData)
        {
            User user = new User()
            {
                Login = userData.UserName,
                Name1 = userData.Name1,
                UserPermissons = userData.Permissions == null ? new List<Permissons>() : ParsePermission(userData.Permissions.Split(' '))
            };
            return user;
        }
        public static bool IsAdmin(UserData userData)
        {
            return userData.Type == "Администратор" ? true : false;
        }
        public static List<Permissons> ParsePermission(string[] permissions)
        {
            if (permissions == null)
                return new List<Permissons>();
            List<Permissons> ret = new List<Permissons>();
            foreach (string prem in permissions)
                if (Enum.GetNames(typeof(Permissons)).Contains(prem))
                    ret.Add((Permissons)Enum.Parse(typeof(Permissons), prem));
            //MessageBox.Show(ret.Count + "");
            return ret;
        }
    
    }
}
