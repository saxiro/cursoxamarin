using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1_NossoChat.ViewModel
{
    public class CadastrarChatViewModel: BaseViewModel
    {
        private string _nome;
        private string _mensagem { get; set; }

        public string Nome { get => _nome; set { _nome = value; OnPropertyChanged(); } }
        public string Mensagem { get => _mensagem; set { _mensagem = value; OnPropertyChanged(); } }
        public Command CadastrarCommand { get; set; }

        public CadastrarChatViewModel()
        {
            CadastrarCommand = new Command(Cadastrar);
        }

        private void Cadastrar(object obj)
        {
            Model.Chat chat = new Model.Chat();
            chat.Nome = Nome;
            Service.ServiceWS.InsertChat(chat);
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
