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
            }
            else
            {
                bt.Source = "desligado";
            }
        }

        private async void LigarCamera(Boolean ligar)
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
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to turn on/off flashlight
            }
        }
    }
}
