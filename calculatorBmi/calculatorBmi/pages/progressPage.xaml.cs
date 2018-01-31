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
	public partial class ProgressPage : ContentPage
	{
        public List<Result> ResultList { get; set; }
        public Person Person { get; set; }

        public ProgressPage (Person per)
        {
            Person = HomePage.GetPerson(per);
            Init(Person);
            InitializeComponent ();
            
		}

        private async Task Init(Person per)
        {
            ResultList = new List<Result>();
            var listResults = new List<Result>();
            listResults = await ResultGenerator.CreateResults(per);
            ResultList = listResults;
            BindingContext = this ;
            
        }

  
    }
}