using System;
using System.Collections.Generic;
using SQLite;
using System.Text;
using Android.Util;
using Auvo_Project.Model;

namespace Auvo_Project
{
    public class DataBase
    {
        string pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool CriarBancoDeDados()
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Pessoas.db")))
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
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Pessoas.db")))
                {
                    conexao.Insert(pessoa);
                    return true;
                }
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
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Pessoas.db")))
                {
                    return conexao.Table<Pessoa>().ToList();
                }
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
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Pessoas.db")))
                {
                    conexao.Query<Pessoa>("UPDATE Pessoa set Nome=?,CPF=?, Email=?, Login=? Where Id=?", pessoa.Nome, pessoa.CPF, pessoa.Email, pessoa.Login, pessoa.Id);
                    return true;
                }
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
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Pessoas.db")))
                {
                    conexao.Delete(pessoa);
                    return true;
                }
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
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Pessoas.db")))
                {
                    conexao.Query<Pessoa>("SELECT * FROM Pessoa Where Id=?", Id);
                    //conexao.Update(aluno);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
    }
}
