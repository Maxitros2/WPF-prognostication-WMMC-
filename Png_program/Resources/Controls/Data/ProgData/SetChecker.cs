using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;

namespace Png_program.Resources.Controls.Data.ProgData
{
    public class SetChecker : INotifyPropertyChanged
    {
        MainWindow mainWindow;
        SetContext context;
        ProgSet set;
        public SetChecker(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;            
        }
        public void RunSync()
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                context.SetDatas.Load();
                string data = context.Database.SqlQuery<SetData>("SELECT * FROM \"SetDatas\"").First().Data;
                if (JsonConvert.SerializeObject(set) == data) 
                    Thread.Sleep(10000);
                else
                {
                  
                    mainWindow.Dispatcher.Invoke(new Action(() =>
                    {
                        
                        mainWindow.needupdatever = true;
                        mainWindow.ProgSet = JsonConvert.DeserializeObject<ProgSet>(data);
                        set = JsonConvert.DeserializeObject<ProgSet>(data);
                        mainWindow.needupdatever = false;
                    }));
                }
            }
                
               
        }
        public void SaveConfig(ProgSet set)
        {
            context.SetDatas.First().Data = JsonConvert.SerializeObject(set);
            context.SaveChanges();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void Init()
        {
            context = new SetContext();
            string data = context.Database.SqlQuery<SetData>("SELECT * FROM \"SetDatas\"").First().Data;
            mainWindow.ProgSet = JsonConvert.DeserializeObject<ProgSet>(data);
            mainWindow.needupdatever = false;
            set= JsonConvert.DeserializeObject<ProgSet>(data); 
        }
    }
}
