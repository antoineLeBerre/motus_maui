using RadioButton = Microsoft.Maui.Controls.RadioButton;

namespace Motus;

public partial class MainPage : ContentPage
{
    private string _value = "5";
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        var rb = sender as RadioButton; 
        _value = rb?.Value.ToString()!;
    }

    private async void ChangePage(object? sender, EventArgs e)
    {
        await Shell.Current.Navigation.PushAsync(new GamePage(_value));
    }
}