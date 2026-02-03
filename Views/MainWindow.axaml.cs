using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Calculadora.ViewModels;

namespace Calculadora.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();

        InputTextBox.PropertyChanged += (s, e) =>
        {
            if (e.Property == TextBox.CaretIndexProperty)
                Console.WriteLine($"Cursor en: {InputTextBox.CaretIndex}");
        };
    }

    private bool _isInitialValue = true;

    private void HandleNextCaretPosition(object? sender, RoutedEventArgs e)
    {
        int cursorPosition = InputTextBox.CaretIndex;
        int textLength = InputTextBox.Text?.Length ?? 0;

        if (cursorPosition < textLength)
        {
            cursorPosition++;
            InputTextBox.CaretIndex = cursorPosition;
        }

        Console.WriteLine($"Posición del cursor: {cursorPosition}");
    }

    private void HandlePreviousCaretPosition(object? sender, RoutedEventArgs e)
    {

        int cursorPosition = InputTextBox.CaretIndex;
        if (cursorPosition > 0)
        {
            cursorPosition--;
            InputTextBox.CaretIndex = cursorPosition;
        }
        Console.WriteLine($"Posición del cursor: {cursorPosition}");

    }

    private void HandleButtonClick(object? sender, RoutedEventArgs e)
    {
        if (sender is CalcButton boton && DataContext is MainWindowViewModel vm)
        {
            string buttonTitle = boton.Titulo;
            int cursorPosition = InputTextBox.CaretIndex;

            Console.WriteLine($"Posición del cursor: {cursorPosition}");


            if (_isInitialValue && InputTextBox.Text == "0")
            {
                _isInitialValue = false;

                if (char.IsDigit(buttonTitle[0]))
                {
                    if (buttonTitle == "0")
                        return;
                    InputTextBox.Text = buttonTitle.ToLower();
                }
                else
                {
                    InputTextBox.Text += buttonTitle.ToLower();
                }
            }
            else
            {
                InputTextBox.Text += buttonTitle.ToLower();
            }
        }
    }

    private void HandleClearButtonClick(object? sender, RoutedEventArgs e)
    {
        InputTextBox.Text = "0";
        InputResultadoTextBlock.Text = "0";
        InputTextBox.CaretIndex = 0;
        _isInitialValue = true;
        HexValueTextBlock.Text = "0";
        DecValueTextBlock.Text = "0";
        OctValueTextBlock.Text = "0";
        BinValueTextBlock.Text = "0";
    }

    private void HandleDeleteButtonClick(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(InputTextBox.Text) || InputTextBox.Text.Length < 1)
        {
            HandleClearButtonClick(sender, e);
            return;

        }

        if (InputTextBox.CaretIndex == 0)
        {
            InputTextBox.Text = InputTextBox.Text[..^1];
            return;
        }

        if (InputTextBox.Text.Length == 1)
        {
            HandleClearButtonClick(sender, e);
            return;
        }

        InputTextBox.Text = InputTextBox.Text.Remove(InputTextBox.CaretIndex - 1, 1);
        InputTextBox.CaretIndex = InputTextBox.Text.Length;
    }

    private void HandleConvertButtonClick(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel vm)
        {

            var expressionEvaluator = new MultiBaseExpressionEvaluator();
            var converterModel = new ConverterModel();
            if (string.IsNullOrWhiteSpace(InputTextBox.Text))
            {
                InputResultadoTextBlock.Text = "0";
                return;
            }

            double resultado = expressionEvaluator.EvaluateExpression(InputTextBox.Text.ToLower());

            InputResultadoTextBlock.Text = resultado.ToString();
            DecValueTextBlock.Text = resultado.ToString();
            BinValueTextBlock.Text = converterModel.ConvertDecimalToBinary(resultado);
            HexValueTextBlock.Text = converterModel.ConvertDecimalToHexadecimal(resultado);
            OctValueTextBlock.Text = converterModel.ConvertDecimalToOctal(resultado);
        }
    }


}