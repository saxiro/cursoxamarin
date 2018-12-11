﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1Vagas.Modelo;
using App1Vagas.Banco;

namespace App1Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultarVagas : ContentPage
    {
        List<Vaga> Lista { get; set; }
        public ConsultarVagas()
        {
            InitializeComponent();
            Database database = new Database();
            Lista = database.Consultar();
            ListaVagas.ItemsSource = Lista;
            lblCount.Text = Lista.Count.ToString();
        }
        public void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastrarVaga());
        }
        public void GoMinhasVagas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }
        public void MaisDetalheAction(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            Vaga vaga = ((TapGestureRecognizer)lblDetalhe.GestureRecognizers[0]).CommandParameter as Vaga;
            Navigation.PushAsync(new DetalharVaga(vaga));
        }
        public void PesquisarAction(object sender, TextChangedEventArgs args)
        {
            ListaVagas.ItemsSource = Lista.Where(a => a.NomeVaga.Contains(args.NewTextValue)).ToList();
        }

    }
}