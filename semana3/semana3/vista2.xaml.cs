using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vista2 : ContentPage
    {
        public vista2(string user, string pass)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
        }
    }
}