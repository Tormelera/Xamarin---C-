using MoneyControl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyControl.Services
{
    public interface IPurchaseRepository
    {
        List<PurchaseInfo> GetAllPurchasesData();

        //Get Specific Contact data  
        PurchaseInfo GetPurchaseData(int purchaseID);

        // Delete all Contacts Data  
        void DeleteAllPurchases();

        // Delete Specific Contact  
        void DeletePurchase(int purchaseID);

        // Insert new Contact to DB   
        void InsertPurchase(PurchaseInfo purchase);

        // Update Contact Data  
        void UpdatePurchase(PurchaseInfo purchase);
    }
}
