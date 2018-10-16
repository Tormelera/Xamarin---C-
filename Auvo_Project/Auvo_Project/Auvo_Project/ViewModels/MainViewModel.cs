using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Auvo_Project;
using Auvo_Project.Model;

namespace Auvo_Project.ViewModels
{
    public class MainViewModel : Pessoa
    {
        async void ExecuteSaveCommand()
        {

            await Task.Delay(1500);

            await App.Current.MainPage.DisplayAlert("Auvo_Project", $"Confirma os dados abaixo?\nNome: '{Nome}';\n" +
                $"CPF: '{CPF}';\n" +
                $"E-mail: '{Email}';\n" +
                $"Usuário: '{Login}'.", "Sim", "Não");

        }

        bool CanExecuteSaveCommand()
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
            SaveCommand = new Command(ExecuteSaveCommand, CanExecuteSaveCommand);
        }
    }
}
