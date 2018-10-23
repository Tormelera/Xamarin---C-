using MoneyControl.Models;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MoneyControl.Helpers
{
    public class DatabaseHelper
    {
        static SQLiteConnection sqliteconnection;

        public DatabaseHelper()
        {
            sqliteconnection = DependencyService.Get<ISQLite>().GetConnection();
            sqliteconnection.CreateTable<PurchaseInfo>();
        }

        // Get All Purchase data      
        public List<PurchaseInfo> GetAllPurchasesData()
        {
            return (from data in sqliteconnection.Table<PurchaseInfo>()
                    select data).ToList();
        }

        //Get Specific Purchase data  
        public PurchaseInfo GetPurchaseData(int id)
        {
            return sqliteconnection.Table<PurchaseInfo>().FirstOrDefault(t => t.Id == id);
        }

        // Delete all Contacts Data  
        public void DeleteAllPurchases()
        {
            sqliteconnection.DeleteAll<PurchaseInfo>();
        }

        // Delete Specific Contact  
        public void DeletePurchase(int id)
        {
            sqliteconnection.Delete<PurchaseInfo>(id);
        }

        // Insert new Contact to DB   
        public void InsertPurchase(PurchaseInfo purchase)
        {
            sqliteconnection.Insert(purchase);
        }

        // Update Contact Data  
        public void UpdatePurchase(PurchaseInfo purchase)
        {
            sqliteconnection.Update(purchase);
        }
    }
}

