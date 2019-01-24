using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using App1_NossoChat.Model;
using System.Runtime.CompilerServices;
using App1_NossoChat.Service;
using Xamarin.Forms;
using System.Linq;

namespace App1_NossoChat.ViewModel
{
    public class ChatsViewModel : BaseViewModel
    {
        private List<Chat> _chats;
        public List<Chat> Chats { get => _chats; set { _chats = value; OnPropertyChanged(); } }

        public Command AdicionarCommand { get; set; }
        public Command OrdenarCommand { get; set; }
        public Command AtualizarCommand { get; set; }

        public ChatsViewModel()
        {
            Chats = ServiceWS.GetChats();

            AdicionarCommand = new Command(Adicionar);
            OrdenarCommand = new Command(Ordenar);
            AtualizarCommand = new Command(Atualizar);
        }

        private void Adicionar(object obj)
        {
            ((NavigationPage)App.Current.MainPage).Navigation.PushAsync(new View.CadastrarChat());
        }

        private void Ordenar(object obj)
        {
            Chats = Chats.OrderBy(a => a.Nome).ToList();
        }

        private void Atualizar(object obj)
        {
            Chats = ServiceWS.GetChats();
        }

    }
}
