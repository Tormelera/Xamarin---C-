using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(Auvo_Project.Droid.Config))]

namespace Auvo_Project.Droid
{
    public class Config : IConfig
    {
        private string _diretorioDB;
        public string DiretorioDB
        {
            get
            {
                if (string.IsNullOrEmpty(_diretorioDB))
                    _diretorioDB = Convert.ToString(System.Environment.SpecialFolder.Personal);

                return _diretorioDB;
            }
        }

        private ISQLitePlatform _plataforma;
        public ISQLitePlatform Plataforma
        {
            get
            {
                if (_plataforma == null)
                    _plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();

                return _plataforma;
            }
        }
    }
}
