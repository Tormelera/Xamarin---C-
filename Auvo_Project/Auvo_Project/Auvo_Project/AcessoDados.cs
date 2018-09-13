using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms;

namespace Auvo_Project
{                           //Estudar IDisposable
    public class AcessoDados // :IDisposable
    {
        /*
        private SQLite.Net.SQLiteConnection _conexao;

        public AcessoDados()
        {
            var config = DependencyService.Get<Auvo_Project.Droid.IConfig>();
            _conexao = new SQLite.Net.SQLiteConnection(config.Plataforma, System.IO.Path.Combine(config.DiretorioDB, "bancodados.db3"));

            _conexao.CreateTable<Usuario>();
        }

        public void Insert(Usuario usuario)
        {
            _conexao.Insert(usuario);
        }

        public void Delete(Usuario usuario)
        {
            _conexao.Delete(usuario);
        }

        public void Dispose()
        {
            
        }
        */
    }
}
