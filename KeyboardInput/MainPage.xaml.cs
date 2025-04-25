using CommunityToolkit.Maui.Views;

namespace KeyboardInput;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var popup = new Pop();

        this.ShowPopup(popup);
    }
}
