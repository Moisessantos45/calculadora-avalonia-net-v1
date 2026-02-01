using CommunityToolkit.Mvvm.ComponentModel;

namespace Calculadora.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";

    [ObservableProperty]
    private string _resultado = "0";
}
