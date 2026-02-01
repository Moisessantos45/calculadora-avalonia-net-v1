using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using Avalonia.Media;

namespace Calculadora;

public partial class CalcButton : UserControl
{

    public static readonly StyledProperty<string> TituloProperty =
        AvaloniaProperty.Register<CalcButton, string>(nameof(Titulo));
    public string Titulo
    {
        get => GetValue(TituloProperty);
        set => SetValue(TituloProperty, value);
    }

    public bool TieneSombra
    {
        get => GetValue(TieneSombraProperty);
        set => SetValue(TieneSombraProperty, value);
    }

    public static readonly StyledProperty<string> ColorProperty =
        AvaloniaProperty.Register<CalcButton, string>(nameof(Color), "Blue");

    public static readonly RoutedEvent<RoutedEventArgs> ClickMiBotonEvent =
        RoutedEvent.Register<CalcButton, RoutedEventArgs>("ClickMiBoton", RoutingStrategies.Bubble);

    public static readonly StyledProperty<bool> TieneSombraProperty =
        AvaloniaProperty.Register<CalcButton, bool>(nameof(TieneSombra), true);

    public event EventHandler<RoutedEventArgs>? ClickMiBoton
    {
        add => AddHandler(ClickMiBotonEvent, value);
        remove => RemoveHandler(ClickMiBotonEvent, value);
    }

    public CalcButton()
    {
        InitializeComponent();
        this.FindControl<Button>("MiBotonInterno")!.Click += OnClickInterno;
    }

    private void OnClickInterno(object? sender, RoutedEventArgs e)
    {
        RaiseEvent(new RoutedEventArgs(ClickMiBotonEvent));
    }
}
