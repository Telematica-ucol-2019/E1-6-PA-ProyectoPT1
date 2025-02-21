﻿using Peliculas.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Peliculas.ViewModels
{
    public class DetallesPeliculaViewModel
    {
        public Pelicula Pelicula { get; set; }


        public ICommand cmdAgregarPelicula { get; set; }
        public DetallesPeliculaViewModel(Pelicula pelicula)
        {
            Pelicula = pelicula;
            cmdAgregarPelicula = new Command<Pelicula>((item) => cmdAgregarPeliculaMetodo(item));
        }
        private async void cmdAgregarPeliculaMetodo(Pelicula pelicula)
        {
            App.PeliculasDb.InsertOrUpdate(pelicula);
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
