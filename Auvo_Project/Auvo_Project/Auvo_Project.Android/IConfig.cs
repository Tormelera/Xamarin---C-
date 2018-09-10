using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;

namespace Auvo_Project.Droid
{
    public interface IConfig
    {
        string DiretorioDB { get; }
        ISQLitePlatform Plataforma { get; }

    }
}
