using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Auvo_Project.ViewModels;
using Auvo_Project.Model;

namespace Auvo_Project
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            BindingContext = new MainViewModel();

            DataBase db = new DataBase();




        }
    }
}
