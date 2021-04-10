using System;
using Xamarin.Forms;
using Xamarin.Essentials; // Essentialsin kautta on pääsy laitteen toimintoihin

/* https://docs.microsoft.com/en-us/xamarin/essentials/flashlight?tabs=android */

namespace TaskulamppuXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void On_Button_Clicked(object sender, EventArgs e)
        {
            await Flashlight.TurnOnAsync();
        }

        private async void Off_Button_Clicked(object sender, EventArgs e)
        {
            await Flashlight.TurnOffAsync();
        }

        private void VibraOn_Button_Clicked(object sender, EventArgs e)
        {
            Vibration.Vibrate();
        }

        private void VibraOff_Button_Clicked(object sender, EventArgs e)
        {
            Vibration.Cancel();
        }
    }
}
