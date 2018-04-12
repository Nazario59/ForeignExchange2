using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using ForeingExchange2.Models;
using System.Windows.Input;
 
using GalaSoft.MvvmLight.Command;

namespace ForeingExchange2.ViewModels
{
     
   public  class MainViewModel
    {
        #region Properties
        public string Amount { get; set; }
        public ObservableCollection<Rate> Rates   { get; set; }
        public Rate SourceRate { get; set; }
        public Rate  TargetRate { get; set; }
        public bool IsRunning { get; set; }
        public bool IsEnable { get; set; }
        public string Result { get; set; }  

        #endregion

        public MainViewModel()
        {
        }

        #region Commands

        public ICommand ConvertCommand
        {
            get
            {
                return new RelayCommand(Convert);
            }
        }
            void Convert()
        {

        }
         
        #endregion
    }
}
