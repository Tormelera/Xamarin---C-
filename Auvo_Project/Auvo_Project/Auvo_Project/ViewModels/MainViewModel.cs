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
            set
            {
                if (SetProperty(ref _nome, value))
                    SaveCommand.ChangeCanExecute();
                
            }
        }

        private string _cpf;

        public string CPF
        {
            get { return _cpf; }
            set
            {
                if (SetProperty(ref _cpf, value))
                    SaveCommand.ChangeCanExecute();
            }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (SetProperty(ref _email, value))
                    SaveCommand.ChangeCanExecute();
            }
        }

        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                if (SetProperty(ref _login, value))
                    SaveCommand.ChangeCanExecute();
            }
        }

        private string _senha;

        public string Senha
        {
            get { return _senha; }
            set
            {
                if (SetProperty(ref _senha, value))
                    SaveCommand.ChangeCanExecute();
            }
        }

        
        public Command SaveCommand { get; }

        List<Usuario> ListaUsuarios = new List<Usuario>();

        async void ExecuteSaveCommand()
        {
            Usuario usuarioAtual = new Usuario();
            await Task.Delay(1500);

            usuarioAtual.Nome = this.Nome;
            usuarioAtual.CPF = this.CPF;
            usuarioAtual.Email = this.Email;
            usuarioAtual.Login = this.Login;
            usuarioAtual.Senha = this.Senha;

            await App.Current.MainPage.DisplayAlert("Auvo_Project", $"Confirma os dados abaixo?\nNome: '{usuarioAtual.Nome}';\n" +
                $"CPF: '{usuarioAtual.CPF}';\n" +
                $"E-mail: '{usuarioAtual.Email}';\n" +
                $"Usuário: '{usuarioAtual.Login}'.", "Sim", "Não");

            


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
