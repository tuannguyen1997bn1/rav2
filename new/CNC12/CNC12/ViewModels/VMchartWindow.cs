using LiveCharts;
using LiveCharts.Wpf;
using System.Net;
using System.IO;
using System.Windows.Threading;
using LiveCharts.Defaults;
using LiveCharts.Configurations;
using System;
using CNC12.Model;
using System.Linq;

namespace CNC12.ViewModels
{
    class VMchartWindow : BaseVM
    {
        #region value
        private float _Segments1;
        public float Segments1
        {
            get { return _Segments1; }
            set
            {
                _Segments1 = value;
                OnPropertyChanged("Segments1");
            }
        }
        private float _Segments2;
        public float Segments2
        {
            get { return _Segments2; }
            set
            {
                _Segments2 = value;
                OnPropertyChanged("Segments2");
            }
        }
        private float _Segments3;
        public float Segments3
        {
            get { return _Segments3; }
            set
            {
                _Segments3 = value;
                OnPropertyChanged("Segments3");
            }
        }
        private float _Segments4;
        public float Segments4
        {
            get { return _Segments4; }
            set
            {
                _Segments4 = value;
                OnPropertyChanged("Segments4");
            }
        }
        private float _Segments5;
        public float Segments5
        {
            get { return _Segments5; }
            set
            {
                _Segments5 = value;
                OnPropertyChanged("Segments5");
            }
        }
        private float _Segments6;
        public float Segments6
        {
            get { return _Segments6; }
            set
            {
                _Segments6 = value;
                OnPropertyChanged("Segments6");
            }
        }
        private float _Segments7;
        public float Segments7
        {
            get { return _Segments7; }
            set
            {
                _Segments7 = value;
                OnPropertyChanged("Segments7");
            }
        }
        private float _Segments8;
        public float Segments8
        {
            get { return _Segments8; }
            set
            {
                _Segments8 = value;
                OnPropertyChanged("Segments8");
            }
        }
        #endregion

        readonly DispatcherTimer timer;
        public VMchartWindow()
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 5000);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var run1 = DataProvider.Ins.DB.EventManagerCNCs.Where(x=> x.IdCNC == 1 && x.IdHienTrangMayCNC == 1).Count();
            var allstates1 = DataProvider.Ins.DB.EventManagerCNCs.Where(x => x.IdCNC == 1).Count();
            if(allstates1 > 0)
            {
                Segments1 = ((int)(((float)run1 / (float)allstates1)*10000))/100;
            }          

            var run2 = DataProvider.Ins.DB.EventManagerCNCs.Where(x => x.IdCNC == 2 && x.IdHienTrangMayCNC == 1).Count();
            var allstates2 = DataProvider.Ins.DB.EventManagerCNCs.Where(x => x.IdCNC == 2).Count();
            if(allstates2 > 0)
            {
                Segments2 = ((int)(((float)run2 / (float)allstates2) * 10000))/100;
            }

            Segments3 = 90;
            Segments4 = 94;
            Segments5 = 50;
            Segments6 = 70;
            Segments7 = 79;
            Segments8 = 60;
        }
    }
}
