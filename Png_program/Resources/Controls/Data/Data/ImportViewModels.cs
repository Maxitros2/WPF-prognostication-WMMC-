using Png_program.Resources.Controls.Data;
using Png_program.Resources.Controls.Data.DataItem;
using Png_program.Resources.Controls.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Png_program.Resources.Controls.MainTabControls
{

    public class ImportViewModels : INotifyPropertyChanged
    {
        string filter1 = "РН-Юганскнефтегаз Славнефть-Нижневартовск Газпромнефть-Хантос АО Ямалкоммунэнерго Ноябрьскнефтегаз";
        string filter2 = "Топливо на технологию Топливо на котельную СОГ местным потребителям СОГ " +
            "продажа ЯКЭ Коэффициент осадок на жидкие Норматив потерь Целевые в ПНГ СОГ " +
            "производство ЯКЭ Сжигание СОГ на УР ШФЛУ производство ЯКЭ Производство ПТ Производство ШФЛУ";
        ImportContext db;
        RelayCommand addCommand;
        RelayCommand editCommand;
        RelayCommand deleteCommand;
        IEnumerable<ImportData> import;
        Permissons[] type;
        DateTime firstDate;
        DateTime endDate;
        bool isnews;
        Dictionary<ImportData, IEnumerable<DataItem>> importContexts = new Dictionary<ImportData, IEnumerable<DataItem>>();
        Dictionary<ImportData, DataContext> pimportContexts = new Dictionary<ImportData, DataContext>();
        IEnumerable<DataItem>[] importDatas;

        public IEnumerable<DataItem>[] ImportDatas
        {
            get { return importDatas; }
            set
            {
                importDatas = value;
                OnPropertyChanged("ImportDatas");
            }
        }

        public IEnumerable<ImportData> Import
        {
            get { return import; }
            set
            {
                import = value;
                OnPropertyChanged("Import");
            }
        }
        public Dictionary<ImportData, IEnumerable<DataItem>> ImportContexts
        {
            get { return importContexts; }
            set
            {
                importContexts = value;
                OnPropertyChanged("ImportContexts");
            }
        }

        

        public static bool Between(DateTime input, DateTime date1, DateTime date2)
        {
            return (input >= date1 && input <= date2);
        }

        public ImportViewModels(Permissons[] type, DateTime start, DateTime end, bool filtered)
        {
            if (start == null || end ==null)
                return;
            firstDate = start;
            endDate = end;
            this.type = type;           
            db = new ImportContext();            
            db.ImportDatas.Load();           
            foreach (Permissons perm in type)
            {
                List<ImportData> importData;
                if (filtered)
                    importData = db.ImportDatas.Local.ToBindingList().Where(x => (!filter2.Contains(x.Data1)) 
                    &&(x.Factory == Enum.GetName(typeof(Permissons), perm))).ToList();
                else
                    importData = db.ImportDatas.Local.ToBindingList().Where(x => (!filter1.Contains(x.Data1))
                    && x.Factory == Enum.GetName(typeof(Permissons),perm)).ToList();
                for (int i = 0; i < importData.Count; i++)
                {
                    try
                    {
                        db.Database.ExecuteSqlCommand(String.Format("CREATE TABLE IF NOT EXISTS \"{0}\"" +
                            "(\"ID\" INTEGER NOT NULL, " +
                            "\"Date\" TEXT, \"DValue\" TEXT, " +
                            "PRIMARY KEY(\"ID\" AUTOINCREMENT));",
                            "data_" + Enum.GetName(typeof(Permissons), perm) 
                            + "_" 
                            + string.Concat(importData.ElementAt(i).Data1.Replace('.', '_').Where(c => !char.IsWhiteSpace(c)))));
                        DataContext context = new DataContext("data_" + Enum.GetName(typeof(Permissons), perm) 
                            + "_" 
                            + string.Concat(importData.ElementAt(i).Data1.Replace('.', '_').Where(c => !char.IsWhiteSpace(c))));
                        context.Data.Load();
                        
                        
                        List<DataItem> datas = context.Data.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), start, end)).ToList();
                        for (int n = 0; n < ((end.Year - start.Year) * 12) + end.Month - start.Month+1; n++)
                        {
                            if (!datas.Any(x => DateTime.Parse(x.Date) == start.AddMonths(n)))
                            {
                                context.Data.Add(new DataItem() { Date = start.AddMonths(n).ToLongDateString() });
                            }
                        }
                        context.SaveChanges();
                        string name = (context as IObjectContextAdapter).ObjectContext.CreateObjectSet<DataItem>().EntitySet.Name;
                        //MessageBox.Show()
                        importContexts.Add(importData.ElementAt(i), context.Data.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), start, end)).ToList());
                        pimportContexts.Add(importData.ElementAt(i), context);
                    }
                    catch(Exception e)
                    {
                       
                    }
                    
                }
            }               
            db.SaveChanges();            
        }

        

        // команда добавления
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand((o) =>
                  {
                   
                      /*
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
                      */
                      
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
                      DataItem data = selectedItem as DataItem;                      
                      ImportData plan = importContexts.Where(x=>x.Value.Contains(data)).First().Key;
                     

                          DataItem plan2 = pimportContexts[plan].Data.Find(data.ID);                         
                          pimportContexts[plan].Entry(plan2).State = EntityState.Modified;
                          pimportContexts[plan].SaveChanges();
                          
                     
                      
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
                      /*
                      if (selectedItem == null) return;
                      // получаем выделенный объект
                      NewsData news = selectedItem as NewsData;
                      db.NewsDatas.Remove(news);
                      db.SaveChanges();
                      News = db.NewsDatas.Local.ToBindingList().Where(x => x.Type == (isnews ? 0 : 1)).ToList();
                      */
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
