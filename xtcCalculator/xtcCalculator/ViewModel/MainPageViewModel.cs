using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace xtcCalculator.ViewModel
{
    class MainPageViewModel:INotifyPropertyChanged
    {

        private int _valueA;
        public int valueA
        {
            get { return _valueA; }
            set
            {
                _valueA = value;
                sumValues();
                OnPropertyChanged("valueA");
            }
        }


        private int _valueB;
        public int valueB
        {
            get { return _valueB; }
            set
            {
                _valueB = value;
                sumValues();
                OnPropertyChanged("valueB");
            }
        }


        private int _result;
        public int result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged("result");
            }
        }

        public ICommand sumValuesCommand { get; set; }
        public void sumValues()
        {
            result = valueA + valueB;
        }
        public MainPageViewModel()
        {
            sumValuesCommand = new Command(sumValues);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
