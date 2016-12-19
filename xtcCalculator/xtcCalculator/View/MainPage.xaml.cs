using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using xtcCalculator.ViewModel;

namespace xtcCalculator.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MainPageViewModel vm = new MainPageViewModel();
            BindingContext = vm;
        }
    }
}
