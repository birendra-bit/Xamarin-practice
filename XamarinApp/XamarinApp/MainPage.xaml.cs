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
        void OnButtonClicked( object sender, EventArgs e)
        {
               
            (sender as Button).Text = "Click Me Again";
        }
        void OnEntryTextChanged( object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
