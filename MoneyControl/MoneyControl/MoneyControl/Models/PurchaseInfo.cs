using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyControl.Models
{
    [Table("PurchaseInfo")]
    public class PurchaseInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public decimal Value { get; set; }
        public string TypeOfPurchase { get; set; }
        public DateTime Date { get; set; }

    }
}
