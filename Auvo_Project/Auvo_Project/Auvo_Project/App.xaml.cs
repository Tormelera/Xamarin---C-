using Auvo_Project.Model;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;
using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Auvo_Project
{
	public partial class App : Application
	{
        

        public App ()
		{
            
            DataBase.conexao.CreateTable<Pessoa>();

            InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
