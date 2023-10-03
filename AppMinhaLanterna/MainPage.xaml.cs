using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppMinhaLanterna
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btLigar_Clicked(object sender, EventArgs e)
        {
            ImageButton bt = (ImageButton)sender;
            String texto = bt.Source.ToString();
            if(texto == "File: desligado")
            {
                bt.Source = "ligado";
                this.LigarCameraAsync(true);
            }
            else
            {
                bt.Source = "desligado";
                this.LigarCameraAsync(true);
            }
        }

        private async void LigarCameraAsync(Boolean ligar)
        {
            try
            {
                if (ligar == true)
                {
                    // Turn On
                    await Flashlight.TurnOnAsync();
                }
                else
                {
                    // Turn Off
                    await Flashlight.TurnOffAsync();
                }               
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
                //await DisplayAlert("Erro", fnsEx.Message, "OK");
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
                //await DisplayAlert("Erro", pEx.Message, "OK");
            }
            catch (Exception ex)
            {
                // Unable to turn on/off flashlight
                //await DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}
