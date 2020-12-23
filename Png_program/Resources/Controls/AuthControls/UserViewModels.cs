using Png_program.Resources.Controls.MainTabControls;
using Png_program.Resources.Controls.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.AuthControls
{
    class UserViewModels : INotifyPropertyChanged
    {
        UserContext db;
        RelayCommand addCommand;
        RelayCommand editCommand;
        RelayCommand deleteCommand;
        IEnumerable<UserData> users;



        public IEnumerable<UserData> Users
        {
            get { return users; }
            set
            {
                users = value;
                OnPropertyChanged("Users");
            }
        }

        public IEnumerable<UserData> NormalUsers
        {
            get { return users.Where(x=>x.Type!= "Администратор"); }
            set
            {
                users= users.Concat(value).Distinct();;
                OnPropertyChanged("Users");
            }
        }

        public IEnumerable<UserData> Admins
        {
            get { return users.Where(x => x.Type == "Администратор"); }
            set
            {
                users = users.Concat(value).Distinct(); ;
                OnPropertyChanged("Users");
            }
        }
        public UserViewModels()
        {           
            db = new UserContext();
            db.UserDatas.Load();
            Users = db.UserDatas.Local.ToBindingList();


        }
        // команда добавления
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand((o) =>
                  {

                      UserEditWindow userEditWindow = new UserEditWindow(new UserData(),true);
                      if(userEditWindow.ShowDialog() == true)
                      {
                          UserData user = userEditWindow.CurrentUser;                                               
                          db.UserDatas.Add(user);
                          db.SaveChanges();
                          Users = db.UserDatas.Local.ToBindingList();
                      }

                  }));
            }
        }
        // команда редактирования
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand((selectedItem) =>
                  {

                      if (selectedItem == null) return;
                      // получаем выделенный объект
                      UserData user = selectedItem as UserData;

                      UserData vm = new UserData()
                      {
                          ID = user.ID,
                          Name1 = user.Name1,
                          Name2 = user.Name2,
                          Name3 = user.Name3,
                          UserName = user.UserName,
                          Password = user.Password,
                          Permissions = user.Permissions,
                          Type = user.Type

                      };
                      UserEditWindow userWindow = new UserEditWindow(vm);                      

                      if (userWindow.ShowDialog() == true)
                      {
                          // получаем измененный объект
                          user = db.UserDatas.Find(userWindow.CurrentUser.ID);
                          if (user != null)
                          {                             
                              user.Name1 = userWindow.CurrentUser.Name1;
                              user.Name2 = userWindow.CurrentUser.Name2;
                              user.Name3 = userWindow.CurrentUser.Name3;
                              user.UserName = userWindow.CurrentUser.UserName;
                              user.Password = userWindow.CurrentUser.Password;
                              user.Permissions = userWindow.CurrentUser.Permissions;
                              user.Type = userWindow.CurrentUser.Type;                              
                              db.Entry(user).State = EntityState.Modified;
                              db.SaveChanges();
                              Users = db.UserDatas.Local.ToBindingList();
                          }
                      }

                  }));

            }
        }
        // команда удаления
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand((selectedItem) =>
                  {
                      if (selectedItem == null) return;
                      // получаем выделенный объект
                      UserData user = selectedItem as UserData;
                      db.UserDatas.Remove(user);
                      db.SaveChanges();
                      Users = db.UserDatas.Local.ToBindingList().ToList();
                  }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }    
}
