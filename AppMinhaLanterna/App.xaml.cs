using Xamarin.Forms;
using Xamarin.Essentials;

namespace AppMinhaLanterna
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            base.OnStart();

            var mainPage = MainPage as MainPage;
            if (mainPage?.Ligado ?? false)
            {
                mainPage.SetLigadoImage("ligado.png");
            }
        }

        protected override async void OnSleep()
        {
            bool isLigado = (MainPage as MainPage)?.Ligado ?? false;

            if (isLigado)
            {
                await Flashlight.TurnOffAsync();
                (MainPage as MainPage)?.SetLigadoImage("desligado.jpg");
            }
        }

        protected override async void OnResume()
        {
            if ((MainPage as MainPage)?.Ligado ?? false)
            {
                await Flashlight.TurnOnAsync();
                (MainPage as MainPage)?.SetLigadoImage("ligado.png");
            }
        }
    }
}
