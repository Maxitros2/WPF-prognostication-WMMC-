using Png_program.Resources.Controls.Data;
using Png_program.Resources.Controls.Data.Plan;
using Png_program.Resources.Controls.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Png_program.Resources.Controls.MainTabControls
{
    public class PlanViewModels : INotifyPropertyChanged
    {
        PlanContext db;
        RelayCommand addCommand;
        RelayCommand editCommand;
        RelayCommand deleteCommand;
        IEnumerable<PlanGGPZ> planGGPZ;
        IEnumerable<PlanNGP> planNGP;
        IEnumerable<PlanYPGPZ> planYPGPZ;
        IEnumerable<PlanYBGPZ> planYBGPZ;
        IEnumerable<PlanMGPZ> planMGPZ;
        IEnumerable<PlanVGPZ> planVGPZ;
        IEnumerable<PlanBGPK> planBGPK;
        IEnumerable<PlanNVGPK> planNVGPK;
        PlanType type;
        List<DateTime> dates;
        bool isnews;
        public IEnumerable<PlanVGPZ> PlanVGPZ
        {
            get { return planVGPZ; }
            set
            {
                planVGPZ = value;
                OnPropertyChanged("PlanVGPZ");
            }
        }
        public IEnumerable<PlanBGPK> PlanBGPK
        {
            get { return planBGPK; }
            set
            {
                planBGPK = value;
                OnPropertyChanged("PlanBGPK");
            }
        }
        public IEnumerable<PlanNVGPK> PlanNVGPK
        {
            get { return planNVGPK; }
            set
            {
                planNVGPK = value;
                OnPropertyChanged("PlanNVGPK");
            }
        }

        public IEnumerable<PlanGGPZ> PlanGGPZ
        {
            get { return planGGPZ; }
            set
            {
                planGGPZ = value;
                OnPropertyChanged("PlanGGPZ");
            }
        }
        public IEnumerable<PlanNGP> PlanNGP
        {
            get { return planNGP; }
            set
            {
                planNGP = value;
                OnPropertyChanged("PlanNGP");
            }
        }
        public IEnumerable<PlanYPGPZ> PlanYPGPZ
        {
            get { return planYPGPZ; }
            set
            {
                planYPGPZ = value;
                OnPropertyChanged("PlanYPGPZ");
            }
        }
        public IEnumerable<PlanYBGPZ> PlanYBGPZ
        {
            get { return planYBGPZ; }
            set
            {
                planYBGPZ = value;
                OnPropertyChanged("PlanYBGPZ");
            }
        }
        public IEnumerable<PlanMGPZ> PlanMGPZ
        {
            get { return planMGPZ; }
            set
            {
                planMGPZ = value;
                OnPropertyChanged("PlanMGPZ");
            }
        }
        public static bool Between(DateTime input, DateTime date1, DateTime date2)
        {
            return (input >= date1 && input <= date2);
        }
        DbSet selected = null;
        public PlanViewModels(PlanType type, List<DateTime> dates)
        {
            if (dates == null)
                return;
            this.type = type;
            this.dates = dates;
            db = new PlanContext();
            switch (type)
            {
                case PlanType.ГГПЗ:
                    db.PlanGGPZ.Load();
                    {
                        List<PlanGGPZ> planDatas = db.PlanGGPZ.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                        foreach (DateTime dateTime in dates)
                        {
                            if (!planDatas.Any(x => DateTime.Parse(x.Date) == dateTime))
                            {
                                db.PlanGGPZ.Add(new PlanGGPZ() { Date = dateTime.ToLongDateString() });
                            }
                        }
                    }
                    db.SaveChanges();
                    PlanGGPZ = db.PlanGGPZ.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                    break;
                case PlanType.НГП:
                    db.PlanNGP.Load();
                    {
                        List<PlanNGP> planDatas = db.PlanNGP.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                        foreach (DateTime dateTime in dates)
                        {
                            if (!planDatas.Any(x => DateTime.Parse(x.Date) == dateTime))
                            {
                                db.PlanNGP.Add(new PlanNGP() { Date = dateTime.ToLongDateString() });
                            }
                        }
                    }
                    db.SaveChanges();
                    PlanNGP = db.PlanNGP.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                    break;
                case PlanType.ЮПГПЗ:
                    db.PlanYPGPZ.Load();
                    {
                        List<PlanYPGPZ> planDatas = db.PlanYPGPZ.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                        foreach (DateTime dateTime in dates)
                        {
                            if (!planDatas.Any(x => DateTime.Parse(x.Date) == dateTime))
                            {
                                db.PlanYPGPZ.Add(new PlanYPGPZ() { Date = dateTime.ToLongDateString() });
                            }
                        }
                    }
                    db.SaveChanges();
                    PlanYPGPZ = db.PlanYPGPZ.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                    break;
                case PlanType.ЮБГПЗ:
                    db.PlanYBGPZ.Load();
                    {
                        List<PlanYBGPZ> planDatas = db.PlanYBGPZ.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                        foreach (DateTime dateTime in dates)
                        {
                            if (!planDatas.Any(x => DateTime.Parse(x.Date) == dateTime))
                            {
                                db.PlanYBGPZ.Add(new PlanYBGPZ() { Date = dateTime.ToLongDateString() });
                            }
                        }
                    }
                    db.SaveChanges();
                    PlanYBGPZ = db.PlanYBGPZ.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                    break;
                case PlanType.МГПЗ:
                    db.PlanMGPZ.Load();
                    {
                        List<PlanMGPZ> planDatas = db.PlanMGPZ.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                        foreach (DateTime dateTime in dates)
                        {
                            if (!planDatas.Any(x => DateTime.Parse(x.Date) == dateTime))
                            {
                                db.PlanMGPZ.Add(new PlanMGPZ() { Date = dateTime.ToLongDateString() });
                            }
                        }
                    }
                    db.SaveChanges();
                    PlanMGPZ = db.PlanMGPZ.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                    break;
                case PlanType.ВГПЗ:
                    db.PlanVGPZ.Load();
                    {
                        List<PlanVGPZ> planDatas = db.PlanVGPZ.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                        foreach (DateTime dateTime in dates)
                        {
                            if (!planDatas.Any(x => DateTime.Parse(x.Date) == dateTime))
                            {
                                db.PlanVGPZ.Add(new PlanVGPZ() { Date = dateTime.ToLongDateString() });
                            }
                        }
                    }
                    db.SaveChanges();
                    PlanVGPZ = db.PlanVGPZ.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                    break;
                case PlanType.НВГПК:
                    db.PlanNVGPK.Load();
                    {
                        List<PlanNVGPK> planDatas = db.PlanNVGPK.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                        foreach (DateTime dateTime in dates)
                        {
                            if (!planDatas.Any(x => DateTime.Parse(x.Date) == dateTime))
                            {
                                db.PlanNVGPK.Add(new PlanNVGPK() { Date = dateTime.ToLongDateString() });
                            }
                        }
                    }
                    db.SaveChanges();
                    PlanNVGPK = db.PlanNVGPK.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                    break;
                case PlanType.БГПК:
                    db.PlanBGPK.Load();
                    {
                        List<PlanBGPK> planDatas = db.PlanBGPK.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                        foreach (DateTime dateTime in dates)
                        {
                            if (!planDatas.Any(x => DateTime.Parse(x.Date) == dateTime))
                            {
                                db.PlanBGPK.Add(new PlanBGPK() { Date = dateTime.ToLongDateString() });
                            }
                        }
                    }
                    db.SaveChanges();
                    PlanBGPK = db.PlanBGPK.Local.ToBindingList().Where(x => Between(DateTime.Parse(x.Date), dates.First(), dates.Last())).ToList();
                    break;

            }           
            
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
                     
                                           
                      try
                      {
                          switch (type)
                          {
                              case PlanType.ГГПЗ:
                                  {
                                      PlanGGPZ plan = selectedItem as PlanGGPZ;
                                      plan.Acceptance_Purneftegaz_days = plan.Acceptance_Purneft_hours * 24;
                                      plan.Acceptance_Yangpur_days = plan.Acceptance_Yangpur_hours * 24;
                                      plan.Acceptance_Purneft_days = plan.Acceptance_Purneft_hours * 24;
                                      plan.Acceptance_Total_days = plan.Acceptance_Purneftegaz_days + plan.Acceptance_Purneftegaz_days + plan.Acceptance_Purneft_days;
                                      plan.Acceptance_Total_hours = plan.Acceptance_Purneftegaz_hours + plan.Acceptance_Yangpur_hours + plan.Acceptance_Purneft_hours;
                                      plan.SOGProduction_Factory_days = plan.SOGProduction_Factory_hours * 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.SHFLY_Production_days = plan.Acceptance_Total_days * (plan.Fat_PNG - plan.SOG_Reduce) / 1000;
                                      plan.SHFLY_Production_hours = plan.SHFLY_Production_days / 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.Etan_Record = plan.SHFLY_Production_days * (1 + plan.Etan_Percent / 100);
                                      PlanGGPZ plan2 = db.PlanGGPZ.Find(plan.ID);
                                      if (plan2 != null)
                                      {
                                          db.Entry(plan2).State = EntityState.Modified;
                                          db.SaveChangesAsync();

                                      }
                                  }
                                  break;
                              case PlanType.НГП:
                                  {
                                      PlanNGP plan = selectedItem as PlanNGP;
                                      plan.Acceptance_Nyaganneftegaz_days = plan.Acceptance_Nyaganneftegaz_hours * 24;
                                      plan.Acceptance_Lykoil_days = plan.Acceptance_Lykoil_hours * 24;
                                      plan.Acceptance_Total_days = plan.Acceptance_Nyaganneftegaz_days + plan.Acceptance_Lykoil_days;
                                      plan.Acceptance_Total_hours = plan.Acceptance_Nyaganneftegaz_hours + plan.Acceptance_Lykoil_hours;
                                      plan.SOGProduction_Factory_days = plan.SOGProduction_Factory_hours * 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;           
                                      plan.PBTProduction_Factory_hours = plan.PBTProduction_Factory_days / 24;
                                      plan.BGSProduction_Factory_hours = plan.PBTProduction_Factory_days * (1 + plan.BGSProduction_Factory_days / 100);
                                      plan.PTProduction_Factory_hours = plan.BGSProduction_Factory_days * (1 + plan.PTProduction_Factory_days / 100);
                                      PlanNGP plan2 = db.PlanNGP.Find(plan.ID);
                                      if (plan2 != null)
                                      {
                                          db.Entry(plan2).State = EntityState.Modified;
                                          db.SaveChangesAsync();

                                      }
                                  }
                                  break;
                              case PlanType.ЮПГПЗ:
                                  {
                                      PlanYPGPZ plan = selectedItem as PlanYPGPZ;
                                      plan.Acceptance_GazpromneftHantos_days = plan.Acceptance_GazpromneftHantos_hours * 24;                            
                                      plan.Acceptance_Total_days = plan.Acceptance_GazpromneftHantos_days;
                                      plan.Acceptance_Total_hours = plan.Acceptance_GazpromneftHantos_hours;
                                      plan.SOGProduction_Factory_days = plan.SOGProduction_Factory_hours * 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.SHFLY_Production_days = plan.Acceptance_Total_days * (plan.Fat_PNG - plan.SOG_Reduce) / 1000;
                                      plan.SHFLY_Production_hours = plan.SHFLY_Production_days / 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.Etan_Record = plan.SHFLY_Production_days * (1 + plan.Etan_Percent / 100);
                                      PlanYPGPZ plan2 = db.PlanYPGPZ.Find(plan.ID);
                                      if (plan2 != null)
                                      {
                                          db.Entry(plan2).State = EntityState.Modified;
                                          db.SaveChangesAsync();

                                      }
                                  }
                                  break;
                              case PlanType.ЮБГПЗ:
                                  {
                                      PlanYBGPZ plan = selectedItem as PlanYBGPZ;
                                      plan.Acceptance_RNYNG_days = plan.Acceptance_RNYNG_hours * 24;
                                      plan.Acceptance_RNYN_days = plan.Acceptance_RNYN_hours * 24;
                                      plan.Acceptance_RNYNG_konden_days = plan.Acceptance_RNYNG_konden_hours * 24;
                                      plan.Acceptance_SNMNG_konden_days = plan.Acceptance_SNMNG_konden_hours * 24;
                                      plan.Acceptance_Total_days = plan.Acceptance_RNYNG_days 
                                      + plan.Acceptance_RNYN_days + 
                                      plan.Acceptance_RNYNG_konden_days
                                      + plan.Acceptance_SNMNG_konden_days;
                                      plan.Acceptance_Total_hours = plan.Acceptance_RNYNG_hours
                                      + plan.Acceptance_RNYN_hours
                                      + plan.Acceptance_RNYNG_konden_hours
                                      + plan.Acceptance_SNMNG_konden_hours;
                                      plan.SOGProduction_Factory_days = plan.SOGProduction_Factory_hours * 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.SHFLY_Production_days = plan.Acceptance_Total_days * (plan.Fat_PNG - plan.SOG_Reduce) / 1000;
                                      plan.SHFLY_Production_hours = plan.SHFLY_Production_days / 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.Etan_Record = plan.SHFLY_Production_days * (1 + plan.Etan_Percent / 100);
                                      PlanYBGPZ plan2 = db.PlanYBGPZ.Find(plan.ID);
                                      if (plan2 != null)
                                      {
                                          db.Entry(plan2).State = EntityState.Modified;
                                          db.SaveChangesAsync();

                                      }
                                  }
                                  break;
                              case PlanType.МГПЗ:
                                  {
                                      PlanMGPZ plan = selectedItem as PlanMGPZ;
                                      plan.Acceptance_GPNNNG_days = plan.Acceptance_GPNNNG_hours * 24;
                                      plan.Acceptance_YAKE_days = plan.Acceptance_YAKE_hours * 24;
                                      plan.Acceptance_HKS_days = plan.Acceptance_HKS_hours * 24;
                                      plan.Acceptance_HKSNG_SupplyMGPZ = plan.Acceptance_HKS_days - plan.Acceptance_HKSNG_SN - plan.Acceptance_HKSNG_Lose;
                                      plan.Acceptance_TotalFactory_hours = plan.Acceptance_TotalFactory_days / 24;
                                      plan.Acceptance_TotalComplex_days=plan.Acceptance_GPNNNG_days + plan.Acceptance_YAKE_days + plan.Acceptance_GPNNNG_days;
                                      plan.Acceptance_TotalComplex_hours = plan.Acceptance_HKS_hours
                                      + plan.Acceptance_YAKE_hours
                                      + plan.Acceptance_GPNNNG_hours;
                                      plan.SOGProduction_Factory_days = plan.SOGProduction_Factory_hours * 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.SOGProduction_Complex_hours = plan.SOGProduction_Complex_days / 24;
                                      plan.SHFLY_Production_days = plan.Acceptance_TotalFactory_days * (plan.Fat_PNG - plan.SOG_Reduce) / 1000;
                                      plan.SHFLY_Production_hours = plan.SHFLY_Production_days / 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.Etan_Record = plan.SHFLY_Production_days * (1 + plan.Etan_Percent / 100);
                                      PlanMGPZ plan2 = db.PlanMGPZ.Find(plan.ID);
                                      if (plan2 != null)
                                      {
                                          db.Entry(plan2).State = EntityState.Modified;
                                          db.SaveChangesAsync();

                                      }
                                  }
                                  
                                  break;
                              case PlanType.ВГПЗ:
                                  {
                                      PlanVGPZ plan = selectedItem as PlanVGPZ;                                      
                                      plan.Acceptance_GPNNNG_days = plan.Acceptance_GPNNNG_hours * 24;
                                      plan.Acceptance_NGVGPP_days = plan.Acceptance_NGVGPP_hours * 24;
                                      plan.Acceptance_VyaKC_days = plan.Acceptance_VyaKC_hours * 24;
                                      plan.Acceptance_VyaKCNG_SupplyMGPZ = plan.Acceptance_VyaKC_days - plan.Acceptance_VyaKCNG_SN - plan.Acceptance_VyaKCNG_Lose;
                                      plan.Acceptance_TotalFactory_hours = plan.Acceptance_TotalFactory_days / 24;
                                      plan.Acceptance_TotalComplex_days = plan.Acceptance_GPNNNG_days + plan.Acceptance_NGVGPP_days + plan.Acceptance_GPNNNG_days;
                                      plan.Acceptance_TotalComplex_hours = plan.Acceptance_NGVGPP_hours
                                      + plan.Acceptance_VyaKC_hours
                                      + plan.Acceptance_VyaKCNG_SupplyMGPZ;
                                      plan.SOGProduction_Factory_days = plan.SOGProduction_Factory_hours * 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.SOGProduction_Complex_hours = plan.SOGProduction_Complex_days / 24;
                                      plan.SHFLY_Production_days = plan.Acceptance_TotalFactory_days * (plan.Fat_PNG - plan.SOG_Reduce) / 1000;
                                      plan.SHFLY_Production_hours = plan.SHFLY_Production_days / 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.Etan_Record = plan.SHFLY_Production_days * (1 + plan.Etan_Percent / 100);
                                      PlanVGPZ plan2 = db.PlanVGPZ.Find(plan.ID);
                                      if (plan2 != null)
                                      {
                                          db.Entry(plan2).State = EntityState.Modified;
                                          db.SaveChangesAsync();

                                      }
                                  }

                                  break;
                              case PlanType.БГПК:
                                  {
                                      PlanBGPK plan = selectedItem as PlanBGPK;
                                      plan.Acceptance_SNG_days = plan.Acceptance_SNG_hours * 24;
                                      plan.Acceptance_NG_days = plan.Acceptance_NG_hours * 24;
                                      plan.Acceptance_VGPP_days = plan.Acceptance_VGPP_hours * 24;
                                      plan.Acceptance_Rysneft_days = plan.Acceptance_Rysneft_hours * 24;
                                      plan.Acceptance_VNG_days = plan.Acceptance_VNG_hours * 24;
                                     
                                      plan.SOGProduction_Factory_days = plan.SOGProduction_Factory_hours * 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.SOGProduction_Complex_hours = plan.SOGProduction_Complex_days / 24;
                                      plan.SHFLY_Production_days = plan.Acceptance_TotalFactory_days * (plan.Fat_PNG - plan.SOG_Reduce) / 1000;
                                      plan.SHFLY_Production_hours = plan.SHFLY_Production_days / 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.Etan_Record = plan.SHFLY_Production_days * (1 + plan.Etan_Percent / 100);

                                      PlanBGPK plan2 = db.PlanBGPK.Find(plan.ID);
                                     
                                      if (plan2 != null)
                                      {
                                          db.Entry(plan2).State = EntityState.Modified;
                                          db.SaveChangesAsync();

                                      }
                                  }

                                  break;
                              case PlanType.НВГПК:
                                  {
                                      PlanNVGPK plan = selectedItem as PlanNVGPK;
                                      plan.Acceptance_SNG_days = plan.Acceptance_SNG_hours * 24;
                                      plan.Acceptance_NG_days = plan.Acceptance_NG_hours * 24;
                                      /*
                                      plan.Acceptance_VGPP_days = plan.Acceptance_VGPP_hours * 24;
                                      plan.Acceptance_Rysneft_days = plan.Acceptance_Rysneft_hours * 24;
                                      plan.Acceptance_VNG_days = plan.Acceptance_VNG_hours * 24;
                                      */
                                      plan.SOGProduction_Factory_days = plan.SOGProduction_Factory_hours * 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.SOGProduction_Complex_hours = plan.SOGProduction_Complex_days / 24;
                                      plan.SHFLY_Production_days = plan.Acceptance_TotalFactory_days * (plan.Fat_PNG - plan.SOG_Reduce) / 1000;
                                      plan.SHFLY_Production_hours = plan.SHFLY_Production_days / 24;
                                      plan.SOGProduction_Magistral_days = plan.SOGProduction_Magistral_hours * 24;
                                      plan.Etan_Record = plan.SHFLY_Production_days * (1 + plan.Etan_Percent / 100);

                                      PlanNVGPK plan2 = db.PlanNVGPK.Find(plan.ID);

                                      if (plan2 != null)
                                      {
                                          db.Entry(plan2).State = EntityState.Modified;
                                          db.SaveChangesAsync();

                                      }
                                  }

                                  break;
                          }
                      }catch(Exception e)
                      {
                          MessageBox.Show(e.ToString());
                      }
                      
                      // получаем измененный объект
                           
                     
                      
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
