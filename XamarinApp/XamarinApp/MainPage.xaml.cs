using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class MainPage : ContentPage
    {
        //void OnButtonClicked( object sender, EventArgs e)
        //{

        //    (sender as Button).Text = "Click Me Again";
        //}
        //void OnEntryTextChanged( object sender, TextChangedEventArgs e)
        //{
        //    string oldText = e.OldTextValue;
        //    string newText = e.NewTextValue;
        //}
        //void OnEntryComplete( object sender, EventArgs e)
        //{
        //    string text = ((Entry)sender).Text;
        //}
        public IList<PersonDeatils> Person { get; private set; }
        public MainPage()
        {
            InitializeComponent();
            Person = new List<PersonDeatils>();

            Person.Add(new PersonDeatils
            {
                Name = "Birendra Bhujel",
                Designation = "Intern",
                DateOfJoining = "02/09/2019",
                ImageUrl = "download.jpg",
                Description = "I like coding and visiting new places"
            });
            Person.Add(new PersonDeatils
            {
                Name = "Birendra Bhujel",
                Designation = "Intern",
                DateOfJoining = "02/09/2019",
                ImageUrl = "download.jpg",
                Description ="I like coding and visiting new places"
            });
            Person.Add(new PersonDeatils
            {
                Name = "Birendra Bhujel",
                Designation = "Intern",
                DateOfJoining = "02/09/2019",
                ImageUrl = "download.jpg",
                Description = "I like coding and visiting new places"
            });
            Person.Add(new PersonDeatils
            {
                Name = "Birendra Bhujel",
                Designation = "Intern",
                DateOfJoining = "02/09/2019",
                ImageUrl = "download.jpg",
                Description = "I like coding and visiting new places"
            });
            Person.Add(new PersonDeatils
            {
                Name = "Birendra Bhujel",
                Designation = "Intern",
                DateOfJoining = "02/09/2019",
                ImageUrl = "download.jpg",
                Description = "I like coding and visiting new places"
            });
            BindingContext = this;
        }
    }
}
