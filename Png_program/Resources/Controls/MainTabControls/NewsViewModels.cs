using Png_program.Resources.Controls.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Png_program.Resources.Controls.MainTabControls
{
    public class NewsViewModels : INotifyPropertyChanged
    {
        NewsContext db;
        RelayCommand addCommand;
        RelayCommand editCommand;
        RelayCommand deleteCommand;
        IEnumerable<NewsData> news;
        bool isnews;

        public IEnumerable<NewsData> News
        {
            get { return news; }
            set
            {
                news = value;
                OnPropertyChanged("News");
            }
        }

        public NewsViewModels(bool isNews)
        {
            isnews = isNews;
            db = new NewsContext();            
            db.NewsDatas.Load();
            News = db.NewsDatas.Local.ToBindingList().Where(x => x.Type == (isnews ? 0 : 1)).ToList();
          
            
        }
        // команда добавления
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand((o) =>
                  {
                      
                      NewsEditWindow newsWindow = new NewsEditWindow(new NewsData());
                      if (newsWindow.ShowDialog() == true)
                      {
                          NewsData news = newsWindow.News;
                          news.Checked = (bool)newsWindow.NewsCheckbox.IsChecked ? 1 : 0;
                          news.Date = DateTranslater.GetDateString(DateTime.Now)[0];
                          if ((bool)o)
                              news.Type = 0;
                          else
                              news.Type = 1;                          
                          db.NewsDatas.Add(news);                          
                          db.SaveChanges();
                          News = db.NewsDatas.Local.ToBindingList().Where(x => x.Type == (isnews ? 0 : 1)).ToList();
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
                      NewsData news = selectedItem as NewsData;

                      NewsData vm = new NewsData()
                      {
                          ID = news.ID,
                          Title = news.Title,
                          Text = news.Text,
                          Date = news.Date,
                          Checked = news.Checked,
                          Type = news.Type
                          
                      };
                      NewsEditWindow newsWindow = new NewsEditWindow(vm);
                      newsWindow.NewsCheckbox.IsChecked = vm.Checked==1 ? true : false;

                      if (newsWindow.ShowDialog() == true)
                      {
                          // получаем измененный объект
                          news = db.NewsDatas.Find(newsWindow.News.ID);
                          if (news != null)
                          {
                              news.Title = newsWindow.News.Title;
                              news.Text = newsWindow.News.Text;
                              news.Date = newsWindow.News.Date;
                              news.Checked = (bool)newsWindow.NewsCheckbox.IsChecked ? 1 : 0;
                              news.Type = newsWindow.News.Type;
                              db.Entry(news).State = EntityState.Modified;
                              db.SaveChanges();

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
                      NewsData news = selectedItem as NewsData;
                      db.NewsDatas.Remove(news);
                      db.SaveChanges();
                      News = db.NewsDatas.Local.ToBindingList().Where(x => x.Type == (isnews ? 0 : 1)).ToList();
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
