using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Auvo_Project;

namespace Auvo_Project.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set {
                    if(SetProperty(ref _nome, value))
                        SaveCommand.ChangeCanExecute();
            }
        }

        private string _cpf;

        public string CPF
        {
            get { return _cpf; }
            set {
                if(SetProperty(ref _cpf, value))
                    SaveCommand.ChangeCanExecute();
            }
        }
        
        public Command SaveCommand { get; }

        async void ExecuteSaveCommand()
        {
            Debug.WriteLine($"O nome digitado é: {Nome} e o CPF digitado é: {CPF}");

            await Task.Delay(1500);

            await App.Current.MainPage.DisplayAlert("Auvo_Project", $"Você salvou o nome '{Nome}' e o CPF '{CPF}'", "OK");
            
            
        }

        bool CanExecuteSaveCommand()
        {
            if ((string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(CPF)) == true)
                return false;

            if (ValidaCPF.IsCpf(CPF) == false)
                return false;

            return true;
        }

        public MainViewModel()
        {
            SaveCommand = new Command(ExecuteSaveCommand, CanExecuteSaveCommand);
        }
    }
}
