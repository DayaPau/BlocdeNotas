using BlocdeNotas.Models;

namespace BlocdeNotas.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
        // Asegurando que el BindingContext esté correctamente asignado en el código-behind
        this.BindingContext = new About();
    }
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.About about)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }

}