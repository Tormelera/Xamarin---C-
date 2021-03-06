﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Auvo_Project;
using Auvo_Project.Model;
using System.Collections.ObjectModel;

namespace Auvo_Project.ViewModels
{
    public class MainViewModel : Pessoa
    {

        Pessoa pessoa = new Pessoa();

        async void ExecuteIncludeCommand()
        {
            
            await Task.Delay(1500);

                bool accept = await App.Current.MainPage.DisplayAlert("Auvo_Project", $"Confirma os dados abaixo?\nNome: '{Nome}';\n" +
                $"CPF: '{CPF}';\n" +
                $"E-mail: '{Email}';\n" +
                $"Usuário: '{Login}'.", "Sim", "Não");

            if (accept == true)
            {

                DataBase.conexao.CreateTable<Pessoa>();
                DataBase.conexao.Insert(pessoa);

                await App.Current.MainPage.DisplayAlert("Auvo_Project", "Dados salvos com sucesso!", "OK");

            }

        }

        bool CanExecuteIncludeCommand()
        {
            if ((string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(CPF) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Login)
                || string.IsNullOrWhiteSpace(Senha)))
                return false;

            if (Validacoes.IsCpf(CPF) == false)
                return false;

            if (Validacoes.IsEmail(Email) == false)
                return false;

            return true;
        }

        public MainViewModel()
        {
            IncludeCommand = new Command(ExecuteIncludeCommand, CanExecuteIncludeCommand);
            
        }
    }
}
