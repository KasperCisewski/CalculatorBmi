using calculatorBmi.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calculatorBmi.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage (Person per)
        {
            InitializeComponent();
            DisplayAlert("", $"Hello {per.FullName}","Next");
            Children.Add(new CalculatorPage(per));
            Children.Add(new ProgressPage(per));
            Children.Add(new HiscoresPage());
        }
        public static Person GetPerson(Person per) => per;
    }
}