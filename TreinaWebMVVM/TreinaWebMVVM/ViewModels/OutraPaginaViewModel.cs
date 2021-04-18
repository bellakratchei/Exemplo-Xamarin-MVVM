using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TreinaWebMVVM.ViewModels
{
    public class OutraPaginaViewModel : INotifyPropertyChanged
    {    
        private string _mensagem;

        public string Mensagem
        {
            get { return _mensagem; }
            set 
            { 
                _mensagem = value;
                OnPropertyChanged();
            }
        }

        private bool _deveExibirMensagem;

        public bool DeveExibirMensagem
        {
            get { return _deveExibirMensagem; }
            set 
            { 
                _deveExibirMensagem = value;
                OnPropertyChanged();
            }
        }

        public ICommand ProcessarCommand 
        { 
            get
            {
                return new Command<string>((cep) =>
                {
                    switch(cep.Trim())
                    {
                        case "12345-678":
                            Mensagem = "Você mora perto!";
                            break;
                        case "23456-789":
                            Mensagem = "Você mora longe!";
                            break;
                        default:
                            Mensagem = "Não sabemos onde você mora :(";
                            break;
                    }
                    DeveExibirMensagem = true;
                }, (cep) =>
                {
                    return !string.IsNullOrEmpty(cep);
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
