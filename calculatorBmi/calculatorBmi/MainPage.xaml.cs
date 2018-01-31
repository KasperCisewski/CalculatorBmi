using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculatorBmi
{
    public partial class MainPage : ContentPage
    {
        public Person per;

        public MainPage()
        {     
            InitializeComponent();
        }

      

        private async void buttonNextPage_Click(object sender, EventArgs e)
        {
         per = new Person();
            per.ResultList = FillResultList(per.ResultList);
          

            per.FullName = login.Text;

        if(per.FullName == "Fill")
            {
                DisplayAlert("Error","Wrong Login","OK");
            }
        else
            {
                await Navigation.PushAsync(new pages.HomePage(per));
            }
        }

        private List<Result> FillResultList(List<Result> ResultList)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            Result result = new Result();
            result.DateTime = date;
            result.result = 30;
            ResultList.Add(result);
            result.result = 15;
            ResultList.Add(result);
            result.result = 20;
            ResultList.Add(result);
            result.result = 22;
            ResultList.Add(result);
            result.result = 27;
            ResultList.Add(result);
            result.result = 17;
            ResultList.Add(result);
            result.result = 23;
            ResultList.Add(result);
            result.result = 21;
            ResultList.Add(result);
            result.result = 20;
            ResultList.Add(result);
            result.result = 16;
            ResultList.Add(result);


            return ResultList;
        }

        private void EditorTextChanged(object sender, TextChangedEventArgs e)
        {
            var text = e.OldTextValue;
            var newText = e.NewTextValue;
        }
    }
}
