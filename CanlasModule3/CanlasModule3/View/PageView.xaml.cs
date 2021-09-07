using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanlasModule3.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CanlasModule3.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageView : ContentPage
    {
        public PageView()
        {
            InitializeComponent();
            BindingContext = new StudentViewModel();
        }
    }
}