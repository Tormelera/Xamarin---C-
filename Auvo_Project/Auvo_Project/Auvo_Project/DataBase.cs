using System;
using System.Collections.Generic;
using System.Text;
using Android.Util;
using Auvo_Project.Model;
using SQLite;


namespace Auvo_Project
{
    public class DataBase
    {
        public static string pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public static readonly SQLiteConnection conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Pessoas.db3"));

        public bool CriarBancoDeDados()
        {
            try
            {
                
                {
                    conexao.CreateTable<Pessoa>();
             
                    return true;

                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool InserirPessoa(Pessoa pessoa)
        {
            try
            {
                    conexao.Insert(pessoa);
                    return true;

            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public List<Pessoa> GetPessoas()
        {
            try
            {

                
                    return conexao.Table<Pessoa>().ToList();
                
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }
        public bool AtualizarPessoa(Pessoa pessoa)
        {
            try
            {

                
                   
                    return true;
                
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool DeletarPessoa(Pessoa pessoa)
        {
            try
            {

                
                    conexao.Delete(pessoa);
                    return true;
                
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool GetPessoa(int Id)
        {
            try
            {

                
                    conexao.Query<Pessoa>("SELECT * FROM Pessoa Where Id=?", Id);
                    //conexao.Update(aluno);
                    return true;
                
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
    }
}
