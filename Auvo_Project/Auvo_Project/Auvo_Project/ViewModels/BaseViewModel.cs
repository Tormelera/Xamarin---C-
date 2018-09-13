using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Auvo_Project.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }
            storage = value;
            OnPropertyChanged(propertyName);

            return true;


        }

        public Command SaveCommand { get; set; }
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

        
    }
}
