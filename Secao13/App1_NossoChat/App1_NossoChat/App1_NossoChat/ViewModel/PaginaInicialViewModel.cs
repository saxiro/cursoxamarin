﻿using App1_NossoChat.Model;
using App1_NossoChat.Service;
using App1_NossoChat.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace App1_NossoChat.ViewModel
{
    public class PaginaInicialViewModel : INotifyPropertyChanged
    {
        private string _nome;
        private string _senha;
        private string _mensagem;

        public string Nome { get => _nome; set { _nome = value; PropertyChanged(this, new PropertyChangedEventArgs("Nome")); } }

        public string Senha { get => _senha; set { _senha = value; PropertyChanged(this, new PropertyChangedEventArgs("Senha")); } }

        public string Mensagem { get => _mensagem; set { _mensagem = value; PropertyChanged(this, new PropertyChangedEventArgs("Mensagem")); } }

        public Command AcessarCommand { get; set; }

        public PaginaInicialViewModel()
        {
            AcessarCommand = new Command(Acessar);
        }
        
        private void Acessar(object obj)
        {
            var user = new Usuario();
            user.Nome = Nome;
            user.Password = Senha;

            var usuarioLogado = ServiceWS.GetUsuario(user);

            if(usuarioLogado == null)
            {
                Mensagem = "Senha Incorreta!";
            }
            else
            {
                App.Current.Properties["LOGIN"] = JsonConvert.SerializeObject(usuarioLogado);
                App.Current.MainPage = new NavigationPage(new Chats()) { BarBackgroundColor = Color.FromHex("#5ED055"), BarTextColor = Color.White};
            }
        }
    

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
