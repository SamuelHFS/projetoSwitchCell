using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace projetoSwitchCell
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //lbNome.Text += "\n" + TxtNome.Text;
            if (TxtNome.Text != null)
            {
                lbNome.Text += "\n" + TxtNome.Text;
            }
            else
            {
                DisplayAlert("Atenção", "Preencha o campo Nome", "Ok");
            }
            if (TxtEmail.Text != null)
            {
                lbNome.Text += "\n" + TxtEmail.Text;
            }
            else
            {
                DisplayAlert("Atenção", "Preencha o campo Email", "Ok");
            }
            if (SwitchEnviaCelular.On)
            {
                if (TxtCelular.Text == null)
                {
                    DisplayAlert("Atenção", "Preencha o campo Celular", "Ok");
                }
                else
                {
                    lbNome.Text += "\n" + TxtCelular.Text;
                }

            }

            if (pck1.SelectedItem == null)
            {
                DisplayAlert("Atenção", "Escolha uma das opções de Profissão", "Ok");
            }
            else
            {
                lbNome.Text += "\n" + pck1.SelectedItem;
            }

        }

        private void BtLimpar(object sender, EventArgs e)
        {
            lbNome.Text = null;
            TxtEmail.Text = null;
            TxtCelular.Text = null;
            TxtNome.Text = null;
            pck1.SelectedIndex = 5;
        }

        private void swt(object sender, ToggledEventArgs e)
        {
            if (SwitchEnviaCelular.On)
            {
                TxtCelular.IsEnabled = true;
            }
            else
            {
                TxtCelular.Text = null;
                TxtCelular.IsEnabled = false;
            }
        }
        }
}
