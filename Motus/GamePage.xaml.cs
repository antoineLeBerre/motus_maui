using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Shapes;

namespace Motus;

public partial class GamePage : ContentPage
{
    public GamePage(string value)
    {
        InitializeComponent();
        nbLettre.Text = $"Mot de {value} lettres";
        for (int i = 0; i < int.Parse(value); i++)
        {
            MotusGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = 40 });
        }

        for (int row = 0; row < 6; row++)
        {
            for (int column = 0; column < int.Parse(value); column++)
            {
                var label = new Label
                {
                    Text = ".",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    FontSize = 16,
                    TextColor = Colors.White
                };

                var border = new Border
                {
                    Content = label,
                    StrokeShape = new Rectangle(),
                    StrokeThickness = 1,
                    Margin = -1,
                    Padding = 0,
                };

                Grid.SetRow(border, row);
                Grid.SetColumn(border, column);

                MotusGrid.Children.Add(border);
            }
        }
    }

    private void OnButtonClicked(object? sender, EventArgs e)
    {
        switch (sender)
        {
            case null:
                return;
            case ImageButton imageButton:
                Console.WriteLine(imageButton == back ? $"Button Back clicked!" : $"Button Valider clicked!");
                break;
            default:
            {
                var button = (Button) sender;
                // ici vous pouvez gérer l'événement du clic comme vous le voulez
                Console.WriteLine($"Button {button.Text} clicked!");
                break;
            }
        }
    }
}