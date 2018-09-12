using System;
using System.Collections.Generic;
using System.Text;
using Auvo_Project.ViewModels;

namespace Auvo_Project
{
    public class Usuario : MainViewModel
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (SetProperty(ref _nome, value))
                    SaveCommand.ChangeCanExecute() ;
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
                if(SetProperty(ref _email, value))
                    SaveCommand.ChangeCanExecute();
            }
        }

        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                if(SetProperty(ref _login, value))
                    SaveCommand.ChangeCanExecute();
            }
        }

        private string _senha;

        public string Senha
        {
            get { return _senha; }
            set
            {
                if(SetProperty(ref _senha, value))
                    SaveCommand.ChangeCanExecute();
            }
        }
    }
}
