using CommunityToolkit.Maui.Core.Platform;
using CommunityToolkit.Maui.Views;

namespace KeyboardInput;

public partial class Pop : Popup
{
	public Pop()
	{
		InitializeComponent();
    }

    private async void Popup_Opened(object sender, EventArgs e)
    {
        await Task.Delay(100); // 👈 Πολύ μικρό delay
        entry.Focus();         // 👈 Πλέον σίγουρα δουλεύει από την πρώτη φορά
    }

    private void entry_Completed(object sender, EventArgs e)
    {
        this.CloseAsync();
        entry.Unfocus();
    }
}