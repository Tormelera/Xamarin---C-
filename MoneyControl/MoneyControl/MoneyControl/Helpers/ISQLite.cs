using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyControl.Helpers
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
