
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
	public partial class CalculatorPage : ContentPage
	{
        public Person Person;
		public CalculatorPage (Person per)
		{
            Person = HomePage.GetPerson(per);
            InitializeComponent();
        }
        Person GetPerson(Person per)
        {
            return per;
        }

        private void ButtonToCalculateResult_Click(object sender, EventArgs e)
        {                   
            double result = 0;
            if (height.Text=="0" || weight.Text == "0")
            {
                DisplayAlert("Error", "You should change Height or Weight", "OK");
            }
            else
            {
                double Height = double.Parse(height.Text);
                double Weight = double.Parse(weight.Text);
                result = Weight / (Height*Height);
                DateTime date = new DateTime();
                date = DateTime.Now;
                Result ResultObject = new Result();
                ResultObject.DateTime = date;
                ResultObject.result = result;             
                Person.ResultList.Add(ResultObject);
                DisplayAlert("Result", $"Your BMI {result} ", "Next");
            }
        }
       
        private void EditorTextChanged(object sender, TextChangedEventArgs e)
        {
            var text = e.OldTextValue;
            var newText = e.NewTextValue;
        }
    }
}