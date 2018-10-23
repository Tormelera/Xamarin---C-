using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MoneyControl.Droid.Implementations;
using MoneyControl.Helpers;
using SQLite.Net;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidSQLite))]
namespace MoneyControl.Droid.Implementations
{
    public class AndroidSQLite : ISQLite
    {
        public DatabaseHelper db { get; private set; }

        public SQLiteConnection GetConnection()
        {
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            // Documents folder  
            var path = Path.Combine(documentsPath, "Purchases.db3");
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLiteConnection(plat, path);

            // Return the database connection  
            return conn;
        }

    }
}