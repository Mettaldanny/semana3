﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Habilitar navegacion
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
