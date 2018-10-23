using MoneyControl.Helpers;
using MoneyControl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyControl.Services
{
    public class PurchaseRepository
    {
        DatabaseHelper _databaseHelper;
        public PurchaseRepository()
        {
            _databaseHelper = new DatabaseHelper();
        }

        public void DeleteContact(int purchaseID)
        {
            _databaseHelper.DeletePurchase(purchaseID);
        }

        public void DeleteAllContacts()
        {
            _databaseHelper.DeleteAllPurchases();
        }

        public List<PurchaseInfo> GetAllContactsData()
        {
            return _databaseHelper.GetAllPurchasesData();
        }

        public PurchaseInfo GetContactData(int contactID)
        {
            return _databaseHelper.GetPurchaseData(contactID);
        }

        public void InsertContact(PurchaseInfo contact)
        {
            _databaseHelper.InsertPurchase(contact);
        }

        public void UpdateContact(PurchaseInfo contact)
        {
            _databaseHelper.UpdatePurchase(contact);
        }
    }
}

