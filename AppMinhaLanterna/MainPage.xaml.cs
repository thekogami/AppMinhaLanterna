using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppMinhaLanterna
{
    public partial class MainPage : ContentPage
    {
        public bool Ligado { get; set; }

        public void SetLigadoImage(string imageSource)
        {
            this.btLigar.Source = imageSource;
        }

        public MainPage()
        {
            InitializeComponent();
            Ligado = false;
        }

        private async void btLigar_Clicked(object sender, EventArgs e)
        {
            ImageButton bt = (ImageButton)sender;
            String texto = bt.Source.ToString();
            if (texto == "File: desligado.jpg")
            {
                bt.Source = "ligado.jpg";
                await LigarCameraAsync(true);
                statusLabel.Text = "Desligue a lanterna.";
            }
            else
            {
                bt.Source = "desligado.jpg";
                await LigarCameraAsync(false);
                statusLabel.Text = "Ligue a lanterna.";
            }

            Ligado = !Ligado;
        }

        private async System.Threading.Tasks.Task LigarCameraAsync(Boolean ligar)
        {
            try
            {
                if (ligar)
                    await Flashlight.TurnOnAsync(); // Turn On
                else
                    await Flashlight.TurnOffAsync(); // Turn Off
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                await DisplayAlert("Erro", fnsEx.Message, "OK");
            }
            catch (PermissionException pEx)
            {
                await DisplayAlert("Erro", pEx.Message, "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}